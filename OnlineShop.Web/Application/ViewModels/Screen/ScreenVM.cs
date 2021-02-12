using AutoMapper;
using OnlineShop.Web.Application.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.Web.Application.ViewModels.Screen
{
    public class ScreenVM : IMapFrom<Models.Entity.Screen>
    {
        public int Id;
        public decimal Size;
        public int ColorsQuantity;
        public string ScreenType;
        public int HorizontalResolution;
        public int VerticalResolution;

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Models.Entity.Screen, ScreenVM >();
        }
    }
}
