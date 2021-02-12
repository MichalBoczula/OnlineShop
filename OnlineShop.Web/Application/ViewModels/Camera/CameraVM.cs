using AutoMapper;
using OnlineShop.Web.Application.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.Web.Application.ViewModels.Camera
{
    public class CameraVM : IMapFrom<OnlineShop.Web.Models.Entity.Camera>
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
            profile.CreateMap<OnlineShop.Web.Models.Entity.Camera, CameraVM>();
        }
    }
}
