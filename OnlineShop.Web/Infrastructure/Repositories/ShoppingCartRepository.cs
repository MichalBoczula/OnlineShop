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
        private ShoppingCart memoryShoppingCart;

        public ShoppingCartRepository(DatabaseContext context,
                                      UserManager<ApplicationUser> userManager,
                                      IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _userManager = userManager;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task GetShoppingCart()
        {
            var loggedUser = _httpContextAccessor.HttpContext.User;
            var user = await _userManager.GetUserAsync(loggedUser);

            var applicationUser  = await _context.Users
             .Include(sc => sc.ShoppingCart)
             .ThenInclude(i => i.Items)
             .FirstOrDefaultAsync(u => u.Id == user.Id);

            memoryShoppingCart = applicationUser.ShoppingCart;
        }

        public Task<int> RemoveItemFromCart(int mobilePhoneId)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAllItems()
        {
            throw new NotImplementedException();
        }

        public Task<double> CountTotal()
        {
            throw new NotImplementedException();
        }

        public Task AddItemToCart(int mobilePhoneId)
        {
            throw new NotImplementedException();
        }
    }
}
