using OnlineShop.Web.Application.ViewModels.Order;
using OnlineShop.Web.Application.ViewModels.ShippingAddress;
using OnlineShop.Web.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Web.Application.Interfaces
{
    public interface IOrderService
    {
        Task AddOrder(OrderVM orderVM);

        Task<OrderVM> GetOrderDetails(int shippingAddressId);
    }
}
