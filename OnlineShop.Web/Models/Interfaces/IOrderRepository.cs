using OnlineShop.Web.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Web.Models.Interfaces
{
    public interface IOrderRepository
    {
        Task<int> AddOrder(ShoppingCart shoppingCart, int shippingAddressId);

        Task<List<Order>> GetOrders(string userId);

        Task<Order> GetOrderbyId(string orderNumber);

    }
}
