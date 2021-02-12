using Microsoft.EntityFrameworkCore;
using OnlineShop.Web.Models.Entity;
using OnlineShop.Web.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Web.Infrastructure.Repositories
{
    public class MobilePhoneRepository : IMobilePhoneRepository
    {
        private readonly DatabaseContext context;

        public MobilePhoneRepository(DatabaseContext context)
        {
            this.context = context;
        }

        public IQueryable<MobilePhone> GetAllActiveMobilePhones()
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

        public async Task<MobilePhone> GetMobilePhoneById(int mobilePhoneId)
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
