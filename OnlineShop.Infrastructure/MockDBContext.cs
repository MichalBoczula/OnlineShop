using OnlineShop.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.Infrastructure
{
    public class MockDBContext
    {
        private readonly List<MobilePhone> mobilePhones;
        
        public MockDBContext()
        {
            mobilePhones = new List<MobilePhone>();
            mobilePhones.AddRange(Seed());
        }

        private List<MobilePhone> Seed()
        {
            var  phones = new List<MobilePhone>();
            var mobile1 = new MobilePhone()
            {
                Id = 1,
                Brand = "Apple",
                Name = "Iphon",
                Price = 3000,
                ShortDescription = "",
                Description = "",
                ActiveStatus = true,
                QuantityInStack = QuantityStatus.Full,
            };
            var mobile2 = new MobilePhone()
            {
                Id = 1,
                Brand = "Apple",
                Name = "Iphon",
                Price = 3000,
                ShortDescription = "",
                Description = "",
                ActiveStatus = true,
                QuantityInStack = QuantityStatus.Full,
            };
            var mobile3 = new MobilePhone()
            {
                Id = 1,
                Brand = "Apple",
                Name = "Iphon",
                Price = 3000,
                ShortDescription = "",
                Description = "",
                ActiveStatus = true,
                QuantityInStack = QuantityStatus.Full,
            };
            phones.Add(mobile1);
            phones.Add(mobile2);
            phones.Add(mobile3);
            return phones;
        }

        public List<MobilePhone> GetMobiles()
        {
            return mobilePhones;
        }

    }
}
