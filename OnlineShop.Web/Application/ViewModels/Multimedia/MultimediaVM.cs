using AutoMapper;
using OnlineShop.Web.Application.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.Web.Application.ViewModels.Multimedia
{
    public class MultimediaVM : IMapFrom<OnlineShop.Web.Models.Entity.Multimedia>
    {
        public int Id;
        public string USBType;
        public bool Bluetooth;
        public bool NFC;
        public bool FingerPrintReader;
        public bool LTE;
        public bool GPS;
        public bool WiFiCalling;

        public void Mapping(Profile profile)
        {
            profile.CreateMap<OnlineShop.Web.Models.Entity.Multimedia, MultimediaVM>();
        }
    }
}
