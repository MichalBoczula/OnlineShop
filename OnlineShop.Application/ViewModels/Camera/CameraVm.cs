using AutoMapper;
using OnlineShop.Application.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.Application.ViewModels.Camera
{
    public class CameraVM : IMapFrom<OnlineShop.Domain.Model.Camera>
    {
        public int Id;
        public int Zoom;
        public int FrontResulution;
        public int MainResulution;
        public int AdditionalResulution;
        public string VideoRecorderResolution;
        public int VideoFPS;
        public string Functions;

        public void Mapping(Profile profile)
        {
            profile.CreateMap<OnlineShop.Domain.Model.Camera, CameraVM>();
        }
    }
}
