using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Web.Models.Entity
{
    public class OrderMobilePhone
    {
        public string OrderId { get; set; }
        public Order OrderRef { get; set; }
        public int MobilePhoneId { get; set; }
        public MobilePhone MobilePhoneRef { get; set; }
        public int Quantity { get; set; }
    }
}
