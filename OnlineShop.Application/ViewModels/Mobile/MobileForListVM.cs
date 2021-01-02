using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.Application.ViewModels.Mobile
{
    public class MobileForListVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string MainImage { get; set; }
        public string ShortDescription { get; set; }
    }
}
