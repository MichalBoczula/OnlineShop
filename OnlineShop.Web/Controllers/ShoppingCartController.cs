using Microsoft.AspNetCore.Mvc;
using OnlineShop.Web.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Web.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IShoppingCartService _service;

        public ShoppingCartController(IShoppingCartService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var items = await _service.RetriveItems();
            //var ViewModel = new ShoppingCartVM
            //{
            //    ShoppingCart = _shoppingCart,
            //    Total = await _shoppingCart.CountTotal()
            //};
            return View();
        }

        public async Task<RedirectToActionResult> AddItem(int mobileId)
        {
            await _service.AddItemToShoppingCart(mobileId);
            return RedirectToAction("Index");
        }

        public async Task<RedirectToActionResult> RemoveItem(int mobileId)
        {
            await _service.RemoveItemFromCart(mobileId);
            return RedirectToAction("Index");
        }

        public async Task<RedirectToActionResult> ClearCart()
        {
            await _service.DeleteAllItems();
            return RedirectToAction("Index");
        }
    }
}
