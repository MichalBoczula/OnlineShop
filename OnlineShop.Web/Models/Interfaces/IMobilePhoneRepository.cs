using OnlineShop.Web.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Web.Models.Interfaces
{
    public interface IMobilePhoneRepository
    {
        IQueryable<MobilePhone> GetAllActiveMobilePhones();
        IQueryable<MobilePhone> GetBestSellers();
        Task<MobilePhone> GetMobilePhoneById(int mobilePhoneId);
    }
}
