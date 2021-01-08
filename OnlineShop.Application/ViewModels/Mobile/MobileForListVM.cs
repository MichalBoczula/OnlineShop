using AutoMapper;
using OnlineShop.Application.Mapping;
using OnlineShop.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.Application.ViewModels.Mobile
{
    public class MobileForListVM : IMapFrom<MobilePhone>
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string MainImage { get; set; }
        public string ShortDescription { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<MobilePhone, MobileForListVM>();
        }
    }
}
