using FluentAssertions;
using OnlineShop.Domain.ModelForCSV;
using OnlineShop.Infrastructure;
using OnlineShop.Infrastructure.IOHelper;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace OnlineShop.Test.Infrastructure
{
    public class CSVDBContextTest
    {
        [Fact]
        public void RetriveCamerasFromCSVTest()
        {
            var cameraPath = "..\\..\\..\\..\\OnlineShop.Infrastructure\\IOHelper\\Seed\\Camera.csv";
            //Arrange
            var cSVDBContext = new CSVDBContext(cameraPath, null, null, null, null);
            //Act
            var list = cSVDBContext.RetriveCamerasFromCSV();
            //Assert
            list.Should().HaveCount(30);
            list.Should().BeOfType<List<CameraCSV>>();
        }

        [Fact]
        public void RetriveCamerasFromCSVTestWrongPathToFile()
        {
            var cameraPath = "OnlineShop.Infrastructure\\IOHelper\\Seed\\Camera.csv";
            //Arrange
            var cSVDBContext = new CSVDBContext(cameraPath, null, null, null, null);
            //Act
            var list = cSVDBContext.RetriveCamerasFromCSV();
            //Assert
            list.Should().HaveCount(0);
            list.Should().BeOfType<List<CameraCSV>>();
        }

        [Fact]
        public void RetriveHardwaresFromCSVTest()
        {
            var hardwarePath = "..\\..\\..\\..\\OnlineShop.Infrastructure\\IOHelper\\Seed\\Hardware.csv";
            //Arrange
            var cSVDBContext = new CSVDBContext(null, hardwarePath, null, null, null);
            //Act
            var list = cSVDBContext.RetriveHardwaresFromCSV();
            //Assert
            list.Should().HaveCount(30);
            list.Should().BeOfType<List<HardwareCSV>>();
        }

        [Fact]
        public void RetriveScreensFromCSV()
        {
            var screenPath = "..\\..\\..\\..\\OnlineShop.Infrastructure\\IOHelper\\Seed\\Screen.csv";
            //Arrange
            var cSVDBContext = new CSVDBContext(null, null, screenPath, null, null);
            //Act
            var list = cSVDBContext.RetriveScreensFromCSV();
            //Assert
            list.Should().HaveCount(30);
            list.Should().BeOfType<List<ScreenCSV>>();
        }

        [Fact]
        public void RetriveMobilePhonesFromCSV()
        {
            var mobilePhonePath = "..\\..\\..\\..\\OnlineShop.Infrastructure\\IOHelper\\Seed\\MobilePhone.csv";
            //Arrange
            var cSVDBContext = new CSVDBContext(null, null, null, mobilePhonePath, null);
            //Act
            var list = cSVDBContext.RetriveMobilePhonesFromCSV();
            //Assert
            list.Should().HaveCount(30);
            list.Should().BeOfType<List<MobilePhoneCSV>>();
        }

        [Fact]
        public void RetriveMultimediasFromCSVTest()
        {
            var multimediaPath = "..\\..\\..\\..\\OnlineShop.Infrastructure\\IOHelper\\Seed\\Multimedia.csv";
            //Arrange
            var cSVDBContext = new CSVDBContext(null, null, null, null, multimediaPath);
            //Act
            var list = cSVDBContext.RetriveMultimediasFromCSV();
            //Assert
            list.Should().HaveCount(2);
            list.Should().BeOfType<List<MultimediaCSV>>();
        }
    }
}
