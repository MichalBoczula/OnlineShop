using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.Domain.Model
{
    public class Multimedia
    {
        public int Id { get; set; }
        public string WiFiStandard { get; set; }
        public string USBType { get; set; }
        public string Bluetooth { get; set; }
        public bool NFC { get; set; }
        public bool FingerPrintReader { get; set; }
        public int DownloadDataSpeed { get; set; }
        public int SendDataSpeed { get; set; }

        public ICollection<MobilePhone> MobilePhones { get; set; }
    }
}
