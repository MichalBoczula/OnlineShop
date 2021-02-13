using OnlineShop.Web.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Web.Models.Interfaces
{
    public interface IShoppingCartRepository
    {
        Task<ShoppingCart> GetShoppingCart();

        Task RemoveItemFromCart(ShoppingCart shoppingCart, int mobilePhoneId);

        Task DeleteAllItems(ShoppingCart shoppingCart);

        Task<double> CountTotal(ShoppingCart shoppingCart);

        Task AddItemToCart(ShoppingCart shoppingCart, int mobilePhoneId);

    }
}
