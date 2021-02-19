using AutoMapper;
using OnlineShop.Web.Application.Interfaces;
using OnlineShop.Web.Application.ViewModels.ShoppingCart;
using OnlineShop.Web.Models.Entity;
using OnlineShop.Web.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Web.Application.Services
{
    public class ShoppingCartService : IShoppingCartService
    {
        private readonly IShoppingCartRepository _repository;
        private ShoppingCart shoppingCart;

        public ShoppingCartService(IShoppingCartRepository repository)
        {
            _repository = repository;
        }

        public async Task GetShoppingCart()
        {
            shoppingCart = await _repository.GetShoppingCart();
        }

        public async Task<ShoppingCartVM> RetriveShopppingCart()
        {
            await GetShoppingCart();
            var VM = new ShoppingCartVM()
            {
                Items = shoppingCart.Items.ToList(),
                Total = await GetTotal()
            };
            return VM;
    }

        public async Task AddItemToShoppingCart(int mobilePhoneId)
        {
            await GetShoppingCart();
            await _repository.AddItemToCart(shoppingCart, mobilePhoneId);
        }

        public async Task DeleteAllItems()
        {
            await _repository.DeleteAllItems(shoppingCart);
        }

        public async Task RemoveItemFromCart(int mobilePhoneId)
        {
            await _repository.RemoveItemFromCart(shoppingCart, mobilePhoneId);
        }

        public async Task<double> GetTotal()
        {
            return await _repository.CountTotal(shoppingCart);
        }

    }
}
