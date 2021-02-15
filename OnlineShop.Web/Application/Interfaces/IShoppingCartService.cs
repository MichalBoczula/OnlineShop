using OnlineShop.Web.Application.ViewModels.ShoppingCart;
using OnlineShop.Web.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Web.Application.Interfaces
{
    public interface IShoppingCartService
    {
        Task GetShoppingCart();

        Task<ShoppingCartVM> RetriveShopppingCart();

        Task AddItemToShoppingCart(int mobilePhoneId);

        Task DeleteAllItems();

        Task RemoveItemFromCart(int mobilePhoneId);

        Task<double> GetTotal();
        
    }
}
