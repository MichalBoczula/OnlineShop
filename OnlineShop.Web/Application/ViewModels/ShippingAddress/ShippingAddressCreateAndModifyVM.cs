using AutoMapper;
using OnlineShop.Web.Application.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Web.Application.ViewModels.ShippingAddress
{
    public class ShippingAddressCreateAndModifyVM : IMapFrom<Models.Entity.ShippingAddress>
    {
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }
#nullable enable
        public string? FlatNumber { get; set; }
#nullable disable

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Models.Entity.ShippingAddress, ShippingAddressCreateAndModifyVM>().ReverseMap();
        }
    }
}
