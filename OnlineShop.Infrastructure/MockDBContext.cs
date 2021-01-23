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
            var phones = new List<MobilePhone>();
            var hardwareiPhone12 = new Hardware()
            {
                Id = 1,
                ProcessorName = "A14 Bionic",
                OperationSystem = "iOS",
                GraphicsProcessor = "A14 Bionic",
                OperationMemory = 4,
                MemorySpace = 64,
                SimCardType = "Nano",
                BatteryCapacity = 2500
            };
            var cameraiPhone12 = new Camera()
            {
                Id = 1,
                Zoom = 8,
                FrontResulution = 16,
                MainResulution = 32,
                AdditionalResulution = 16,
                VideoRecorderResolution = "4K",
                VideoFPS = 120,
                Functions = new List<string>()
                {
                    "Video Recorder",
                    "Autofokus",
                    "Flash"
                }
            };
            var screeniPhone12 = new Screen()
            {
                Id = 1,
                Size = 6.1m,
                ColorsQuantity = 16,
                ScreenType = "OLED Super Retina XDR",
                HorizontalResolution = 2532,
                VerticalResolution = 1170
            };
            var multimediaApple = new Multimedia()
            {
                Id = 1,
                USBType = "Lighting",
                Bluetooth = true,
                NFC = true,
                FingerPrintReader = true,
                LTE = true,
                GPS = true,
                WiFiCalling = false
            };
            var multimediaAndroid = new Multimedia()
            {
                Id = 1,
                USBType = "USB C",
                Bluetooth = true,
                NFC = true,
                FingerPrintReader = true,
                LTE = true,
                GPS = true,
                WiFiCalling = false
            };
            var iPhone12 = new MobilePhone()
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
                MainImage = "/Apple/iPhone 12/Main.png",
                FirstImage = "/Apple/iPhone 12/First.png",
                SecondImage= "/Apple/iPhone 12/Second.png",
                Hardware = hardwareiPhone12,
                Camera = cameraiPhone12,
                Multimedia = multimediaApple,
                Screen = screeniPhone12,
                BestSeller = true
            };

            var hardwareFold2 = new Hardware()
            {
                Id = 2,
                ProcessorName = "Qualcomm",
                OperationSystem = "Android",
                GraphicsProcessor = "Adreno 650",
                OperationMemory = 12,
                MemorySpace = 256,
                SimCardType = "Nano",
                BatteryCapacity = 4500
            };
            var cameraFold2 = new Camera()
            {
                Id = 2,
                Zoom = 2,
                FrontResulution = 12,
                MainResulution = 12,
                AdditionalResulution = 12,
                VideoRecorderResolution = "4K",
                VideoFPS = 60,
                Functions = new List<string>()
                {
                    "Video Recorder",
                    "Autofokus",
                    "Flash"
                }
            };
            var screenFold2 = new Screen()
            {
                Id = 2,
                Size = 6.1m,
                ColorsQuantity = 16,
                ScreenType = "Dynamic AMOLED 2X",
                HorizontalResolution = 2208,
                VerticalResolution = 1768
            };
            var fold2 = new MobilePhone()
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
                MainImage = "/Samsung/Galaxy Z Fold2/Main.png",
                FirstImage = "/Samsung/Galaxy Z Fold2/First.png",
                SecondImage = "/Samsung/Galaxy Z Fold2/Second.png",
                Hardware = hardwareFold2,
                Camera = cameraFold2,
                Multimedia = multimediaAndroid,
                Screen = screenFold2,
                BestSeller = true

            };

            var hardwareLgWing = new Hardware()
            {
                Id = 3,
                ProcessorName = "Qualcomm Snapdragon 765G",
                OperationSystem = "Android",
                GraphicsProcessor = "Adreno 620 GPU",
                OperationMemory = 8,
                MemorySpace = 128,
                SimCardType = "Nano",
                BatteryCapacity = 4000
            };
            var cameraLgWing = new Camera()
            {
                Id = 3,
                Zoom = 2,
                FrontResulution = 32,
                MainResulution = 64,
                AdditionalResulution = 12,
                VideoRecorderResolution = "4K",
                VideoFPS = 120,
                Functions = new List<string>()
                {
                    "Video Recorder",
                    "Autofokus",
                    "Flash",
                    "Night Mode",
                    "Gimbal",
                    "AI CAM",
                    "AR Stickers"
                }
            };
            var screenLgWing = new Screen()
            {
                Id = 3,
                Size = 6.8m,
                ColorsQuantity = 16,
                ScreenType = "FHD+ P-OLED FullVision",
                HorizontalResolution = 2460,
                VerticalResolution = 1080
            };
            var lgWing = new MobilePhone()
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
                MainImage = "/LG/Wing/Main.png",
                FirstImage = "/LG/Wing/First.png",
                SecondImage = "/LG/Wing/Second.png",
                Hardware = hardwareLgWing,
                Camera = cameraLgWing,
                Multimedia = multimediaAndroid,
                Screen = screenLgWing,
                BestSeller = true
            };
            
            var hardwareiPhone12Pro = new Hardware()
            {
                Id = 4,
                ProcessorName = "A14 Bionic",
                OperationSystem = "iOS",
                GraphicsProcessor = "A14 Bionic",
                OperationMemory = 6,
                MemorySpace = 128,
                SimCardType = "Nano",
                BatteryCapacity = 2775
            };
            var cameraiPhone12Pro = new Camera()
            {
                Id = 4,
                Zoom = 10,
                FrontResulution = 12,
                MainResulution = 12,
                AdditionalResulution = 12,
                VideoRecorderResolution = "4K",
                VideoFPS = 120,
                Functions = new List<string>()
                {
                    "Video Recorder",
                    "Autofokus",
                    "Flash",
                    "HDR",
                    "Dolby Vision",
                    "Night Mode",
                    "Deep Fusion"
                }
            };
            var screeniPhone12Pro = new Screen()
            {
                Id = 4,
                Size = 6.1m,
                ColorsQuantity = 16,
                ScreenType = "Super Retina XDR",
                HorizontalResolution = 2532,
                VerticalResolution = 1170
            };
            var iPhone12Pro = new MobilePhone()
            {
                Id = 4,
                Brand = "Apple",
                Name = "12 Pro",
                Price = 5200,
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
                MainImage = "/Apple/iPhone 12 Pro/Main.png",
                FirstImage = "/Apple/iPhone 12 Pro/First.png",
                SecondImage = "/Apple/iPhone 12 Pro/Second.png",
                Hardware = hardwareiPhone12Pro,
                Camera = cameraiPhone12Pro,
                Multimedia = multimediaApple,
                Screen = screeniPhone12Pro,
                BestSeller = false
            };

            phones.Add(iPhone12);
            phones.Add(fold2);
            phones.Add(lgWing);
            phones.Add(iPhone12Pro);
            return phones;
        }



        public List<MobilePhone> GetMobiles()
        {
            return mobilePhones;
        }

    }
}
