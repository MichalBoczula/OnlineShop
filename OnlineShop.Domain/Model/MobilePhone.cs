using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.Domain.Model
{
    public class MobilePhone
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
        public Camera Camera { get; set; }
        public Screen Screen { get; set; }
        public Hardware Hardware { get; set; }
        public Multimedia Multimedia { get; set; }
    }
}
