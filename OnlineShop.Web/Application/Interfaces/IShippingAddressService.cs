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
        Task AddShippingAddress(ShippingAddressCreateVM shippingAddressAddVM);

        Task<List<ShippingAddressVM>> GetShippingAddresses();

        Task<ShippingAddressVM> GetShippingAddressById(int shippingAddressId);

        Task RemoveShippingAddress(int shippingAddressId);

        Task UpdateShippingAddress(ShippingAddressVM shippingAddressVM);

    }
}
