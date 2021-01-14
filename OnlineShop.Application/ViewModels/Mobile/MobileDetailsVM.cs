using AutoMapper;
using OnlineShop.Application.Mapping;
using OnlineShop.Application.ViewModels.Camera;
using OnlineShop.Application.ViewModels.Hardware;
using OnlineShop.Application.ViewModels.Screen;
using OnlineShop.Application.ViewModels.Multimedia;
using OnlineShop.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.Application.ViewModels.Mobile
{
    public class MobileDetailsVM : IMapFrom<MobilePhone>
    {
        public int Id;
        public string Brand;
        public string Name;
        public double Price;
        public string MainImage;
        public string FirstImage;
        public string SecondImage;
        public string ThirdImage;
        public string Description;
        public QuantityStatus QuantityInStack;
        public CameraVM Camera;
        public ScreenVM Screen;
        public HardwareVM Hardware;
        public MultimediaVM Multimedia;

        public void Mapping(Profile profile)
        {
            profile.CreateMap<MobilePhone, MobileDetailsVM>()
                .ForMember(m => m.Camera, opt => opt.Ignore())
                .ForMember(m => m.Screen, opt => opt.Ignore())
                .ForMember(m => m.Hardware, opt => opt.Ignore())
                .ForMember(m => m.Multimedia, opt => opt.Ignore());
        }
    }
}
