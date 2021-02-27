using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineShop.Web.Application.Interfaces;
using OnlineShop.Web.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Web.Controllers
{
    public class ShippingAddressController : Controller
    {
        private readonly IShippingAddressService _service;

        public ShippingAddressController(IShippingAddressService service)
        {
            _service = service;
        }

        public async Task<IActionResult> IndexShippingAddress()
        {
            var VM = await _service.GetShippingAddresses();
            return View(VM);
        }

        public ActionResult Details(int shippingAddressId)
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(IndexShippingAddress));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Edit(int id)
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(IndexShippingAddress));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Delete(int shippingAddressId)
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(IndexShippingAddress));
            }
            catch
            {
                return View();
            }
        }
    }
}
