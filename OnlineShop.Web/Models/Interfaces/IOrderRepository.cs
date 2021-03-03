using OnlineShop.Web.Application.ViewModels.ShoppingCart;
using OnlineShop.Web.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Web.Models.Interfaces
{
    public interface IOrderRepository
    {
        Task<string> AddOrder(ShoppingCartVM shoppingCartVM, string userId, int shippingAddressId);

        IQueryable<Order> GetOrders(string userId);

        Task<Order> GetOrderbyId(int orderId);

    }
}
