using AutoMapper;
using OnlineShop.Web.Application.Mapping;
using OnlineShop.Web.Application.ViewModels.ShippingAddress;
using OnlineShop.Web.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Web.Application.ViewModels.Order
{
    public class OrderDetailsVM : IMapFrom<Models.Entity.Order>
    {
        public ShippingAddressVM ShippingAddressRef { get; set; }
        public ICollection<OrderMobilePhoneVM> Items { get; set; }
        public double Total { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Models.Entity.Order, OrderDetailsVM>()
                .ForMember(i => i.Total, opt => opt.Ignore());
        }

        public void CountTotal()
        {
            Total = Items.Select(i => i.MobilePhoneRef.Price * i.Quantity).Sum();
        }
    }
}
