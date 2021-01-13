using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.Application.ViewModels.Multimedia
{
    public class MultimediaVM
    {
        public int Id { get; set; }
        public string WiFiStandard { get; set; }
        public string USBType { get; set; }
        public bool Bluetooth { get; set; }
        public bool NFC { get; set; }
        public bool FingerPrintReader { get; set; }
        public int DownloadDataSpeed { get; set; }
        public int SendDataSpeed { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<OnlineShop.Domain.Model.Multimedia, MultimediaVM>();
        }
    }
}
