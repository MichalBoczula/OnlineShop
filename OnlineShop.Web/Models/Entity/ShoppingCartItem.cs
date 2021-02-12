using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.Web.Models.Entity
{
    public class ShoppingCartItem
    {
        public int Id { get; set; }
        public MobilePhone MobilePhone { get; set; }
        public int Quantity { get; set; }
        public string ShoppingCartId { get; set; }

    }
}
