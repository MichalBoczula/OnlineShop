using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Web.Models.Entity
{
    public class ShippingAddress
    {
        public int Id { get; set; }
        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUserRef { get; set; }
        public ICollection<Order> Orders { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }
#nullable enable
        public string? FlatNumber { get; set; }
#nullable disable


    }
}
