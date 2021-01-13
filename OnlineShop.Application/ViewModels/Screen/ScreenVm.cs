using AutoMapper;
using OnlineShop.Application.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.Application.ViewModels.Screen
{
    public class ScreenVM : IMapFrom<OnlineShop.Domain.Model.Screen>
    {
        public int Id { get; set; }
        public decimal Size { get; set; }
        public int ColorsQuantity { get; set; }
        public string ScreenType { get; set; }
        public int HorizontalResolution { get; set; }
        public int VerticalResolution { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<OnlineShop.Domain.Model.Screen, ScreenVM>();
        }
    }
}
