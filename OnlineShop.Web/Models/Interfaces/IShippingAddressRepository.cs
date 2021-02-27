using OnlineShop.Web.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Web.Models.Interfaces
{
    public interface IShippingAddressRepository
    {

        Task AddShippingAddress(ShippingAddress shippingAddress);

        IQueryable<ShippingAddress> GetShippingAddresses(string userId);

        Task<ShippingAddress> GetShippingAddressById(int shippingAddressId);

        Task RemoveShippingAddress(int shippingAddressId);

        Task UpdateShippingAddress(ShippingAddress shippingAddress);
       
    }
}
