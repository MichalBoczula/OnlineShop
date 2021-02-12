//using AutoMapper;
//using Microsoft.AspNetCore.Http;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.Extensions.DependencyInjection;
//using OnlineShop.Web.Infrastructure;
//using OnlineShop.Web.Models.Entity;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace OnlineShop.Web.Helper
//{
//    public class ShoppingCartGenerator
//    {
//        public string ShoppingCartId { get; set; }
//        public List<ShoppingCartItem> Items { get; set; }
//        private readonly DatabaseContext _context;

//        private ShoppingCartGenerator(DatabaseContext context)
//        {
//            _context = context;
//        }

//        public static ShoppingCartGenerator GetCart(IServiceProvider services)
//        {
//            ISession session = services.GetRequiredService<IHttpContextAccessor>()?
//                .HttpContext.Session;
            
//            var context = services.GetService<DatabaseContext>();

//            string cartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();

//            session.SetString("CartId", cartId);

//            return new ShoppingCartGenerator(context) { ShoppingCartId = cartId };
//        }

//        public async Task AddItemToCart(int mobileId)
//        {
//            var item = await _context.ShoppingCartItems
//                .FirstOrDefaultAsync(i => i.MobilePhone.Id == mobileId && i.ShoppingCartId == ShoppingCartId);
//            var mobilePhone = await _context.MobilePhones.FirstOrDefaultAsync(m => m.Id == mobileId);

//            if (item == null)
//            {
//                item = new ShoppingCartItem
//                {
//                    ShoppingCartId = ShoppingCartId,
//                    MobilePhone = mobilePhone,
//                    Quantity = 1
//                };
//                await _context.ShoppingCartItems.AddAsync(item);
//            }
//            else
//            {
//                item.Quantity++;
//            }
//            await _context.SaveChangesAsync();
//        }

//        public async Task<int> RemoveFromCart(int mobilePhoneId)
//        {
//            var item = await _context.ShoppingCartItems
//                .FirstOrDefaultAsync(i => i.MobilePhone.Id == mobilePhoneId && i.ShoppingCartId == ShoppingCartId);
//            var change = 0;
//            if (item != null)
//            {
//                if (item.Quantity > 1)
//                {
//                    item.Quantity--;
//                    change = item.Quantity;
//                }
//                else
//                {
//                    _context.ShoppingCartItems.Remove(item);
//                }
//            }
//            await _context.SaveChangesAsync();

//            return change;
//        }

//        public async Task<List<ShoppingCartItem>> GetItems()
//        {
//            var result = Items ?? await _context.ShoppingCartItems.Where(i => i.ShoppingCartId == ShoppingCartId)
//                                                   .Include(m => m.MobilePhone)
//                                                   .ToListAsync();
//            return result;
//        }

//        public async Task DeleteAllItems()
//        {
//            var items = await _context.ShoppingCartItems.Where(s => s.ShoppingCartId == ShoppingCartId).ToListAsync();
//            _context.ShoppingCartItems.RemoveRange(items);
//            await _context.SaveChangesAsync();
//        }

//        public async Task<double> CountTotal()
//        {
//            var total = await _context.ShoppingCartItems.Where(s => s.ShoppingCartId == ShoppingCartId)
//                .Select(m => m.MobilePhone.Price * m.Quantity).SumAsync();
//            return total;
//        }
//    }
//}
