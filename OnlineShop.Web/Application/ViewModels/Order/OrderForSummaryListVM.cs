using AutoMapper;
using OnlineShop.Web.Application.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Web.Application.ViewModels.Order
{
    public class OrderForSummaryListVM : IMapFrom<Models.Entity.Order>
    {
        public string Id { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Models.Entity.Order, OrderForSummaryListVM>();
        }
    }
}
