using AutoMapper;
using OnlineShop.Application.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.Application.ViewModels.Screen
{
    public class ScreenVM : IMapFrom<OnlineShop.Domain.Model.Screen>
    {
        public int Id;
        public decimal Size;
        public int ColorsQuantity;
        public string ScreenType;
        public int HorizontalResolution;
        public int VerticalResolution;

        public void Mapping(Profile profile)
        {
            profile.CreateMap<OnlineShop.Domain.Model.Screen, ScreenVM>();
        }
    }
}
