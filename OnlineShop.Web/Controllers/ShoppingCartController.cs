﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Web.Controllers
{
    public class ShoppingCartController : Controller
    {
        //private readonly ShoppingCartGenerator _shoppingCart;

        //public ShoppingCartController(ShoppingCartGenerator shoppingCart)
        //{
        //    _shoppingCart = shoppingCart;
        //}

        //public async Task<IActionResult> Index()
        //{
        //    var items = await _shoppingCart.GetItems();
        //    _shoppingCart.Items = items;
        //    var ViewModel = new ShoppingCartVM
        //    {
        //        ShoppingCart = _shoppingCart,
        //        Total = await _shoppingCart.CountTotal()
        //    };
        //    return View(ViewModel);
        //}

        //public async Task<RedirectToActionResult> AddItem(int mobileId)
        //{
        //    await _shoppingCart.AddItemToCart(mobileId);
        //    return RedirectToAction("Index");
        //}

        //public async Task<RedirectToActionResult> RemoveItem(int mobileId)
        //{
        //    await _shoppingCart.RemoveFromCart(mobileId);
        //    return RedirectToAction("Index");
        //}
    }
}
