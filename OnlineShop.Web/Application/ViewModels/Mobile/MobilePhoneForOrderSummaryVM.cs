using AutoMapper;
using OnlineShop.Web.Application.Mapping;
using OnlineShop.Web.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Web.Application.ViewModels.Mobile
{
    public class MobilePhoneForOrderSummaryVM : IMapFrom<MobilePhone>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string MainImage { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<MobilePhone, MobilePhoneForOrderSummaryVM>();
        }
    }
}
