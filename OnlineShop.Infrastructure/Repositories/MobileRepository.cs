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
        private readonly MockDBContext _mockDBContext;

        public MobileRepository()
        {
            _mockDBContext = new MockDBContext();
        }

        public IQueryable<MobilePhone> GetAllActiveMobiles()
        {
            return _mockDBContext.GetMobiles()
                                 .Where(m => m.ActiveStatus == true)
                                 .AsQueryable();
        }

        public IQueryable<MobilePhone> GetBestSellers()
        {
            return _mockDBContext.GetMobiles()
                                 .Where(m => m.BestSeller == true)
                                 .AsQueryable();
        }

        public MobilePhone GetMobileById(int mobilePhoneId)
        {
            return _mockDBContext.GetMobiles()
                                 .FirstOrDefault(m => m.Id == mobilePhoneId);
        }
    }
}
