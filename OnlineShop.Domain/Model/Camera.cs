using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.Domain.Model
{
    public class Camera
    {
        public int Id { get; set; }
        public int Zoom { get; set; }
        public int FrontResulution { get; set; }
        public int MainResulution { get; set; }
        public int AdditionalResulution { get; set; }
        public string VideoRecorderResolution { get; set; }
        public int VideoFPS { get; set; }
        public string Functions { get; set; }
        public int MobilePhoneId { get; set; }
        public MobilePhone MobilePhoneRef { get; set; }

    }
}
