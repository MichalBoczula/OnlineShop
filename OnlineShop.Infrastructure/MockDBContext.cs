﻿using OnlineShop.Domain.Model;
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
            var hardwareiPhone12Pro = new Hardware()
            {
                Id = 2,
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
                Id = 2,
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
                Id = 2,
                Size = 6.1m,
                ColorsQuantity = 16,
                ScreenType = "Super Retina XDR",
                HorizontalResolution = 2532,
                VerticalResolution = 1170
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
            var hardwareiPhone12Mini = new Hardware()
            {
                Id = 3,
                ProcessorName = "A14 Bionic",
                OperationSystem = "iOS",
                GraphicsProcessor = "A14 Bionic",
                OperationMemory = 4,
                MemorySpace = 64,
                SimCardType = "Nano",
                BatteryCapacity = 2775
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
            var screeniPhone12Mini = new Screen()
            {
                Id = 3,
                Size = 5.4m,
                ColorsQuantity = 16,
                ScreenType = "Super Retina XDR",
                HorizontalResolution = 2340,
                VerticalResolution = 1080
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


            var hardwareLgWing = new Hardware()
            {
                Id = 4,
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
                Id = 4,
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
                Id = 4,
                Size = 6.8m,
                ColorsQuantity = 16,
                ScreenType = "FHD+ P-OLED FullVision",
                HorizontalResolution = 2460,
                VerticalResolution = 1080
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

            var hardwareLgVelvet = new Hardware()
            {
                Id = 5,
                ProcessorName = "Qualcomm Snapdragon 765G",
                OperationSystem = "Android",
                GraphicsProcessor = "Adreno 620 GPU",
                OperationMemory = 6,
                MemorySpace = 128,
                SimCardType = "Nano",
                BatteryCapacity = 4300
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
                Functions = new List<string>()
                {
                    "Video Recorder",
                    "Autofokus",
                    "Flash",
                    "Night Mode",
                    "AI CAM",
                    "AR Stickers"
                }
            };
            var screenLgVelvet = new Screen()
            {
                Id = 5,
                Size = 6.8m,
                ColorsQuantity = 16,
                ScreenType = "FHD+ OLED FullVision",
                HorizontalResolution = 2460,
                VerticalResolution = 1080
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

            var hardwareLgK61 = new Hardware()
            {
                Id = 6,
                ProcessorName = "MediaTek Helio P35",
                OperationSystem = "Android",
                GraphicsProcessor = "IMG GE8320 680MHz",
                OperationMemory = 4,
                MemorySpace = 128,
                SimCardType = "Nano",
                BatteryCapacity = 4000
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
                Functions = new List<string>()
                {
                    "Video Recorder",
                    "Autofokus",
                    "Flash",
                    "Night Mode",
                    "HDR"
                }
            };
            var screenLgK61 = new Screen()
            {
                Id = 6,
                Size = 6.5m,
                ColorsQuantity = 16,
                ScreenType = "FHD+ IPS",
                HorizontalResolution = 2340,
                VerticalResolution = 1080
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

            var hardwareFold2 = new Hardware()
            {
                Id = 7,
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
                Id = 7,
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
                Id = 7,
                Size = 6.1m,
                ColorsQuantity = 16,
                ScreenType = "Dynamic AMOLED 2X",
                HorizontalResolution = 2208,
                VerticalResolution = 1768
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

            var hardwareFlip = new Hardware()
            {
                Id = 8,
                ProcessorName = "Snapdragon 865+",
                OperationSystem = "Android",
                GraphicsProcessor = "Adreno 650",
                OperationMemory = 8,
                MemorySpace = 256,
                SimCardType = "Nano",
                BatteryCapacity = 3300
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
                Functions = new List<string>()
                {
                    "Video Recorder",
                    "Autofokus",
                    "Flash",
                    "HDR",
                    "Dynamic Photo"
                }
            };
            var screenFlip = new Screen()
            {
                Id = 8,
                Size = 6.7m,
                ColorsQuantity = 16,
                ScreenType = "Dynamic AMOLED & Super AMOLED",
                HorizontalResolution = 2636,
                VerticalResolution = 1080
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

            var hardwareS21 = new Hardware()
            {
                Id = 9,
                ProcessorName = "Exynos",
                OperationSystem = "Android",
                GraphicsProcessor = "Mali G78 MP14",
                OperationMemory = 8,
                MemorySpace = 256,
                SimCardType = "Nano",
                BatteryCapacity = 4000
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
                Functions = new List<string>()
                {
                    "Video Recorder",
                    "Autofokus",
                    "Flash",
                    "HDR",
                    "Dynamic Photo"
                }
            };
            var screenS21 = new Screen()
            {
                Id = 9,
                Size = 6.2m,
                ColorsQuantity = 16,
                ScreenType = "Dynamic AMOLED 2X, 120Hz, HDR10+",
                HorizontalResolution = 2400,
                VerticalResolution = 1080
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

            var hardwareA51 = new Hardware()
            {
                Id = 10,
                ProcessorName = "Exynos 9611",
                OperationSystem = "Android",
                GraphicsProcessor = "Mali G72 MP3",
                OperationMemory = 4,
                MemorySpace = 128,
                SimCardType = "Nano",
                BatteryCapacity = 4000
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
                Functions = new List<string>()
                {
                    "Video Recorder",
                    "Autofokus",
                    "Flash",
                    "HDR",
                    "Dynamic Photo"
                }
            };
            var screenA51 = new Screen()
            {
                Id = 10,
                Size = 6.5m,
                ColorsQuantity = 16,
                ScreenType = "FHD+ Super AMOLED",
                HorizontalResolution = 2400,
                VerticalResolution = 1080
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
                Functions = new List<string>()
                {
                    "Video Recorder",
                    "Autofokus",
                    "Flash",
                    "HDR",
                    "Deep Photo"
                }
            };
            var screenMateXS = new Screen()
            {
                Id = 11,
                Size = 6.6m,
                ColorsQuantity = 16,
                ScreenType = "OLED",
                HorizontalResolution = 2480,
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
                Functions = new List<string>()
                {
                    "Video Recorder",
                    "Autofokus",
                    "Flash",
                    "HDR",
                    "Deep Photo 3D"
                }
            };
            var screenMate40Pro = new Screen()
            {
                Id = 12,
                Size = 6.8m,
                ColorsQuantity = 16,
                ScreenType = "FHD+ OLED",
                HorizontalResolution = 2772,
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
                Functions = new List<string>()
                {
                    "Video Recorder",
                    "Autofokus",
                    "Flash"
                }
            };
            var screenSonyL4 = new Screen()
            {
                Id = 13,
                Size = 6.2m,
                ColorsQuantity = 16,
                ScreenType = "TFT LCD",
                HorizontalResolution = 1680,
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
                Functions = new List<string>()
                {
                    "Video Recorder",
                    "Autofokus",
                    "Flash"
                }
            };
            var screenSony10 = new Screen()
            {
                Id = 14,
                Size = 6.0m,
                ColorsQuantity = 16,
                ScreenType = "OLED",
                HorizontalResolution = 2520,
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
                Functions = new List<string>()
                {
                    "Video Recorder",
                    "Autofokus",
                    "Flash",
                    "Ultra-wide",
                    "Deep view"
                }
            };
            var screenXiaomi10Lite = new Screen()
            {
                Id = 15,
                Size = 6.7m,
                ColorsQuantity = 16,
                ScreenType = "FHD+ DotDisplay 120 Hz IPS",
                HorizontalResolution = 2400,
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
                Functions = new List<string>()
                {
                    "Video Recorder",
                    "Autofokus",
                    "Flash",
                    "Ultra-wide",
                    "Deep view",
                    "HMX"
                }
            };
            var screenXiaomi10Pro = new Screen()
            {
                Id = 16,
                Size = 6.7m,
                ColorsQuantity = 16,
                ScreenType = "FHD+ DotDisplay 144Hz IPS",
                HorizontalResolution = 2440,
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
                Functions = new List<string>()
                {
                    "Video Recorder",
                    "Autofokus",
                    "Flash"
                }
            };
            var screenXiaomiRedmi = new Screen()
            {
                Id = 17,
                Size = 6.7m,
                ColorsQuantity = 16,
                ScreenType = "FHD+ AMOLED",
                HorizontalResolution = 2340,
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
                Functions = new List<string>()
                {
                    "Video Recorder",
                    "Autofokus",
                    "Flash",
                    "Portrait",
                    "Live filtr",
                    "In motion",
                    "Night mode"
                }
            };
            var screenRazr = new Screen()
            {
                Id = 18,
                Size = 6.2m,
                ColorsQuantity = 16,
                ScreenType = "pOLED",
                HorizontalResolution = 2142,
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
                Functions = new List<string>()
                {
                    "Video Recorder",
                    "Autofokus",
                    "Flash",
                    "Portrait",
                    "In motion",
                    "Night mode"
                }
            };
            var screenEdge = new Screen()
            {
                Id = 19,
                Size = 6.7m,
                ColorsQuantity = 16,
                ScreenType = "FHD+ OLED",
                HorizontalResolution = 2340,
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
                Functions = new List<string>()
                {
                    "Video Recorder",
                    "Autofokus",
                    "Flash",
                    "Portrait",
                    "Night mode"
                }
            };
            var screenMoto = new Screen()
            {
                Id = 20,
                Size = 6.7m,
                ColorsQuantity = 16,
                ScreenType = "FHD+ IPS CinemaVision",
                HorizontalResolution = 2520,
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

            phones.Add(iPhone12);
            phones.Add(iPhone12Pro);
            phones.Add(iPhone12Mini);
            phones.Add(lgWing);
            phones.Add(lgVelvet);
            phones.Add(lgK61);
            phones.Add(fold2);
            phones.Add(flip);
            phones.Add(s21);
            phones.Add(a51);
            phones.Add(mateXS);
            phones.Add(mate40Pro);
            phones.Add(sonyXperiaL4);
            phones.Add(sonyXperia10);
            phones.Add(xiaomi10Lite);
            phones.Add(xiaomi10Pro);
            phones.Add(xiaomiRedmi);
            phones.Add(razr);
            phones.Add(edge);
            phones.Add(moto);

            return phones;
        }



        public List<MobilePhone> GetMobiles()
        {
            return mobilePhones;
        }

    }
}
