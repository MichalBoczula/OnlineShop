using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OnlineShop.Web.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Web.Controllers
{
    [Authorize]
    public class ShoppingCartController : Controller
    {
        private readonly IShoppingCartService _service;

        public ShoppingCartController(IShoppingCartService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var items = await _service.RetriveShopppingCart();
            return View(items);
        }

        public async Task<RedirectToActionResult> AddItem(int mobileId)
        {
            await _service.AddItemToShoppingCart(mobileId);
            return RedirectToAction("Details", "MobilePhone", new { mobilePhoneId = mobileId });
        }

        public async Task<RedirectToActionResult> RemoveItem(int mobileId)
        {
            await _service.RemoveItemFromCart(mobileId);
            return RedirectToAction(nameof (Index));
        }

        public async Task<RedirectToActionResult> ClearCart()
        {
            await _service.DeleteAllItems();
            return RedirectToAction(nameof(Index));
        }
    }
}
