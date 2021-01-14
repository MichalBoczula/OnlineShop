using AutoMapper;
using OnlineShop.Application.Mapping;
using OnlineShop.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.Application.ViewModels.Mobile
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
            profile.CreateMap<OnlineShop.Domain.Model.MobilePhone, MobilePhoneForHomeVM>();
        }
    }
}
