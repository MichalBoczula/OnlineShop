using OnlineShop.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnlineShop.Domain.Interfaces
{
    public interface IMobileRepository
    {
        IQueryable<MobilePhone> GetAllActiveMobiles();
        MobilePhone GetMobileById(int mobilePhoneId);
    }
}
