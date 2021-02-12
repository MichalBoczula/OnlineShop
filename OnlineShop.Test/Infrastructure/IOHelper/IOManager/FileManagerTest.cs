using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using FluentAssertions;
using System.IO;
using System.Linq;
using OnlineShop.Web.Infrastructure.Helper;
using OnlineShop.Web.Models.Entity;
using OnlineShop.Web.Models.ModelForCSV;

namespace OnlineShop.Test.Infrastructure.IOHelper.IOManager
{
    public class FileManagerTest
    {
        [Fact]
        public void AddCameraToFile()
        {
            //Arrange
            var list = new List<CameraCSV>();
            var result = new List<CameraCSV>();
            var cameraiPhone12 = new CameraCSV()
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
            list.Add(cameraiPhone12);
            var fileManager = new FileManager("..\\..\\..\\..\\OnlineShop.Infrastructure\\Helper");
            //Act
            fileManager.WriteDataToCSV<CameraCSV>(list);
            fileManager.ReadDataFromCSV<CameraCSV>("..\\..\\..\\..\\OnlineShop.Infrastructure\\Helper\\CSVSeed\\Camera.csv", result);
            //Assert
            result.Should().NotBeEmpty();
            result.Count.Should().Be(1);
            //Clean Up
            File.Delete("..\\..\\..\\..\\OnlineShop.Infrastructure\\Helper\\CSVSeed\\Camera.csv");
        }

        [Fact]
        public void AddHardwareToFile()
        {
            //Arrange
            var list = new List<HardwareCSV>();
            var result = new List<HardwareCSV>();
            var hardwareiPhone12 = new HardwareCSV()
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
            list.Add(hardwareiPhone12);
            var fileManager = new FileManager("..\\..\\..\\..\\OnlineShop.Infrastructure\\Helper");
            //Act
            fileManager.WriteDataToCSV<HardwareCSV>(list);
            fileManager.ReadDataFromCSV<HardwareCSV>("..\\..\\..\\..\\OnlineShop.Infrastructure\\Helper\\CSVSeed\\Hardware.csv", result);
            //Assert
            result.Should().NotBeEmpty();
            result.Count.Should().Be(1);
            //Clean Up
            File.Delete("..\\..\\..\\..\\OnlineShop.Infrastructure\\Helper\\CSVSeed\\Hardware.csv");
        }

        [Fact]
        public void AddScreenToFile()
        {
            //Arrange
            var list = new List<ScreenCSV>();
            var result = new List<ScreenCSV>();
            var screeniPhone12 = new ScreenCSV()
            {
                Id = 1,
                Size = 6.1m,
                ColorsQuantity = 16,
                ScreenType = "OLED Super Retina XDR",
                HorizontalResolution = 2532,
                VerticalResolution = 1170,
                MobilePhoneId = 1
            };
            list.Add(screeniPhone12);
            var fileManager = new FileManager("..\\..\\..\\..\\OnlineShop.Infrastructure\\Helper");
            //Act
            fileManager.WriteDataToCSV<ScreenCSV>(list);
            fileManager.ReadDataFromCSV<ScreenCSV>("..\\..\\..\\..\\OnlineShop.Infrastructure\\Helper\\CSVSeed\\Screen.csv", result);
            //Assert
            result.Should().NotBeEmpty();
            result.Count.Should().Be(1);
            //Clean Up
            File.Delete("..\\..\\..\\..\\OnlineShop.Infrastructure\\Helper\\CSVSeed\\Screen.csv");
        }

        [Fact]
        public void AddMobilePhoneToFile()
        {
            //Arrange
            var list = new List<MobilePhoneCSV>();
            var result = new List<MobilePhoneCSV>();
            var iPhone12 = new MobilePhoneCSV()
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
                BestSeller = true
            };
            list.Add(iPhone12);
            var fileManager = new FileManager("..\\..\\..\\..\\OnlineShop.Infrastructure\\Helper");
            //Act
            fileManager.WriteDataToCSV<MobilePhoneCSV>(list);
            fileManager.ReadDataFromCSV<MobilePhoneCSV>("..\\..\\..\\..\\OnlineShop.Infrastructure\\Helper\\CSVSeed\\MobilePhone.csv", result);
            //Assert
            result.Should().NotBeEmpty();
            result.Count.Should().Be(1);
            //Clean Up
            File.Delete("..\\..\\..\\..\\OnlineShop.Infrastructure\\Helper\\CSVSeed\\MobilePhone.csv");
        }

        [Fact]
        public void AppendScreenToFile()
        {
            //Arrange
            var list = new List<ScreenCSV>();
            var result = new List<ScreenCSV>();
            var screen1 = new ScreenCSV()
            {
                Id = 1,
                Size = 6.1m,
                ColorsQuantity = 16,
                ScreenType = "OLED Super Retina XDR",
                HorizontalResolution = 2532,
                VerticalResolution = 1170,
                MobilePhoneId = 1
            };
            var screen2 = new ScreenCSV()
            {
                Id = 2,
                Size = 6.1m,
                ColorsQuantity = 16,
                ScreenType = "OLED Super Retina XDR",
                HorizontalResolution = 2532,
                VerticalResolution = 1170,
                MobilePhoneId = 1
            };
            list.Add(screen1);
            var fileManager = new FileManager("..\\..\\..\\..\\OnlineShop.Infrastructure\\Helper");
            fileManager.WriteDataToCSV<ScreenCSV>(list);
            list.RemoveAt(0);
            list.Add(screen2);
            //Act
            fileManager.WriteDataToCSV<ScreenCSV>(list);
            fileManager.ReadDataFromCSV<ScreenCSV>("..\\..\\..\\..\\OnlineShop.Infrastructure\\Helper\\CSVSeed\\Screen.csv", result);
            //Assert
            result.Should().NotBeEmpty();
            result.Count.Should().Be(2);
            result[0].Id.Should().Be(1);
            result[1].Id.Should().Be(2);
            //Clean Up
            File.Delete("..\\..\\..\\..\\OnlineShop.Infrastructure\\Helper\\CSVSeed\\Screen.csv");
        }

        [Fact]
        public void ReadManyHardwaresFromFile()
        {
            //Arrange
            var list = new List<HardwareCSV>();
            var result = new List<HardwareCSV>();
            var hard1 = new HardwareCSV()
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
            var hard2 = new HardwareCSV()
            {
                Id = 2,
                ProcessorName = "A14 Bionic",
                OperationSystem = "iOS",
                GraphicsProcessor = "A14 Bionic",
                OperationMemory = 4,
                MemorySpace = 64,
                SimCardType = "Nano",
                BatteryCapacity = 2500,
                MobilePhoneId = 1
            };
            var hard3 = new HardwareCSV()
            {
                Id = 3,
                ProcessorName = "A14 Bionic",
                OperationSystem = "iOS",
                GraphicsProcessor = "A14 Bionic",
                OperationMemory = 4,
                MemorySpace = 64,
                SimCardType = "Nano",
                BatteryCapacity = 2500,
                MobilePhoneId = 1
            };
            list.Add(hard1);
            list.Add(hard2);
            list.Add(hard3);
            var fileManager = new FileManager("..\\..\\..\\..\\OnlineShop.Infrastructure\\Helper");
            fileManager.WriteDataToCSV<HardwareCSV>(list);
            //Act
            fileManager.ReadDataFromCSV<HardwareCSV>("..\\..\\..\\..\\OnlineShop.Infrastructure\\Helper\\CSVSeed\\Hardware.csv", result);
            //Assert
            result.Should().NotBeEmpty();
            result.Count.Should().Be(3);
            //Clean up
            File.Delete("..\\..\\..\\..\\OnlineShop.Infrastructure\\Helper\\CSVSeed\\Hardware.csv");
        }
    }
}
