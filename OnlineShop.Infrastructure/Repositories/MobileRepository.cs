using OnlineShop.Domain.Interfaces;
using OnlineShop.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnlineShop.Infrastructure.Repositories
{
    public class MobileRepository : IMobileRepository
    {
        public IQueryable<MobilePhone> GetAllActiveMobiles()
        {
            throw new NotImplementedException();
        }

        public MobilePhone GetMobileById(int mobilePhoneId)
        {
            throw new NotImplementedException();
        }
    }
}
