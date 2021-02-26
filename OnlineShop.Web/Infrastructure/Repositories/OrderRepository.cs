using OnlineShop.Web.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Web.Infrastructure.Repositories
{
    public class OrderRepository
    {
        private readonly DatabaseContext _context;

        public OrderRepository(DatabaseContext context)
        {
            _context = context;
        }


        public async Task<int> AddOrder(ShoppingCart shoppingCart)
        {
            var order = new Order()
            {
                ApplicationUserId = shoppingCart.ApplicationUser.Id,
                ApplicationUserRef = shoppingCart.ApplicationUser,
            };
            await _context.SaveChangesAsync();
            foreach(var item in shoppingCart.Items)
            {
                var orderItem = new OrderMobilePhone()
                {
                    OrderRef = order,
                    OrderId = order.Id,
                    MobilePhoneId = item.MobilePhoneId,
                    MobilePhoneRef = item.MobilePhoneRef,
                    Quantity = item.Quantity
                };
                order.Items.Add(orderItem);
            }
            return order.Id;
        }
    }
}
