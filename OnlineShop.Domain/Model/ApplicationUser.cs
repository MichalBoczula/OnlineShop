using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Domain.Model
{
    public class ApplicationUser : IdentityUser
    {
        public int ShoppingCardId{ get; set; }
        public ShoppingCart ShoppingCart{ get; set; }
    }
}
