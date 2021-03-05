using AutoMapper;
using OnlineShop.Web.Application.Mapping;
using OnlineShop.Web.Application.ViewModels.Mobile;
using OnlineShop.Web.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Web.Application.ViewModels.Order
{
    public class OrderMobilePhoneVM : IMapFrom<OrderMobilePhone>
    {
        public MobilePhoneForOrderSummaryVM MobilePhoneRef { get; set; }
        public int Quantity { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<OrderMobilePhone, OrderMobilePhoneVM>();
        }
    }
}
