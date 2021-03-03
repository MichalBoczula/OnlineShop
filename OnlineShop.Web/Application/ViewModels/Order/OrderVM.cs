using OnlineShop.Web.Application.ViewModels.ShippingAddress;
using OnlineShop.Web.Application.ViewModels.ShoppingCart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Web.Application.ViewModels.Order
{
    public class OrderVM
    {
        public string UserId { get; set; }
        public ShippingAddressVM ShippingAddressVM { get; set; }
        public ShoppingCartVM ShoppingCartVM { get; set; }
    }
}
