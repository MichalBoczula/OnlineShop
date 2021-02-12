using AutoMapper;
using OnlineShop.Web.Application.Mapping;
using OnlineShop.Web.Models.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.Web.Application.ViewModels.Mobile
{
    public class MobilePhoneForHomeVM : IMapFrom<MobilePhone>
    {
        public int Id;
        public string Brand;
        public string Name;
        public bool BestSeller;
        public bool ActiveStatus;
        public string MainImage;

        public void Mapping(Profile profile)
        {
            profile.CreateMap<MobilePhone, MobilePhoneForHomeVM>();
        }
    }
}
