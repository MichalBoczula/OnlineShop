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
        public List<string> Functions { get; set; }
        public ICollection<MobilePhone> MobilePhones { get; set; }

    }
}
