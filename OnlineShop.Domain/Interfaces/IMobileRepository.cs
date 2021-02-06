using OnlineShop.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Domain.Interfaces
{
    public interface IMobileRepository
    {
        IQueryable<MobilePhone> GetAllActiveMobiles();
        IQueryable<MobilePhone> GetBestSellers();
        Task<MobilePhone> GetMobileById(int mobilePhoneId);
    }
}
