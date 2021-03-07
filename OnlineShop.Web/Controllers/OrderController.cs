using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using OnlineShop.Web.Application.Interfaces;
using OnlineShop.Web.Application.Services;
using OnlineShop.Web.Application.ViewModels.Mobile;
using OnlineShop.Web.Application.ViewModels.Order;
using OnlineShop.Web.Application.ViewModels.ShippingAddress;
using OnlineShop.Web.Application.ViewModels.ShoppingCart;
using OnlineShop.Web.Models.Entity;
using OnlineShop.Web.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Web.Controllers
{
    [Authorize]
    public class OrderController : Controller
    {
        private readonly IOrderService _service;
        private readonly IDocumentService _document;

        public OrderController(IOrderService service, IDocumentService document)
        {
            _service = service;
            _document = document;
        }

        [HttpPost]
        public async Task<IActionResult> OrderSummary(ShippingAddressVM shippingAddressVM)
        {
            var orderVM = await _service.GetOrderSummary(shippingAddressVM.Id);
            return View(orderVM);
        }

        [HttpPost]
        public async Task<IActionResult> Finalize(OrderVM orderVM)
        {
            var model = await _service.GetOrderSummary(orderVM.ShippingAddressVM.Id);
            await _service.AddOrder(model);
            return RedirectToAction("Summary");
        }

        public IActionResult Summary()
        {
            return View();
        }

        public async Task<IActionResult> Orders()
        {
            var model = await _service.GetOrders();
            return View(model);
        }

        public async Task<IActionResult> OrderDetails(string orderId)
        {
            var model = await _service.GetOrderDetails(orderId);
            return View(model);
        }

        [HttpGet]
        public async Task<ActionResult> GetInvoice(string orderId)
        {
            var orderVm = await _service.GetOrderDetails(orderId);
            var file = _document.CreatePDFStream(orderVm, null);
            return File(file, "application/pdf");
        }

    }
}
