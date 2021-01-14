using AutoMapper;
using OnlineShop.Application.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.Application.ViewModels.Multimedia
{
    public class MultimediaVM : IMapFrom<OnlineShop.Domain.Model.Multimedia>
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
            profile.CreateMap<OnlineShop.Domain.Model.Multimedia, MultimediaVM>();
        }
    }
}
