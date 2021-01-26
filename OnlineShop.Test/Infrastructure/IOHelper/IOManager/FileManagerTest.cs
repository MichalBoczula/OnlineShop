using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using OnlineShop.Infrastructure.IOHelper;
using FluentAssertions;
using OnlineShop.Domain.Model;
using System.IO;
using OnlineShop.Domain.ModelForCSV;

namespace OnlineShop.Test.Infrastructure.IOHelper.IOManager
{
    public class FileManagerTest
    {
        [Fact]
        public void IsFileExist()
        {
            //Arrange
            var fileManager = new FileManager()
            {
                path = "..\\..\\..\\..\\OnlineShop.Infrastructure\\IOHelper\\Seed\\TextFile.txt"
            };
            //Act
            var result = fileManager.IsFileExist();
            //Assert
            result.Should().BeFalse();
        }

        [Fact]
        public void IsFileExistWithCreate()
        {
            //Arrange
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
            var fileManager = new FileManager()
            {
                path = "..\\..\\..\\..\\OnlineShop.Infrastructure\\IOHelper\\Seed\\TextFile.txt"
            };
            //Act
            fileManager.CreateFile();
            var result = fileManager.IsFileExist();
            //Assert
            result.Should().BeTrue();
        }

        [Fact]
        public void AddHardwareToFile()
        {
            //Arrange
            var list = new List<HardwareCSV>();
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
            var fileManager = new FileManager()
            {
                path = "..\\..\\..\\..\\OnlineShop.Infrastructure\\IOHelper\\Seed\\Hardware.csv"
            };
            //Act
            fileManager.WriteDataToCSV<HardwareCSV>(list);
            //Assert
        }
    }
}
