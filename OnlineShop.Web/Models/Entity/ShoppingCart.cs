using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.Web.Models.Entity
{
    public class ShoppingCart
    {
        public int Id { get; set; }
        public ICollection<CartItem> Items { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}
