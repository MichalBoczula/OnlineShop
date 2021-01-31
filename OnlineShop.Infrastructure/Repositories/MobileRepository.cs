using Microsoft.EntityFrameworkCore;
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
        private readonly DatabaseContext context;

        public MobileRepository(DatabaseContext context)
        {
            this.context = context;
        }

        public IQueryable<MobilePhone> GetAllActiveMobiles()
        {
            return context.MobilePhones
                                 .Where(m => m.ActiveStatus == true)
                                 .AsQueryable();
        }

        public IQueryable<MobilePhone> GetBestSellers()
        {
            return context.MobilePhones
                                 .Where(m => m.BestSeller == true)
                                 .AsQueryable();
        }

        public MobilePhone GetMobileById(int mobilePhoneId)
        {
            return context.MobilePhones.Include(c => c.Camera)
                                       .Include(h => h.Hardware)
                                       .Include(f => f.Multimedia)
                                       .Include(s => s.Screen)
                                       .FirstOrDefault(m => m.Id == mobilePhoneId);
        }
    }
}
