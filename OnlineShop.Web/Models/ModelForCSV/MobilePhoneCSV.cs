﻿using OnlineShop.Web.Models.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.Web.Models.ModelForCSV
{
    public class MobilePhoneCSV
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string MainImage { get; set; }
        public string FirstImage { get; set; }
        public string SecondImage { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public bool ActiveStatus { get; set; }
        public bool BestSeller { get; set; }
        public QuantityStatus QuantityInStack { get; set; }
    }
}
