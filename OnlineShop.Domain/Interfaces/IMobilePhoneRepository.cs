using OnlineShop.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Domain.Interfaces
{
    public interface IMobilePhoneRepository
    {
        IQueryable<MobilePhone> GetAllActiveMobilePhones();
        IQueryable<MobilePhone> GetBestSellers();
        Task<MobilePhone> GetMobilePhoneById(int mobilePhoneId);
    }
}
