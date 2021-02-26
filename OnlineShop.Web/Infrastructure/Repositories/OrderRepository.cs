using OnlineShop.Web.Models.Entity;
using OnlineShop.Web.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Web.Infrastructure.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly DatabaseContext _context;

        public OrderRepository(DatabaseContext context)
        {
            _context = context;
        }

        public async Task<int> AddOrder(ShoppingCart shoppingCart, int shippingAddressId)
        {
            if (shoppingCart.Items.Count == 0) return -1;
            var userId = shoppingCart.ApplicationUser.Id;
            var order = new Order()
            {
                ApplicationUserId = userId,
                ApplicationUserRef = shoppingCart.ApplicationUser,
                OrderNumber = Guid.NewGuid().ToString(),
                ShippingAddressId = shippingAddressId
            };
            await _context.AddAsync(order);
            await _context.SaveChangesAsync();
            foreach (var item in shoppingCart.Items)
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
            _context.Update(order);
            await _context.SaveChangesAsync();
            var userOrder = new ApplicationUserOrder()
            {
                OrderId = order.Id,
                ApplicationUserId = userId
            };
            await _context.AddAsync(userOrder);
            await _context.SaveChangesAsync();
            return order.Id;
        }

        public async Task<List<Order>> GetOrders(string userId)
        {
            throw new NotImplementedException();
        }

        public async Task<Order> GetOrderbyId(string orderNumber)
        {
            throw new NotImplementedException();
        }
    }
}
