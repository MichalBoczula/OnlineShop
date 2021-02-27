using OnlineShop.Web.Application.ViewModels.ShippingAddress;
using OnlineShop.Web.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Web.Application.Interfaces
{
    public interface IShippingAddressService
    {
        Task AddShippingAddress(ShippingAddressVM shippingAddressVM);

        Task<List<ShippingAddressVM>> GetShippingAddresses(string userId);

        Task<ShippingAddressVM> GetShippingAddressById(int shippingAddressId);

        Task RemoveShippingAddress(int shippingAddressId);

        Task UpdateShippingAddress(ShippingAddressVM shippingAddressVM);

    }
}
