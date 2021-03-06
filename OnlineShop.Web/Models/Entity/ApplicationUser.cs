﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Web.Models.Entity
{
    public class ApplicationUser : IdentityUser
    {
        public string ShoppingCardId{ get; set; }
        public ShoppingCart ShoppingCart{ get; set; }
        public ICollection<Order> Orders { get; set; }
        public ICollection<ShippingAddress> ShippingAddresses { get; set; }
    }
}
