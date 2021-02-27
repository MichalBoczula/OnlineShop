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
        public int Id { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }
#nullable enable
        public string? FlatNumber { get; set; }
#nullable disable

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Models.Entity.ShippingAddress, ShippingAddressVM>();
        }
    }
}
