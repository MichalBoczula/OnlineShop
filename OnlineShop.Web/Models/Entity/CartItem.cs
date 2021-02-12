using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.Web.Models.Entity
{
    public class CartItem
    {
        public int Id { get; set; }
        public int ShoppingCartId { get; set; }
        public ShoppingCart ShoppingCart { get; set; }
        public MobilePhone MobilePhone { get; set; }
        public int Quantity { get; set; }
    }
}
