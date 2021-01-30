using Microsoft.EntityFrameworkCore;
using OnlineShop.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.Infrastructure.Helper.DBSeed
{
    public static class DataSeed
    {
        public static void InitializeSeedInDb(this ModelBuilder builder)
        {
            var cameraiPhone12 = new Camera()
            {
                Id = 1,
                Zoom = 8,
                FrontResulution = 16,
                MainResulution = 32,
                AdditionalResulution = 16,
                VideoRecorderResolution = "4K",
                VideoFPS = 120,
                Functions = "Video Recorder;Autofokus;Flash",
                MobilePhoneId = 1
            };
            var cameraiPhone12Pro = new Camera()
            {
                Id = 2,
                Zoom = 10,
                FrontResulution = 12,
                MainResulution = 12,
                AdditionalResulution = 12,
                VideoRecorderResolution = "4K",
                VideoFPS = 120,
                MobilePhoneId = 2,
                Functions = "Video Recorder;Autofokus;Flash;HDR;Dolby Vision;Night Mode;Deep Fusion"
            };
            var cameraiPhone12Mini = new Camera()
            {
                Id = 3,
                Zoom = 10,
                FrontResulution = 12,
                MainResulution = 12,
                AdditionalResulution = 12,
                VideoRecorderResolution = "4K",
                VideoFPS = 120,
                MobilePhoneId = 3,
                Functions = "Video Recorder;Autofokus;Flash;HDR;Dolby Vision;Night Mode;Deep Fusion"
            };
            var cameraLgWing = new Camera()
            {
                Id = 4,
                Zoom = 2,
                FrontResulution = 32,
                MainResulution = 64,
                AdditionalResulution = 12,
                VideoRecorderResolution = "4K",
                VideoFPS = 120,
                MobilePhoneId = 4,
                Functions = "Video Recorder;Autofokus;Flash;Night Mode;Gimbal;AI CAM;AR Stickers"
            };
            var cameraLgVelvet = new Camera()
            {
                Id = 5,
                Zoom = 2,
                FrontResulution = 16,
                MainResulution = 48,
                AdditionalResulution = 8,
                VideoRecorderResolution = "4K",
                VideoFPS = 120,
                MobilePhoneId = 5,
                Functions = "Video Recorder;Autofokus;Flash;Night Mode;AI CAM;AR Stickers"
            };
            var cameraLgK61 = new Camera()
            {
                Id = 6,
                Zoom = 2,
                FrontResulution = 16,
                MainResulution = 48,
                AdditionalResulution = 8,
                VideoRecorderResolution = "4K",
                VideoFPS = 120,
                MobilePhoneId = 6,
                Functions = "Video Recorder;Autofokus;Flash;Night Mode;HDR"
            };
            var cameraFold2 = new Camera()
            {
                Id = 7,
                Zoom = 2,
                FrontResulution = 12,
                MainResulution = 12,
                AdditionalResulution = 12,
                VideoRecorderResolution = "4K",
                VideoFPS = 60,
                MobilePhoneId = 7,
                Functions = "Video Recorder;Autofokus;Flash"
            };
            var cameraFlip = new Camera()
            {
                Id = 8,
                Zoom = 8,
                FrontResulution = 10,
                MainResulution = 12,
                AdditionalResulution = 12,
                VideoRecorderResolution = "4K",
                VideoFPS = 60,
                MobilePhoneId = 8,
                Functions = "Video Recorder;Autofokus;Flash;HDR;Dynamic Photo"
            };
            var cameraS21 = new Camera()
            {
                Id = 9,
                Zoom = 30,
                FrontResulution = 12,
                MainResulution = 64,
                AdditionalResulution = 12,
                VideoRecorderResolution = "4K",
                VideoFPS = 120,
                MobilePhoneId = 9,
                Functions = "Video Recorder;Autofokus;Flash;HDR;Dynamic Photo"
            };
            var cameraA51 = new Camera()
            {
                Id = 10,
                Zoom = 2,
                FrontResulution = 32,
                MainResulution = 48,
                AdditionalResulution = 12,
                VideoRecorderResolution = "4K",
                VideoFPS = 30,
                MobilePhoneId = 10,
                Functions = "Video Recorder;Autofokus;Flash;HDR;Dynamic Photo"
            };
            


            var hardwareiPhone12 = new Hardware()
            {
                Id = 1,
                ProcessorName = "A14 Bionic",
                OperationSystem = "iOS",
                GraphicsProcessor = "A14 Bionic",
                OperationMemory = 4,
                MemorySpace = 64,
                SimCardType = "Nano",
                BatteryCapacity = 2500,
                MobilePhoneId = 1
            };
            var hardwareiPhone12Pro = new Hardware()
            {
                Id = 2,
                ProcessorName = "A14 Bionic",
                OperationSystem = "iOS",
                GraphicsProcessor = "A14 Bionic",
                OperationMemory = 6,
                MemorySpace = 128,
                SimCardType = "Nano",
                BatteryCapacity = 2775,
                MobilePhoneId = 2
            };
            var hardwareiPhone12Mini = new Hardware()
            {
                Id = 3,
                ProcessorName = "A14 Bionic",
                OperationSystem = "iOS",
                GraphicsProcessor = "A14 Bionic",
                OperationMemory = 4,
                MemorySpace = 64,
                SimCardType = "Nano",
                MobilePhoneId = 3,
                BatteryCapacity = 2775
            };
            var hardwareLgWing = new Hardware()
            {
                Id = 4,
                ProcessorName = "Qualcomm Snapdragon 765G",
                OperationSystem = "Android",
                GraphicsProcessor = "Adreno 620 GPU",
                OperationMemory = 8,
                MemorySpace = 128,
                SimCardType = "Nano",
                MobilePhoneId = 4,
                BatteryCapacity = 4000
            };
            var hardwareLgVelvet = new Hardware()
            {
                Id = 5,
                ProcessorName = "Qualcomm Snapdragon 765G",
                OperationSystem = "Android",
                GraphicsProcessor = "Adreno 620 GPU",
                OperationMemory = 6,
                MemorySpace = 128,
                SimCardType = "Nano",
                MobilePhoneId = 5,
                BatteryCapacity = 4300
            };
            var hardwareLgK61 = new Hardware()
            {
                Id = 6,
                ProcessorName = "MediaTek Helio P35",
                OperationSystem = "Android",
                GraphicsProcessor = "IMG GE8320 680MHz",
                OperationMemory = 4,
                MemorySpace = 128,
                SimCardType = "Nano",
                MobilePhoneId = 6,
                BatteryCapacity = 4000
            };
            var hardwareFold2 = new Hardware()
            {
                Id = 7,
                ProcessorName = "Qualcomm",
                OperationSystem = "Android",
                GraphicsProcessor = "Adreno 650",
                OperationMemory = 12,
                MemorySpace = 256,
                SimCardType = "Nano",
                MobilePhoneId = 7,
                BatteryCapacity = 4500
            };
            var hardwareFlip = new Hardware()
            {
                Id = 8,
                ProcessorName = "Snapdragon 865+",
                OperationSystem = "Android",
                GraphicsProcessor = "Adreno 650",
                OperationMemory = 8,
                MemorySpace = 256,
                SimCardType = "Nano",
                MobilePhoneId = 8,
                BatteryCapacity = 3300
            };
            var hardwareS21 = new Hardware()
            {
                Id = 9,
                ProcessorName = "Exynos",
                OperationSystem = "Android",
                GraphicsProcessor = "Mali G78 MP14",
                OperationMemory = 8,
                MemorySpace = 256,
                SimCardType = "Nano",
                MobilePhoneId = 9,
                BatteryCapacity = 4000
            };
            var hardwareA51 = new Hardware()
            {
                Id = 10,
                ProcessorName = "Exynos 9611",
                OperationSystem = "Android",
                GraphicsProcessor = "Mali G72 MP3",
                OperationMemory = 4,
                MemorySpace = 128,
                SimCardType = "Nano",
                MobilePhoneId = 10,
                BatteryCapacity = 4000
            };




            var screeniPhone12 = new Screen()
            {
                Id = 1,
                Size = 6.1m,
                ColorsQuantity = 16,
                ScreenType = "OLED Super Retina XDR",
                HorizontalResolution = 2532,
                VerticalResolution = 1170,
                MobilePhoneId = 1
            };
            var screeniPhone12Pro = new Screen()
            {
                Id = 2,
                Size = 6.1m,
                ColorsQuantity = 16,
                ScreenType = "Super Retina XDR",
                HorizontalResolution = 2532,
                VerticalResolution = 1170,
                MobilePhoneId = 2
            };
            var screeniPhone12Mini = new Screen()
            {
                Id = 3,
                Size = 5.4m,
                ColorsQuantity = 16,
                ScreenType = "Super Retina XDR",
                HorizontalResolution = 2340,
                MobilePhoneId = 3,
                VerticalResolution = 1080
            };
            var screenLgWing = new Screen()
            {
                Id = 4,
                Size = 6.8m,
                ColorsQuantity = 16,
                ScreenType = "FHD+ P-OLED FullVision",
                HorizontalResolution = 2460,
                MobilePhoneId = 4,
                VerticalResolution = 1080
            };
            var screenLgVelvet = new Screen()
            {
                Id = 5,
                Size = 6.8m,
                ColorsQuantity = 16,
                ScreenType = "FHD+ OLED FullVision",
                HorizontalResolution = 2460,
                MobilePhoneId = 5,
                VerticalResolution = 1080
            };
            var screenLgK61 = new Screen()
            {
                Id = 6,
                Size = 6.5m,
                ColorsQuantity = 16,
                ScreenType = "FHD+ IPS",
                HorizontalResolution = 2340,
                MobilePhoneId = 6,
                VerticalResolution = 1080
            };
            var screenFold2 = new Screen()
            {
                Id = 7,
                Size = 6.1m,
                ColorsQuantity = 16,
                ScreenType = "Dynamic AMOLED 2X",
                HorizontalResolution = 2208,
                MobilePhoneId = 7,
                VerticalResolution = 1768
            };
            var screenFlip = new Screen()
            {
                Id = 8,
                Size = 6.7m,
                ColorsQuantity = 16,
                ScreenType = "Dynamic AMOLED & Super AMOLED",
                HorizontalResolution = 2636,
                MobilePhoneId = 8,
                VerticalResolution = 1080
            };
            var screenS21 = new Screen()
            {
                Id = 9,
                Size = 6.2m,
                ColorsQuantity = 16,
                ScreenType = "Dynamic AMOLED 2X, 120Hz, HDR10+",
                HorizontalResolution = 2400,
                MobilePhoneId = 9,
                VerticalResolution = 1080
            };
            var screenA51 = new Screen()
            {
                Id = 10,
                Size = 6.5m,
                ColorsQuantity = 16,
                ScreenType = "FHD+ Super AMOLED",
                HorizontalResolution = 2400,
                MobilePhoneId = 10,
                VerticalResolution = 1080
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
                Id = 2,
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
                SecondImage = "/Apple/iPhone 12/Second.png",
                Hardware = hardwareiPhone12,
                Camera = cameraiPhone12,
                Multimedia = multimediaApple,
                Screen = screeniPhone12,
                BestSeller = true
            };
            var iPhone12Pro = new MobilePhone()
            {
                Id = 2,
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
            var iPhone12Mini = new MobilePhone()
            {
                Id = 3,
                Brand = "Apple",
                Name = "12 Mini",
                Price = 3600,
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
                MainImage = "/Apple/iPhone 12 Mini/Main.png",
                FirstImage = "/Apple/iPhone 12 Mini/First.png",
                SecondImage = "/Apple/iPhone 12 Mini/Second.png",
                Hardware = hardwareiPhone12Mini,
                Camera = cameraiPhone12Mini,
                Multimedia = multimediaApple,
                Screen = screeniPhone12Mini,
                BestSeller = false
            };
            var lgWing = new MobilePhone()
            {
                Id = 4,
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
            var lgVelvet = new MobilePhone()
            {
                Id = 5,
                Brand = "LG",
                Name = "Velvet",
                Price = 2300,
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
                MainImage = "/LG/Velvet/Main.png",
                FirstImage = "/LG/Velvet/First.png",
                SecondImage = "/LG/Velvet/Second.png",
                Hardware = hardwareLgVelvet,
                Camera = cameraLgVelvet,
                Multimedia = multimediaAndroid,
                Screen = screenLgVelvet,
                BestSeller = false
            };
            var lgK61 = new MobilePhone()
            {
                Id = 6,
                Brand = "LG",
                Name = "K61",
                Price = 1000,
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
                MainImage = "/LG/K61/Main.png",
                FirstImage = "/LG/K61/First.png",
                SecondImage = "/LG/K61/Second.png",
                Hardware = hardwareLgK61,
                Camera = cameraLgK61,
                Multimedia = multimediaAndroid,
                Screen = screenLgK61,
                BestSeller = false
            };
            var fold2 = new MobilePhone()
            {
                Id = 7,
                Brand = "Samsung",
                Name = "Galaxy Z Fold2 5G",
                Price = 8800,
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
            var flip = new MobilePhone()
            {
                Id = 8,
                Brand = "Samsung",
                Name = "Galaxy Z Flip 5G",
                Price = 6800,
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
                MainImage = "/Samsung/Galaxy Z Flip/Main.png",
                FirstImage = "/Samsung/Galaxy Z Flip/First.png",
                SecondImage = "/Samsung/Galaxy Z Flip/Second.png",
                Hardware = hardwareFlip,
                Camera = cameraFlip,
                Multimedia = multimediaAndroid,
                Screen = screenFlip,
                BestSeller = false
            };
            var s21 = new MobilePhone()
            {
                Id = 9,
                Brand = "Samsung",
                Name = "Galaxy S21",
                Price = 3900,
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
                MainImage = "/Samsung/Galaxy S21/Main.png",
                FirstImage = "/Samsung/Galaxy S21/First.png",
                SecondImage = "/Samsung/Galaxy S21/Second.png",
                Hardware = hardwareS21,
                Camera = cameraS21,
                Multimedia = multimediaAndroid,
                Screen = screenS21,
                BestSeller = false
            };
            var a51 = new MobilePhone()
            {
                Id = 10,
                Brand = "Samsung",
                Name = "Galaxy A51",
                Price = 1700,
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
                MainImage = "/Samsung/Galaxy A51/Main.png",
                FirstImage = "/Samsung/Galaxy A51/First.png",
                SecondImage = "/Samsung/Galaxy A51/Second.png",
                Hardware = hardwareA51,
                Camera = cameraA51,
                Multimedia = multimediaAndroid,
                Screen = screenA51,
                BestSeller = false
            };

            var hardwareMateXS = new Hardware()
            {
                Id = 11,
                ProcessorName = "Kirin 990 5G",
                OperationSystem = "Android",
                GraphicsProcessor = "Kirin 990 5G",
                OperationMemory = 8,
                MemorySpace = 512,
                SimCardType = "Nano",
                MobilePhoneId = 11,
                BatteryCapacity = 4500
            };
            var cameraMateXS = new Camera()
            {
                Id = 11,
                Zoom = 30,
                FrontResulution = 40,
                MainResulution = 40,
                AdditionalResulution = 8,
                VideoRecorderResolution = "4K",
                VideoFPS = 120,
                MobilePhoneId = 11,
                Functions = "Video Recorder;Autofokus; Flash;HDR;Deep Photo"
            };
            var screenMateXS = new Screen()
            {
                Id = 11,
                Size = 6.6m,
                ColorsQuantity = 16,
                ScreenType = "OLED",
                HorizontalResolution = 2480,
                MobilePhoneId = 11,
                VerticalResolution = 1148
            };
            var mateXS = new MobilePhone()
            {
                Id = 11,
                Brand = "Huawei",
                Name = "Mate XS",
                Price = 10000,
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
                MainImage = "/Huawei/Mate XS/Main.png",
                FirstImage = "/Huawei/Mate XS/First.png",
                SecondImage = "/Huawei/Mate XS/Second.png",
                Hardware = hardwareMateXS,
                Camera = cameraMateXS,
                Multimedia = multimediaAndroid,
                Screen = screenMateXS,
                BestSeller = false
            };

            var hardwareMate40Pro = new Hardware()
            {
                Id = 12,
                ProcessorName = "Kirin 9000",
                OperationSystem = "Android",
                GraphicsProcessor = "Kirin 9000",
                OperationMemory = 8,
                MemorySpace = 256,
                SimCardType = "Nano",
                MobilePhoneId = 12,
                BatteryCapacity = 4500
            };
            var cameraMate40Pro = new Camera()
            {
                Id = 12,
                Zoom = 10,
                FrontResulution = 13,
                MainResulution = 50,
                AdditionalResulution = 20,
                VideoRecorderResolution = "4K",
                VideoFPS = 120,
                MobilePhoneId = 12,
                Functions = "Video Recorder;Autofokus;Flash;HDR:Deep Photo 3D"
            };
            var screenMate40Pro = new Screen()
            {
                Id = 12,
                Size = 6.8m,
                ColorsQuantity = 16,
                ScreenType = "FHD+ OLED",
                HorizontalResolution = 2772,
                MobilePhoneId = 12,
                VerticalResolution = 1344
            };
            var mate40Pro = new MobilePhone()
            {
                Id = 12,
                Brand = "Huawei",
                Name = "Mate 40 Pro",
                Price = 5400,
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
                MainImage = "/Huawei/Mate 40 Pro/Main.png",
                FirstImage = "/Huawei/Mate 40 Pro/First.png",
                SecondImage = "/Huawei/Mate 40 Pro/Second.png",
                Hardware = hardwareMate40Pro,
                Camera = cameraMate40Pro,
                Multimedia = multimediaAndroid,
                Screen = screenMate40Pro,
                BestSeller = false
            };

            var hardwareSonyL4 = new Hardware()
            {
                Id = 13,
                ProcessorName = "MediaTek MT6762",
                OperationSystem = "Android",
                GraphicsProcessor = "IMG GE8320",
                OperationMemory = 3,
                MemorySpace = 64,
                SimCardType = "Nano",
                MobilePhoneId = 13,
                BatteryCapacity = 3580
            };
            var cameraSonyL4 = new Camera()
            {
                Id = 13,
                Zoom = 2,
                FrontResulution = 8,
                MainResulution = 13,
                AdditionalResulution = 5,
                VideoRecorderResolution = "HD",
                VideoFPS = 120,
                MobilePhoneId = 13,
                Functions = "Video Recorder;Autofokus;Flash"
            };
            var screenSonyL4 = new Screen()
            {
                Id = 13,
                Size = 6.2m,
                ColorsQuantity = 16,
                ScreenType = "TFT LCD",
                HorizontalResolution = 1680,
                MobilePhoneId = 13,
                VerticalResolution = 720
            };
            var sonyXperiaL4 = new MobilePhone()
            {
                Id = 13,
                Brand = "Sony",
                Name = "Xperia L4",
                Price = 1000,
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
                MainImage = "/Sony/Xperia L4/Main.png",
                FirstImage = "/Sony/Xperia L4/First.png",
                SecondImage = "/Sony/Xperia L4/Second.png",
                Hardware = hardwareSonyL4,
                Camera = cameraSonyL4,
                Multimedia = multimediaAndroid,
                Screen = screenSonyL4,
                BestSeller = false
            };

            var hardwareSony10 = new Hardware()
            {
                Id = 14,
                ProcessorName = "Qualcomm Snapdragon 665",
                OperationSystem = "Android",
                GraphicsProcessor = "Adreno 610",
                OperationMemory = 4,
                MemorySpace = 128,
                SimCardType = "Nano",
                MobilePhoneId = 14,
                BatteryCapacity = 3600
            };
            var cameraSony10 = new Camera()
            {
                Id = 14,
                Zoom = 4,
                FrontResulution = 8,
                MainResulution = 12,
                AdditionalResulution = 8,
                VideoRecorderResolution = "HD",
                VideoFPS = 120,
                MobilePhoneId = 14,
                Functions = "Video Recorder;Autofokus;Flash"
            };
            var screenSony10 = new Screen()
            {
                Id = 14,
                Size = 6.0m,
                ColorsQuantity = 16,
                ScreenType = "OLED",
                HorizontalResolution = 2520,
                MobilePhoneId = 14,
                VerticalResolution = 1080
            };
            var sonyXperia10 = new MobilePhone()
            {
                Id = 14,
                Brand = "Sony",
                Name = "Xperia 10",
                Price = 1800,
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
                MainImage = "/Sony/Xperia 10/Main.png",
                FirstImage = "/Sony/Xperia 10/First.png",
                SecondImage = "/Sony/Xperia 10/Second.png",
                Hardware = hardwareSony10,
                Camera = cameraSony10,
                Multimedia = multimediaAndroid,
                Screen = screenSony10,
                BestSeller = false
            };

            var hardwareXiaomi10Lite = new Hardware()
            {
                Id = 15,
                ProcessorName = "Qualcomm Snapdragon 750G",
                OperationSystem = "Android",
                GraphicsProcessor = "Adreno™ GPU 619",
                OperationMemory = 6,
                MemorySpace = 64,
                SimCardType = "Nano",
                MobilePhoneId = 15,
                BatteryCapacity = 4820
            };
            var cameraXiaomi10Lite = new Camera()
            {
                Id = 15,
                Zoom = 10,
                FrontResulution = 16,
                MainResulution = 64,
                AdditionalResulution = 8,
                VideoRecorderResolution = "4K",
                VideoFPS = 30,
                MobilePhoneId = 15,
                Functions = "Video Recorder;Autofokus;Flash;Ultra-wide;Deep view"
            };
            var screenXiaomi10Lite = new Screen()
            {
                Id = 15,
                Size = 6.7m,
                ColorsQuantity = 16,
                ScreenType = "FHD+ DotDisplay 120 Hz IPS",
                HorizontalResolution = 2400,
                MobilePhoneId = 15,
                VerticalResolution = 1080
            };
            var xiaomi10Lite = new MobilePhone()
            {
                Id = 15,
                Brand = "Xiaomi",
                Name = "10T Lite",
                Price = 1500,
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
                MainImage = "/Xiaomi/Mi 10T Lite/Main.png",
                FirstImage = "/Xiaomi/Mi 10T Lite/First.png",
                SecondImage = "/Xiaomi/Mi 10T Lite/Second.png",
                Hardware = hardwareXiaomi10Lite,
                Camera = cameraXiaomi10Lite,
                Multimedia = multimediaAndroid,
                Screen = screenXiaomi10Lite,
                BestSeller = false
            };

            var hardwareXiaomi10Pro = new Hardware()
            {
                Id = 16,
                ProcessorName = "Qualcomm Snapdragon 865",
                OperationSystem = "Android",
                GraphicsProcessor = "Adreno 650",
                OperationMemory = 8,
                MemorySpace = 256,
                SimCardType = "Nano",
                MobilePhoneId = 16,
                BatteryCapacity = 5000
            };
            var cameraXiaomi10Pro = new Camera()
            {
                Id = 16,
                Zoom = 10,
                FrontResulution = 20,
                MainResulution = 108,
                AdditionalResulution = 13,
                VideoRecorderResolution = "4K",
                VideoFPS = 120,
                MobilePhoneId = 16,
                Functions = "Video Recorder;Autofokus;Flash;Ultra-wide;Deep view;HMX"
            };
            var screenXiaomi10Pro = new Screen()
            {
                Id = 16,
                Size = 6.7m,
                ColorsQuantity = 16,
                ScreenType = "FHD+ DotDisplay 144Hz IPS",
                HorizontalResolution = 2440,
                MobilePhoneId = 16,
                VerticalResolution = 1080
            };
            var xiaomi10Pro = new MobilePhone()
            {
                Id = 16,
                Brand = "Xiaomi",
                Name = "10T Pro",
                Price = 2600,
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
                MainImage = "/Xiaomi/Mi 10T Pro/Main.png",
                FirstImage = "/Xiaomi/Mi 10T Pro/First.png",
                SecondImage = "/Xiaomi/Mi 10T Pro/Second.png",
                Hardware = hardwareXiaomi10Pro,
                Camera = cameraXiaomi10Pro,
                Multimedia = multimediaAndroid,
                Screen = screenXiaomi10Pro,
                BestSeller = false
            };

            var hardwareXiaomiRedmi = new Hardware()
            {
                Id = 17,
                ProcessorName = "MediaTek Helio G85",
                OperationSystem = "Android",
                GraphicsProcessor = "ARM G52 MC2",
                OperationMemory = 4,
                MemorySpace = 128,
                SimCardType = "Nano",
                MobilePhoneId = 17,
                BatteryCapacity = 5020
            };
            var cameraXiaomiRedmi = new Camera()
            {
                Id = 17,
                Zoom = 2,
                FrontResulution = 13,
                MainResulution = 48,
                AdditionalResulution = 8,
                VideoRecorderResolution = "2K",
                VideoFPS = 60,
                MobilePhoneId = 17,
                Functions = "Video Recorder;Autofokus;Flash"
            };
            var screenXiaomiRedmi = new Screen()
            {
                Id = 17,
                Size = 6.7m,
                ColorsQuantity = 16,
                ScreenType = "FHD+ AMOLED",
                HorizontalResolution = 2340,
                MobilePhoneId = 17,
                VerticalResolution = 1080
            };
            var xiaomiRedmi = new MobilePhone()
            {
                Id = 17,
                Brand = "Xiaomi",
                Name = "Redmi Note 9",
                Price = 700,
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
                MainImage = "/Xiaomi/Redmi Note 9/Main.png",
                FirstImage = "/Xiaomi/Redmi Note 9/First.png",
                SecondImage = "/Xiaomi/Redmi Note 9/Second.png",
                Hardware = hardwareXiaomiRedmi,
                Camera = cameraXiaomiRedmi,
                Multimedia = multimediaAndroid,
                Screen = screenXiaomiRedmi,
                BestSeller = false
            };

            var hardwareRazr = new Hardware()
            {
                Id = 18,
                ProcessorName = "Qualcomm Snapdragon 765",
                OperationSystem = "Android",
                GraphicsProcessor = "Adreno 620",
                OperationMemory = 8,
                MemorySpace = 256,
                SimCardType = "Nano",
                MobilePhoneId = 18,
                BatteryCapacity = 2800
            };
            var cameraRazr = new Camera()
            {
                Id = 18,
                Zoom = 8,
                FrontResulution = 20,
                MainResulution = 48,
                AdditionalResulution = 0,
                VideoRecorderResolution = "4K",
                VideoFPS = 30,
                MobilePhoneId = 18,
                Functions = "Video Recorder;Autofokus;Flash;Portrait;Live filtr;In motion;Night mode"
            };
            var screenRazr = new Screen()
            {
                Id = 18,
                Size = 6.2m,
                ColorsQuantity = 16,
                ScreenType = "pOLED",
                HorizontalResolution = 2142,
                MobilePhoneId = 18,
                VerticalResolution = 876
            };
            var razr = new MobilePhone()
            {
                Id = 18,
                Brand = "Motorola ",
                Name = "Razr",
                Price = 6500,
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
                MainImage = "/Motorola/Razr/Main.png",
                FirstImage = "/Motorola/Razr/First.png",
                SecondImage = "/Motorola/Razr/Second.png",
                Hardware = hardwareRazr,
                Camera = cameraRazr,
                Multimedia = multimediaAndroid,
                Screen = screenRazr,
                BestSeller = false
            };

            var hardwareEdge = new Hardware()
            {
                Id = 19,
                ProcessorName = "Qualcomm Snapdragon 765",
                OperationSystem = "Android",
                GraphicsProcessor = "Adreno 620",
                OperationMemory = 6,
                MemorySpace = 128,
                SimCardType = "Nano",
                MobilePhoneId = 19,
                BatteryCapacity = 5000
            };
            var cameraEdge = new Camera()
            {
                Id = 19,
                Zoom = 4,
                FrontResulution = 25,
                MainResulution = 64,
                AdditionalResulution = 16,
                VideoRecorderResolution = "4K",
                VideoFPS = 30,
                MobilePhoneId = 19,
                Functions = "Video Recorder;Autofokus:Flash;Portrait;In motion;Night mode"
            };
            var screenEdge = new Screen()
            {
                Id = 19,
                Size = 6.7m,
                ColorsQuantity = 16,
                ScreenType = "FHD+ OLED",
                HorizontalResolution = 2340,
                MobilePhoneId = 19,
                VerticalResolution = 1080
            };
            var edge = new MobilePhone()
            {
                Id = 19,
                Brand = "Motorola ",
                Name = "Edge",
                Price = 2700,
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
                MainImage = "/Motorola/Edge/Main.png",
                FirstImage = "/Motorola/Edge/First.png",
                SecondImage = "/Motorola/Edge/Second.png",
                Hardware = hardwareEdge,
                Camera = cameraEdge,
                Multimedia = multimediaAndroid,
                Screen = screenEdge,
                BestSeller = false
            };

            var hardwareMoto = new Hardware()
            {
                Id = 20,
                ProcessorName = "Qualcomm Snapdragon 765",
                OperationSystem = "Android",
                GraphicsProcessor = "Adreno 620",
                OperationMemory = 6,
                MemorySpace = 128,
                SimCardType = "Nano",
                MobilePhoneId = 20,
                BatteryCapacity = 5000
            };
            var cameraMoto = new Camera()
            {
                Id = 20,
                Zoom = 2,
                FrontResulution = 16,
                MainResulution = 48,
                AdditionalResulution = 8,
                VideoRecorderResolution = "HD",
                VideoFPS = 60,
                MobilePhoneId = 20,
                Functions = "Video Recorder;Autofokus;Flash;Portrait;Night mode"
            };
            var screenMoto = new Screen()
            {
                Id = 20,
                Size = 6.7m,
                ColorsQuantity = 16,
                ScreenType = "FHD+ IPS CinemaVision",
                HorizontalResolution = 2520,
                MobilePhoneId = 20,
                VerticalResolution = 1080
            };
            var moto = new MobilePhone()
            {
                Id = 20,
                Brand = "Motorola ",
                Name = "Moto G",
                Price = 1700,
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
                MainImage = "/Motorola/Moto G/Main.png",
                FirstImage = "/Motorola/Moto G/First.png",
                SecondImage = "/Motorola/Moto G/Second.png",
                Hardware = hardwareMoto,
                Camera = cameraMoto,
                Multimedia = multimediaAndroid,
                Screen = screenMoto,
                BestSeller = false
            };

            var hardwareNokia7 = new Hardware()
            {
                Id = 21,
                ProcessorName = "Qualcomm Snapdragon 660",
                OperationSystem = "Android",
                GraphicsProcessor = "Adreno 512",
                OperationMemory = 4,
                MemorySpace = 64,
                SimCardType = "Nano",
                MobilePhoneId = 21,
                BatteryCapacity = 3500
            };
            var cameraNokia7 = new Camera()
            {
                Id = 21,
                Zoom = 2,
                FrontResulution = 20,
                MainResulution = 48,
                AdditionalResulution = 8,
                VideoRecorderResolution = "HD",
                VideoFPS = 60,
                MobilePhoneId = 21,
                Functions = "Video Recorder;Autofokus;Flash"
            };
            var screenNokia7 = new Screen()
            {
                Id = 21,
                Size = 6.3m,
                ColorsQuantity = 16,
                ScreenType = "IPS TFT",
                HorizontalResolution = 2340,
                MobilePhoneId = 21,
                VerticalResolution = 1080
            };
            var nokia7 = new MobilePhone()
            {
                Id = 21,
                Brand = "Nokia",
                Name = "7.2",
                Price = 1000,
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
                MainImage = "/Nokia/7.2/Main.png",
                FirstImage = "/Nokia/7.2/First.png",
                SecondImage = "/Nokia/7.2/Second.png",
                Hardware = hardwareNokia7,
                Camera = cameraNokia7,
                Multimedia = multimediaAndroid,
                Screen = screenNokia7,
                BestSeller = false
            };

            var hardwareNokia8 = new Hardware()
            {
                Id = 22,
                ProcessorName = "Qualcomm Snapdragon 765G",
                OperationSystem = "Android",
                GraphicsProcessor = "Adreno 620",
                OperationMemory = 8,
                MemorySpace = 128,
                SimCardType = "Nano",
                MobilePhoneId = 22,
                BatteryCapacity = 4500
            };
            var cameraNokia8 = new Camera()
            {
                Id = 22,
                Zoom = 8,
                FrontResulution = 24,
                MainResulution = 64,
                AdditionalResulution = 12,
                VideoRecorderResolution = "4K",
                VideoFPS = 60,
                MobilePhoneId = 22,
                Functions = "Video Recorder;Autofokus;Flash;Night mode;Deep photo;Live colors"
            };
            var screenNokia8 = new Screen()
            {
                Id = 22,
                Size = 6.8m,
                ColorsQuantity = 16,
                ScreenType = "FHD+ LCD with PureDisplay",
                HorizontalResolution = 2400,
                MobilePhoneId = 22,
                VerticalResolution = 1080
            };
            var nokia8 = new MobilePhone()
            {
                Id = 22,
                Brand = "Nokia",
                Name = "8.3",
                Price = 2700,
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
                MainImage = "/Nokia/7.2/Main.png",
                FirstImage = "/Nokia/7.2/First.png",
                SecondImage = "/Nokia/7.2/Second.png",
                Hardware = hardwareNokia8,
                Camera = cameraNokia8,
                Multimedia = multimediaAndroid,
                Screen = screenNokia8,
                BestSeller = false
            };

            var hardwareIPhone11 = new Hardware()
            {
                Id = 23,
                ProcessorName = "A13 Bionic",
                OperationSystem = "Android",
                GraphicsProcessor = "A13 Bionic",
                OperationMemory = 6,
                MemorySpace = 64,
                SimCardType = "Nano",
                MobilePhoneId = 23,
                BatteryCapacity = 3110
            };
            var cameraIPhone11 = new Camera()
            {
                Id = 23,
                Zoom = 4,
                FrontResulution = 12,
                MainResulution = 12,
                AdditionalResulution = 12,
                VideoRecorderResolution = "HD",
                VideoFPS = 60,
                MobilePhoneId = 23,
                Functions = "Video Recorder;Autofokus;Flash;Night mode;Deep photo;Portrait"
            };
            var screenIPhone11 = new Screen()
            {
                Id = 23,
                Size = 6.1m,
                ColorsQuantity = 16,
                ScreenType = "Liquid Retina HD",
                HorizontalResolution = 1792,
                MobilePhoneId = 23,
                VerticalResolution = 828
            };
            var iPhone11 = new MobilePhone()
            {
                Id = 23,
                Brand = "Apple",
                Name = "iPhone 11",
                Price = 3100,
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
                MainImage = "/Apple/iPhone 11/Main.png",
                FirstImage = "/Apple/iPhone 11/First.png",
                SecondImage = "/Apple/iPhone 11/Second.png",
                Hardware = hardwareIPhone11,
                Camera = cameraIPhone11,
                Multimedia = multimediaAndroid,
                Screen = screenIPhone11,
                BestSeller = false
            };

            var hardwareIPhoneSE = new Hardware()
            {
                Id = 24,
                ProcessorName = "A13 Bionic",
                OperationSystem = "Android",
                GraphicsProcessor = "A13 Bionic",
                OperationMemory = 4,
                MemorySpace = 64,
                SimCardType = "Nano",
                MobilePhoneId = 24,
                BatteryCapacity = 1821
            };
            var cameraIPhoneSE = new Camera()
            {
                Id = 24,
                Zoom = 2,
                FrontResulution = 7,
                MainResulution = 12,
                AdditionalResulution = 5,
                VideoRecorderResolution = "HD",
                VideoFPS = 30,
                MobilePhoneId = 24,
                Functions = "Video Recorder;Autofokus;Flash;Night mode",
            };
            var screenIPhoneSE = new Screen()
            {
                Id = 24,
                Size = 4.7m,
                ColorsQuantity = 16,
                ScreenType = "Retina HD IPS",
                HorizontalResolution = 1334,
                MobilePhoneId = 24,
                VerticalResolution = 750
            };
            var iPhoneSE = new MobilePhone()
            {
                Id = 24,
                Brand = "Apple",
                Name = "iPhone SE",
                Price = 2100,
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
                MainImage = "/Apple/iPhone SE/Main.png",
                FirstImage = "/Apple/iPhone SE/First.png",
                SecondImage = "/Apple/iPhone SE/Second.png",
                Hardware = hardwareIPhoneSE,
                Camera = cameraIPhoneSE,
                Multimedia = multimediaAndroid,
                Screen = screenIPhoneSE,
                BestSeller = false
            };

            var hardwareReno4Pro = new Hardware()
            {
                Id = 25,
                ProcessorName = "Qualcomm Snapdragon 765 5G",
                OperationSystem = "Android",
                GraphicsProcessor = "Adreno 620",
                OperationMemory = 12,
                MemorySpace = 256,
                SimCardType = "Nano",
                MobilePhoneId = 25,
                BatteryCapacity = 4000
            };
            var cameraReno4Pro = new Camera()
            {
                Id = 25,
                Zoom = 10,
                FrontResulution = 32,
                MainResulution = 48,
                AdditionalResulution = 12,
                VideoRecorderResolution = "4K",
                VideoFPS = 30,
                MobilePhoneId = 25,
                Functions = "Video Recorder;Autofokus;Flash;Night mode",
            };
            var screenReno4Pro = new Screen()
            {
                Id = 25,
                Size = 6.5m,
                ColorsQuantity = 16,
                ScreenType = "AMOLED HDR10+",
                HorizontalResolution = 2400,
                MobilePhoneId = 25,
                VerticalResolution = 1080
            };
            var reno4Pro = new MobilePhone()
            {
                Id = 25,
                Brand = "Oppo",
                Name = "Reno4 Pro",
                Price = 3300,
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
                MainImage = "/Oppo/Reno4 Pro/Main.png",
                FirstImage = "/Oppo/Reno4 Pro/First.png",
                SecondImage = "/Oppo/Reno4 Pro/Second.png",
                Hardware = hardwareReno4Pro,
                Camera = cameraReno4Pro,
                Multimedia = multimediaAndroid,
                Screen = screenReno4Pro,
                BestSeller = false
            };

            var hardwareReno4Lite = new Hardware()
            {
                Id = 26,
                ProcessorName = "MediaTek Helio P95",
                OperationSystem = "Android",
                GraphicsProcessor = "PowerVR GM9446",
                OperationMemory = 8,
                MemorySpace = 128,
                SimCardType = "Nano",
                MobilePhoneId = 26,
                BatteryCapacity = 4000
            };
            var cameraReno4Lite = new Camera()
            {
                Id = 26,
                Zoom = 4,
                FrontResulution = 16,
                MainResulution = 48,
                AdditionalResulution = 8,
                VideoRecorderResolution = "HD",
                VideoFPS = 60,
                MobilePhoneId = 26,
                Functions = "Video Recorder;Autofokus;Flash;Night mode"
            };
            var screenReno4Lite = new Screen()
            {
                Id = 26,
                Size = 6.4m,
                ColorsQuantity = 16,
                ScreenType = "AMOLED",
                HorizontalResolution = 2400,
                MobilePhoneId = 26,
                VerticalResolution = 1080
            };
            var reno4Lite = new MobilePhone()
            {
                Id = 26,
                Brand = "Oppo",
                Name = "Reno4 Lite",
                Price = 1600,
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
                MainImage = "/OPPO/Reno4 Lite/Main.png",
                FirstImage = "/OPPO/Reno4 Lite/First.png",
                SecondImage = "/OPPO/Reno4 Lite/Second.png",
                Hardware = hardwareReno4Lite,
                Camera = cameraReno4Lite,
                Multimedia = multimediaAndroid,
                Screen = screenReno4Lite,
                BestSeller = false
            };

            var hardwareOppoA53 = new Hardware()
            {
                Id = 27,
                ProcessorName = "Qualcomm Snapdragon 460",
                OperationSystem = "Android",
                GraphicsProcessor = "Adreno 610",
                OperationMemory = 4,
                MemorySpace = 128,
                SimCardType = "Nano",
                MobilePhoneId = 27,
                BatteryCapacity = 5000
            };
            var cameraOppoA53 = new Camera()
            {
                Id = 27,
                Zoom = 2,
                FrontResulution = 8,
                MainResulution = 13,
                AdditionalResulution = 2,
                VideoRecorderResolution = "HD",
                VideoFPS = 30,
                MobilePhoneId = 27,
                Functions = "Video Recorder;Autofokus;Flash"
            };
            var screenOppoA53 = new Screen()
            {
                Id = 27,
                Size = 6.5m,
                ColorsQuantity = 16,
                ScreenType = "LCD",
                HorizontalResolution = 1600,
                MobilePhoneId = 27,
                VerticalResolution = 720
            };
            var oppoA53 = new MobilePhone()
            {
                Id = 27,
                Brand = "Oppo",
                Name = "A53",
                Price = 1000,
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
                MainImage = "/OPPO/A53/Main.png",
                FirstImage = "/OPPO/A53/First.png",
                SecondImage = "/OPPO/A53/Second.png",
                Hardware = hardwareOppoA53,
                Camera = cameraOppoA53,
                Multimedia = multimediaAndroid,
                Screen = screenOppoA53,
                BestSeller = false
            };

            var hardwareXcover = new Hardware()
            {
                Id = 28,
                ProcessorName = "Exynos",
                OperationSystem = "Android",
                GraphicsProcessor = "Mali-G71 MP2",
                OperationMemory = 3,
                MemorySpace = 32,
                SimCardType = "Nano",
                MobilePhoneId = 28,
                BatteryCapacity = 2800
            };
            var cameraXcover = new Camera()
            {
                Id = 28,
                Zoom = 2,
                FrontResulution = 5,
                MainResulution = 16,
                AdditionalResulution = 0,
                VideoRecorderResolution = "HD",
                VideoFPS = 30,
                MobilePhoneId = 28,
                Functions = "Video Recorder;Autofokus;Flash"
            };
            var screenXcover = new Screen()
            {
                Id = 28,
                Size = 5.0m,
                ColorsQuantity = 16,
                ScreenType = "PLS TFT LCD",
                HorizontalResolution = 1280,
                MobilePhoneId = 28,
                VerticalResolution = 720
            };
            var samsungXcover = new MobilePhone()
            {
                Id = 28,
                Brand = "Samsung",
                Name = "Galaxy Xcover 4",
                Price = 1000,
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
                MainImage = "/Samsung/Galaxy Xcover 4/Main.png",
                FirstImage = "/Samsung/Galaxy Xcover 4/First.png",
                SecondImage = "/Samsung/Galaxy Xcover 4/Second.png",
                Hardware = hardwareXcover,
                Camera = cameraXcover,
                Multimedia = multimediaAndroid,
                Screen = screenXcover,
                BestSeller = false
            };

            var hardwareA71 = new Hardware()
            {
                Id = 29,
                ProcessorName = "Qualcomm Snapdragon 730",
                OperationSystem = "Android",
                GraphicsProcessor = "Adreno 618",
                OperationMemory = 6,
                MemorySpace = 128,
                SimCardType = "Nano",
                MobilePhoneId = 29,
                BatteryCapacity = 4500
            };
            var cameraA71 = new Camera()
            {
                Id = 29,
                Zoom = 4,
                FrontResulution = 32,
                MainResulution = 64,
                AdditionalResulution = 12,
                VideoRecorderResolution = "4K",
                VideoFPS = 30,
                MobilePhoneId = 29,
                Functions = "Video Recorder;Autofokus;Flash"
            };
            var screenA71 = new Screen()
            {
                Id = 29,
                Size = 6.7m,
                ColorsQuantity = 16,
                ScreenType = "FHD+ Super AMOLED",
                HorizontalResolution = 2400,
                MobilePhoneId = 29,
                VerticalResolution = 1080
            };
            var a71 = new MobilePhone()
            {
                Id = 29,
                Brand = "Samsung",
                Name = "Galaxy A71",
                Price = 1900,
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
                MainImage = "/Samsung/Galaxy A71/Main.png",
                FirstImage = "/Samsung/Galaxy A71/First.png",
                SecondImage = "/Samsung/Galaxy A71/Second.png",
                Hardware = hardwareA71,
                Camera = cameraA71,
                Multimedia = multimediaAndroid,
                Screen = screenA71,
                BestSeller = false
            };

            var hardwareK52 = new Hardware()
            {
                Id = 30,
                ProcessorName = "Helio P35 MT6765",
                OperationSystem = "Android",
                GraphicsProcessor = "IMG GE8320 680MHz",
                OperationMemory = 4,
                MemorySpace = 64,
                SimCardType = "Nano",
                MobilePhoneId = 30,
                BatteryCapacity = 4000
            };
            var cameraK52 = new Camera()
            {
                Id = 30,
                Zoom = 2,
                FrontResulution = 13,
                MainResulution = 48,
                AdditionalResulution = 5,
                VideoRecorderResolution = "HD",
                VideoFPS = 30,
                MobilePhoneId = 30,
                Functions = "Video Recorder;Autofokus;Flash;Google Lens"
            };
            var screenK52 = new Screen()
            {
                Id = 30,
                Size = 6.6m,
                ColorsQuantity = 16,
                ScreenType = "HD+, ISP-LCD",
                HorizontalResolution = 1600,
                MobilePhoneId = 30,
                VerticalResolution = 720
            };
            var k52 = new MobilePhone()
            {
                Id = 30,
                Brand = "LG",
                Name = "K52",
                Price = 1000,
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
                MainImage = "/LG/K52/Main.png",
                FirstImage = "/LG/K52/First.png",
                SecondImage = "/Lg/K52/Second.png",
                Hardware = hardwareK52,
                Camera = cameraK52,
                Multimedia = multimediaAndroid,
                Screen = screenK52,
                BestSeller = false
            };
        }
    }
}
