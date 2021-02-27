using Microsoft.EntityFrameworkCore;
using OnlineShop.Web.Models.Entity;
using OnlineShop.Web.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Web.Infrastructure.Repositories
{
    public class ShippingAddressRepository : IShippingAddressRepository
    {
        private readonly DatabaseContext _context;

        public ShippingAddressRepository(DatabaseContext context)
        {
            _context = context;
        }

        public async Task AddShippingAddress(ShippingAddress shippingAddress)
        {
            await _context.ShippingAddresses.AddAsync(shippingAddress);
            await _context.SaveChangesAsync();
        }

        public IQueryable<ShippingAddress> GetShippingAddresses(string userId)
        {
            return _context.ShippingAddresses.Where(sa => sa.ApplicationUserId == userId).AsQueryable();
        }

        public async Task<ShippingAddress> GetShippingAddressById(int shippingAddressId)
        {
            return await _context.ShippingAddresses.FirstOrDefaultAsync(sa => sa.Id == shippingAddressId);
        }

        public async Task RemoveShippingAddress(int shippingAddressId)
        {
            var model = await GetShippingAddressById(shippingAddressId);
            if(model != null)
            {
                _context.ShippingAddresses.Remove(model);
                await _context.SaveChangesAsync();
            }
        }

        public async Task UpdateShippingAddress(ShippingAddress shippingAddress)
        {
            _context.ShippingAddresses.Update(shippingAddress);
            await _context.SaveChangesAsync();
        }

    }
}
