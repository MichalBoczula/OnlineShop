using Microsoft.EntityFrameworkCore;
using OnlineShop.Domain.Interfaces;
using OnlineShop.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public async Task<MobilePhone> GetMobileById(int mobilePhoneId)
        {
            var result = await context.MobilePhones.Include(c => c.Camera)
                                       .Include(h => h.Hardware)
                                       .Include(f => f.Multimedia)
                                       .Include(s => s.Screen)
                                       .FirstOrDefaultAsync(m => m.Id == mobilePhoneId);
            return result;
        }
    }
}
