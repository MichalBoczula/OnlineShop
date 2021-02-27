using AutoMapper;
using OnlineShop.Web.Application.Mapping;
using OnlineShop.Web.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Web.Application.ViewModels.ShippingAddress
{
    public class ShippingAddressVM : IMapFrom<Models.Entity.ShippingAddress>
    {
        public int Id;
        public string PostalCode;
        public string City;
        public string Street;
        public string HouseNumber;
#nullable enable
        public string? FlatNumber;
#nullable disable

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Models.Entity.ShippingAddress, ShippingAddressVM>();
        }
    }
}
