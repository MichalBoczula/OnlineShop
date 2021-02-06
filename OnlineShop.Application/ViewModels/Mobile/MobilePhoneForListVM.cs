using AutoMapper;
using OnlineShop.Application.Mapping;
using OnlineShop.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.Application.ViewModels.Mobile
{
    public class MobilePhoneForListVM : IMapFrom<MobilePhone>
    {
        public int Id;
        public string Brand;
        public string Name;
        public double Price;
        public string MainImage;
        public string ShortDescription;

        public void Mapping(Profile profile)
        {
            profile.CreateMap<MobilePhone, MobilePhoneForListVM>();
        }
    }
}
