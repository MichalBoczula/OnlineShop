using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Web.Models.Entity
{
    public class Order
    {
        public Order()
        {
            Items = new List<OrderMobilePhone>();
        }

        public int Id { get; set; }
        public ICollection<OrderMobilePhone> Items { get; set; }
        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUserRef { get; set; }
        public int  ShippingAddressId { get; set; }
        public ShippingAddress  ShippingAddressRef { get; set; }
    }
}
