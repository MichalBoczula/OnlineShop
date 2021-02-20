using Microsoft.AspNetCore.Mvc;
using OnlineShop.Web.Application.Interfaces;
using OnlineShop.Web.Application.ViewModels.ShoppingCart;
using OnlineShop.Web.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Web.Components
{
    public class ShoppingCartItems : ViewComponent
    {
        private readonly IShoppingCartRepository _repository;

        public ShoppingCartItems(IShoppingCartRepository repository)
        {
            _repository = repository;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var shoppingCart = await _repository.GetShoppingCart();
            
            if(shoppingCart == null)
            {
                var emptyVM = new ShoppingCartVC()
                {
                    ItemsCount = 0
                };
                return View(emptyVM);
            }

            var VM = new ShoppingCartVC()
            {
                ItemsCount = shoppingCart.Items.Select(i => i.Quantity).Sum()
            };
            return View(VM);
        }
    }
}
