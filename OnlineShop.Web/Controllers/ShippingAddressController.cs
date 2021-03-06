﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineShop.Web.Application.Interfaces;
using OnlineShop.Web.Application.ViewModels.ShippingAddress;
using OnlineShop.Web.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Web.Controllers
{
    [Authorize]
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

        public IActionResult AddShippingAddress()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddShippingAddress(ShippingAddressCreateVM ShippingAddressAddVM)
        {
            await _service.AddShippingAddress(ShippingAddressAddVM);
            return RedirectToAction(nameof(IndexShippingAddress));
        }

        public async Task<IActionResult> EditShippingAddress(int shippingAddressId)
        {
            var VM = await _service.GetShippingAddressById(shippingAddressId);
            return View(VM);
        }

        [HttpPost]
        public async Task<IActionResult> EditShippingAddress(ShippingAddressVM shippingAddressVM)
        {
            await _service.UpdateShippingAddress(shippingAddressVM);
            return RedirectToAction(nameof(IndexShippingAddress));
        }

        public async Task<IActionResult> DeleteShippingAddress (int shippingAddressId)
        {
            await _service.RemoveShippingAddress(shippingAddressId);
            return RedirectToAction(nameof(IndexShippingAddress));
        }

        public async Task<IActionResult> ShippingAddressProfile()
        {
            var VM = await _service.GetShippingAddresses();
            return View(VM);
        }

    }
}
