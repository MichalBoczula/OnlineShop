using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.Web.Models.Entity
{
    public class ShoppingCart
    {
        public ShoppingCart()
        {
            Items = new List<ShoppingCartMobilePhone>();
        }

        public int Id { get; set; }
        public ICollection<ShoppingCartMobilePhone> Items { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}
