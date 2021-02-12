﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.Web.Models.Entity
{
    public class Screen
    {
        public int Id { get; set; }
        public decimal Size { get; set; }
        public int ColorsQuantity { get; set; }
        public string ScreenType { get; set; }
        public int HorizontalResolution { get; set; }
        public int VerticalResolution { get; set; }
        public int MobilePhoneId { get; set; }
        public MobilePhone MobilePhoneRef { get; set; }

    }
}
