using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.Application.ViewModels.Screen
{
    public class ScreenVM
    {
        public int Id { get; set; }
        public int Size { get; set; }
        public int ColorsQuantity { get; set; }
        public string ScreenType { get; set; }
        public int HorizontalResolution { get; set; }
        public int VerticalResolution { get; set; }
    }
}
