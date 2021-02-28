using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using OnlineShop.Web.Application.Interfaces;
using OnlineShop.Web.Application.Services;
using OnlineShop.Web.Application.ViewModels.Order;
using OnlineShop.Web.Application.ViewModels.ShoppingCart;
using OnlineShop.Web.Models.Entity;
using OnlineShop.Web.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Web.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderService _service;

        public OrderController(IOrderService service)
        {
            _service = service;
        }

        public async Task<IActionResult> OrderSummary(int shippingAddressId)
        {
            var VM = await _service.GetOrderDetails(shippingAddressId);
            return View(VM);
        }
    }
}
