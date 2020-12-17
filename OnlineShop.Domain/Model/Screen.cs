using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.Domain.Model
{
    public class Screen
    {
        public int Id { get; set; }
        public int Size { get; set; }
        /// <summary>
        /// In mln 
        /// </summary>
        public int ColorsQuantity { get; set; }
        public string ScreenType { get; set; }
        public int HorizontalResolution { get; set; }
        public int VerticalResolution { get; set; }
        public ICollection<MobilePhone> MobilePhones { get; set; }

    }
}
