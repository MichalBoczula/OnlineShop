using Microsoft.AspNetCore.Mvc;
using OnlineShop.Application.Interfaces;
using OnlineShop.Web.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Web.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly ShoppingCart shoppingCart;
        private readonly IMobilePhoneService mobilePhoneService;


        public ShoppingCartController(ShoppingCart shoppingCart, IMobilePhoneService mobilePhoneService)
        {
            this.shoppingCart = shoppingCart;
            this.mobilePhoneService = mobilePhoneService;
        }
    }
}
