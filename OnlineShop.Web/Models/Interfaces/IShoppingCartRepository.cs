using OnlineShop.Web.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Web.Models.Interfaces
{
    public interface IShoppingCartRepository
    {
        Task GetShoppingCart();
        Task AddItemToCart(int mobilePhoneId);
        Task<int> RemoveItemFromCart(int mobilePhoneId);
        Task DeleteAllItems();
        Task<double> CountTotal();
    }
}
