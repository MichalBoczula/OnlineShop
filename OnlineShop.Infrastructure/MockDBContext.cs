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
                Name = "iPhone 12",
                Price = 3000,
                ShortDescription = "Donec sagittis molestie feugiat. " +
                "Duis ac enim eu ex imperdiet hendrerit. Aenean molestie, " +
                "leo sit amet dapibus gravida, metus nisl volutpat massa, " +
                "in scelerisque diam ante id diam.",
                Description = "Donec sagittis molestie feugiat." +
                " Duis ac enim eu ex imperdiet hendrerit. " +
                "Aenean molestie, leo sit amet dapibus gravida, " +
                "metus nisl volutpat massa, in scelerisque diam ante id diam. " +
                "Suspendisse semper nulla vel lectus venenatis cursus. " +
                "Sed tincidunt auctor euismod. Praesent et mollis nisi, " +
                "quis porta tellus. " +
                "Aliquam eget arcu vel velit vestibulum ultrices eu sed nulla." +
                " Morbi augue velit, mattis sed ipsum in, molestie ultricies quam." +
                " Nam vitae malesuada nisl. Sed tempor dui in ullamcorper facilisis. " +
                "Nam nec nulla sit amet ligula finibus aliquet. Aenean ante lacus," +
                " venenatis cursus eros ut, efficitur mollis nisl.",
                ActiveStatus = true,
                QuantityInStack = QuantityStatus.Full,
                MainImage = "/Apple/iPhone 12/Main.png"
            };
            var mobile2 = new MobilePhone()
            {
                Id = 2,
                Brand = "Samsung",
                Name = "Galaxy Z Fold2 5G",
                Price = 4000,
                ShortDescription = "Nunc eget sapien quis eros semper tincidunt." +
                " Proin rhoncus blandit diam, a vulputate augue tristique ut." +
                " Vivamus tincidunt ligula purus, vel pellentesque nunc lacinia ut.",
                Description = "Nunc eget sapien quis eros semper tincidunt. " +
                "Proin rhoncus blandit diam, a vulputate augue tristique ut." +
                " Vivamus tincidunt ligula purus, vel pellentesque nunc lacinia ut. " +
                "Phasellus vehicula sed risus vitae aliquet. Sed neque metus, " +
                "sollicitudin blandit venenatis hendrerit, pulvinar at diam." +
                " Fusce blandit eu arcu vitae aliquet. " +
                "Donec placerat at felis in convallis. " +
                "Nam tristique neque sed dolor pharetra, sed vestibulum nulla varius." +
                " Phasellus non diam nunc. Cras dignissim scelerisque tortor," +
                " vel sodales massa ornare sed. Pellentesque consectetur nisl eros," +
                " nec lobortis sem interdum sit amet.",
                ActiveStatus = true,
                QuantityInStack = QuantityStatus.Full,
                MainImage = "/Apple/iPhone 12/Main.png"
            };
            var mobile3 = new MobilePhone()
            {
                Id = 3,
                Brand = "LG",
                Name = "Wing 5G",
                Price = 4500,
                ShortDescription = "Sed eget dui vitae est ultricies aliquet sit amet sed" +
                " lectus. Morbi sit amet pellentesque quam. " +
                "Nulla viverra commodo tortor ac dictum. Morbi nec sapien nec velit" +
                " ullamcorper dictum.",
                Description = "Sed eget dui vitae est ultricies aliquet sit amet sed" +
                " lectus. Morbi sit amet pellentesque quam. Nulla viverra commodo" +
                " tortor ac dictum. Morbi nec sapien nec velit ullamcorper dictum." +
                " Aenean eget eros faucibus, egestas nisi vel, lobortis mauris." +
                " Quisque luctus risus quam, nec bibendum sapien imperdiet ut." +
                " Nulla iaculis mauris leo, a finibus leo varius sed." +
                " Aenean tristique orci vel convallis luctus." +
                " Aenean a enim ac nulla congue aliquam." +
                " Vestibulum lobortis turpis sit amet augue vestibulum tincidunt." +
                " Proin nec libero scelerisque, efficitur libero sed, interdum augue." +
                " Suspendisse condimentum accumsan condimentum." +
                " Suspendisse vitae pellentesque ante.",
                ActiveStatus = true,
                QuantityInStack = QuantityStatus.Full,
                MainImage = "/Apple/iPhone 12/Main.png"
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
