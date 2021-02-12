using AutoMapper;
using OnlineShop.Web.Application.Mapping;
using OnlineShop.Web.Application.ViewModels.Camera;
using OnlineShop.Web.Application.ViewModels.Hardware;
using OnlineShop.Web.Application.ViewModels.Multimedia;
using OnlineShop.Web.Application.ViewModels.Screen;
using OnlineShop.Web.Models.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.Web.Application.ViewModels.Mobile
{
    public class MobilePhoneDetailsVM : IMapFrom<MobilePhone>
    {
        public int Id;
        public string Brand;
        public string Name;
        public double Price;
        public string MainImage;
        public string FirstImage;
        public string SecondImage;
        public string Description;
        public QuantityStatus QuantityInStack;
        public CameraVM Camera;
        public ScreenVM Screen;
        public HardwareVM Hardware;
        public MultimediaVM Multimedia;

        public void Mapping(Profile profile)
        {
            profile.CreateMap<MobilePhone, MobilePhoneDetailsVM>()
                .ForMember(m => m.Camera, opt => opt.Ignore())
                .ForMember(m => m.Screen, opt => opt.Ignore())
                .ForMember(m => m.Hardware, opt => opt.Ignore())
                .ForMember(m => m.Multimedia, opt => opt.Ignore());
        }
    }
}
