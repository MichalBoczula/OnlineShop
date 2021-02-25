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

        public IQueryable<MobilePhone> RetriveFilteredMobilePhones(Filters filters)
        {
            var query = context.MobilePhones
                                 .Where(m => m.ActiveStatus == true);
            
            if (!String.IsNullOrEmpty(filters.OperationSystem) && !(filters.OperationSystem == "All"))
            {
                query = query.Include(h => h.Hardware);
                query = query.Where(m => m.Hardware.OperationSystem == filters.OperationSystem);
            }
            if (filters.MainResolution != 0 && filters.MainResolution != null)
            {
                query = query.Include(c => c.Camera);
                query = query.Where(m => m.Camera.MainResulution >= filters.MainResolution);
            }
            if (filters.FrontResolution != 0 && filters.FrontResolution != null)
            {
                query = query.Include(c => c.Camera);
                query = query.Where(m => m.Camera.FrontResulution >= filters.FrontResolution);
            }
            if (filters.MemorySpace != 0)
            {
                query = query.Include(h => h.Hardware);
                query = query.Where(m => m.Hardware.MemorySpace >= filters.MemorySpace);
            }
            if (filters.OperationMemory != 0)
            {
                query = query.Include(h => h.Hardware);
                query = query.Where(m => m.Hardware.OperationMemory >= filters.OperationMemory);
            }
            //if (filters.LowerPrice != null)
            //{
            //    query = query.Where(m => filters.LowerPrice   m.Price);
            //}
            if (filters.MaxPrice != null && filters.MaxPrice != null)
            {
                if (filters.MaxPrice > filters.MinPrice)
                {
                    query = query.Where(m => m.Price >= filters.MinPrice && m.Price <= filters.MaxPrice);
                }
                else
                {
                    query = query.Where(m => m.Price >= filters.MinPrice);
                }
            }
            else if (filters.MaxPrice != null && filters.MinPrice == null)
            {
                query = query.Where(m => m.Price <= filters.MaxPrice);
            }
            else if (filters.MaxPrice == null && filters.MinPrice != null)
            {
                query = query.Where(m => m.Price >= filters.MinPrice);
            }

            var listOFBrands = CreateListOfBrands(filters);

            if (listOFBrands.Count > 0)
            {
                query = query.Where(m => listOFBrands.Any(x => x == m.Brand));
            }

            return query.AsQueryable();
        }


        private List<string> CreateListOfBrands(Filters filters)
        {
            var listOFBrands = new List<string>();
            if (filters.Brands.Apple)
            {
                listOFBrands.Add("Apple");
            }
            if (filters.Brands.Huawei)
            {
                listOFBrands.Add("Huawei");
            }
            if (filters.Brands.LG)
            {
                listOFBrands.Add("LG");
            }
            if (filters.Brands.Motorola)
            {
                listOFBrands.Add("Motorola");
            }
            if (filters.Brands.Nokia)
            {
                listOFBrands.Add("Nokia");
            }
            if (filters.Brands.Oppo)
            {
                listOFBrands.Add("Oppo");
            }
            if (filters.Brands.Samsung)
            {
                listOFBrands.Add("Samsung");
            }
            if (filters.Brands.Sony)
            {
                listOFBrands.Add("Sony");
            }
            if (filters.Brands.Xiaomi)
            {
                listOFBrands.Add("Xiaomi");
            }
            return listOFBrands;
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
