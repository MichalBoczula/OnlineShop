using Microsoft.EntityFrameworkCore;
using OnlineShop.Web.Models.Entity;
using OnlineShop.Web.Models.Filters;
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

        public IQueryable<MobilePhone> GetFilteredMobilePhones(string filter)
        {
            return context.MobilePhones
                                 .Where(m => m.ActiveStatus == true && m.Hardware.OperationSystem == filter)
                                 .AsQueryable();
        }

        public IQueryable<MobilePhone> RetriveFilteredMobilePhones(Filters filters)
        {
            var query = context.MobilePhones
                                 .Where(m => m.ActiveStatus == true);

            if (!String.IsNullOrEmpty(filters.OperationSystem))
            {
                query = query.Include(h => h.Hardware);
                query = query.Where(m => m.Hardware.OperationSystem == filters.OperationSystem);
            }
            if (filters.MainResolution != null)
            {
                query = query.Include(c => c.Camera);
                query = query.Where(m => m.Camera.MainResulution >= filters.MainResolution);
            }
            if (filters.FrontResolution != null)
            {
                query = query.Include(c => c.Camera);
                query = query.Where(m => m.Camera.FrontResulution >= filters.FrontResolution);
            }
            if (filters.MemorySpace != null)
            {
                query = query.Include(h => h.Hardware);
                query = query.Where(m => m.Hardware.MemorySpace >= filters.MemorySpace);
            }
            if (filters.OperationMemory != null)
            {
                query = query.Include(h => h.Hardware);
                query = query.Where(m => m.Hardware.OperationMemory >= filters.OperationMemory);
            }
            if (filters.LowerPrice != null)
            {
                query = query.Where(m => m.Price >= filters.LowerPrice);
            }
            if (filters.MaxPrice != null)
            {
                query = query.Where(m => m.Price <= filters.MaxPrice);
            }
            if (filters.ScreenSize != null)
            {
                query = query.Include(s => s.Screen);
                query = query.Where(m => m.Screen.Size >= filters.ScreenSize);
            }
            if (filters.Brands.Count > 0)
            {
                query = query.Where(m => filters.Brands.Any(x => x == m.Brand));
            }

            return query.AsQueryable();
        }

        public IQueryable<MobilePhone> GetBestSellers()
        {
            return context.MobilePhones
                                 .Where(m => m.BestSeller == true)
                                 .AsQueryable();
        }

        public async Task<MobilePhone> GetMobilePhoneById(int mobilePhoneId)
        {
            return await context.MobilePhones.Include(c => c.Camera)
                                       .Include(h => h.Hardware)
                                       .Include(f => f.Multimedia)
                                       .Include(s => s.Screen)
                                       .FirstOrDefaultAsync(m => m.Id == mobilePhoneId);
        }
    }
}
