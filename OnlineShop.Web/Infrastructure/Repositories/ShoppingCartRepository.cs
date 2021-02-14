using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using OnlineShop.Web.Models.Entity;
using OnlineShop.Web.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Web.Infrastructure.Repositories
{
    public class ShoppingCartRepository : IShoppingCartRepository
    {
        private readonly DatabaseContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public ShoppingCartRepository(DatabaseContext context,
                                      UserManager<ApplicationUser> userManager,
                                      IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _userManager = userManager;
            _httpContextAccessor = httpContextAccessor;
        }

        public ShoppingCartRepository(DatabaseContext context)
        {
            _context = context;
        }

        public async Task<ShoppingCart> GetShoppingCart()
        {
            var loggedUser = _httpContextAccessor.HttpContext.User;
            var userId = _userManager.GetUserId(loggedUser);

            var applicationUser = await _context.Users
             .Include(sc => sc.ShoppingCart)
             .ThenInclude(i => i.Items)
             .FirstOrDefaultAsync(u => u.Id == userId);

            return applicationUser.ShoppingCart;
        }

        public async Task RemoveItemFromCart(ShoppingCart shoppingCart, int mobilePhoneId)
        {
            var item = await _context.ShoppingCartMobilePhones
                .FirstOrDefaultAsync(sc => sc.ShoppingCartId == shoppingCart.Id
                    && sc.MobilePhoneId == mobilePhoneId);
            if (item.Quantity > 1)
            {
                item.Quantity--;
            }
            else
            {
                _context.ShoppingCartMobilePhones.Remove(item);
            }
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAllItems(ShoppingCart shoppingCart)
        {
            var list = await _context.ShoppingCartMobilePhones
                .Where(sc => sc.ShoppingCartId == shoppingCart.Id).ToListAsync();
            _context.ShoppingCartMobilePhones.RemoveRange(list);
            await _context.SaveChangesAsync();
        }

        public async Task<double> CountTotal(ShoppingCart shoppingCart)
        {
            return await _context.ShoppingCartMobilePhones
                .Where(sc => sc.ShoppingCartId == shoppingCart.Id)
                .Select(i => i.MobilePhoneRef.Price * i.Quantity)
                .SumAsync();
        }

        public async Task AddItemToCart(ShoppingCart shoppingCart, int mobilePhoneId)
        {
           var cartItem =  shoppingCart.Items
                .FirstOrDefault(i => i.MobilePhoneId == mobilePhoneId && shoppingCart.Id == i.ShoppingCartId);
            if(cartItem != null)
            {
                cartItem.Quantity++;
            }
            else
            {
                var item = await _context.MobilePhones
                .FirstOrDefaultAsync(m => m.Id == mobilePhoneId);
                var shoppingCartItem = new ShoppingCartMobilePhone()
                {
                    ShoppingCartId = shoppingCart.Id,
                    MobilePhoneId = item.Id,
                    Quantity = 1
                };
                cartItem = shoppingCartItem;
                shoppingCart.Items.Add(cartItem);
            }
            _context.Update(shoppingCart);
            await _context.SaveChangesAsync();
        }
    }
}
