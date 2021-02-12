using OnlineShop.Web.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Web.Models.Interfaces
{
    public interface IUserRepository
    {
        Task<ApplicationUser> GetActualLoggedInUser();
    }
}
