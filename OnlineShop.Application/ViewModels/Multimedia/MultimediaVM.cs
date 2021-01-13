using AutoMapper;
using OnlineShop.Application.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.Application.ViewModels.Multimedia
{
    public class MultimediaVM : IMapFrom<OnlineShop.Domain.Model.Multimedia>
    {
        public int Id { get; set; }
        public string USBType { get; set; }
        public bool Bluetooth { get; set; }
        public bool NFC { get; set; }
        public bool FingerPrintReader { get; set; }
        public bool LTE { get; set; }
        public bool GPS { get; set; }
        public bool WiFiCalling { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<OnlineShop.Domain.Model.Multimedia, MultimediaVM>();
        }
    }
}
