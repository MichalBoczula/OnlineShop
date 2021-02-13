using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.Web.Models.Entity
{
    public class ShoppingCartMobilePhone
    {
        public int ShoppingCartId { get; set; }
        public ShoppingCart ShoppingCartRef { get; set; }
        public int MobilePhoneId { get; set; }
        public MobilePhone MobilePhoneRef { get; set; }
        public int Quantity { get; set; }
    }
}
