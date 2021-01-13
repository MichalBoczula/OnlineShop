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
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string MainImage { get; set; }
        public string FirstImage { get; set; }
        public string SecondImage { get; set; }
        public string ThirdImage { get; set; }
        public string Description { get; set; }
        public QuantityStatus QuantityInStack { get; set; }
        public CameraVM Camera { get; set; }
        public ScreenVM Screen { get; set; }
        public HardwareVM Hardware { get; set; }
        public MultimediaVM Multimedia { get; set; }

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
