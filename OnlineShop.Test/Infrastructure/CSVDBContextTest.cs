using FluentAssertions;
using OnlineShop.Web.Infrastructure;
using OnlineShop.Web.Infrastructure.Helper;
using OnlineShop.Web.Models.ModelForCSV;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Xunit;

namespace OnlineShop.Test.Infrastructure
{
    public class CSVDBContextTest
    {
        [Fact]
        public void RetriveCamerasFromCSVTestFileDoesntExist()
        {
            //Arrange
            var cameraPath = "..\\..\\..\\..\\OnlineShop.Web\\Infrastructure\\Helper\\CSVSeed\\Camera.csv";
            var fileManager = new FileManager("..\\..\\..\\..\\OnlineShop.Web\\Infrastructure\\Helper");
            var cSVDBContext = new CSVDBContext(cameraPath, null, null, null, null, fileManager);
            //Act
            var list = cSVDBContext.RetriveCamerasFromCSV();
            //Assert
            list.Should().HaveCount(0);
            list.Should().BeOfType<List<CameraCSV>>();
            File.Delete(cameraPath);
        }

        [Fact]
        public void RetriveCamerasFromCSVTest()
        {
            //Arrange
            var cameraPath = "..\\..\\..\\..\\OnlineShop.Web\\Infrastructure\\Helper\\CSVSeed\\Camera.csv";
            var fileManager = new FileManager("..\\..\\..\\..\\OnlineShop.Web\\Infrastructure\\Helper");
            var cSVDBContext = new CSVDBContext(cameraPath, null, null, null, null, fileManager);
            cSVDBContext.CreateCSVFiles();
            //Act
            var list = cSVDBContext.RetriveCamerasFromCSV();
            //Assert
            list.Should().HaveCount(30);
            list.Should().BeOfType<List<CameraCSV>>();
            File.Delete(cameraPath);
        }

        [Fact]
        public void RetriveHardwaresFromCSVTest()
        {
            //Arrange
            var hardwarePath = "..\\..\\..\\..\\OnlineShop.Web\\Infrastructure\\Helper\\CSVSeed\\Hardware.csv";
            var fileManager = new FileManager("..\\..\\..\\..\\OnlineShop.Web\\Infrastructure\\Helper");
            var cSVDBContext = new CSVDBContext(null, hardwarePath, null, null, null, fileManager);
            cSVDBContext.CreateCSVFiles();
            //Act
            var list = cSVDBContext.RetriveHardwaresFromCSV();
            //Assert
            list.Should().HaveCount(30);
            list.Should().BeOfType<List<HardwareCSV>>();
            File.Delete(hardwarePath);
        }

        [Fact]
        public void RetriveScreensFromCSV()
        {
            //Arrange
            var screenPath = "..\\..\\..\\..\\OnlineShop.Web\\Infrastructure\\Helper\\CSVSeed\\Screen.csv";
            var fileManager = new FileManager("..\\..\\..\\..\\OnlineShop.Web\\Infrastructure\\Helper");
            var cSVDBContext = new CSVDBContext(null, null, screenPath, null, null, fileManager);
            cSVDBContext.CreateCSVFiles();
            //Act
            var list = cSVDBContext.RetriveScreensFromCSV();
            //Assert
            list.Should().HaveCount(30);
            list.Should().BeOfType<List<ScreenCSV>>();
            File.Delete(screenPath);
        }

        [Fact]
        public void RetriveMobilePhonesFromCSV()
        {
            //Arrange
            var mobilePhonePath = "..\\..\\..\\..\\OnlineShop.Web\\Infrastructure\\Helper\\CSVSeed\\MobilePhone.csv";
            var fileManager = new FileManager("..\\..\\..\\..\\OnlineShop.Web\\Infrastructure\\Helper");
            var cSVDBContext = new CSVDBContext(null, null, null, mobilePhonePath, null, fileManager);
            cSVDBContext.CreateCSVFiles();
            //Act
            var list = cSVDBContext.RetriveMobilePhonesFromCSV();
            //Assert
            list.Should().HaveCount(30);
            list.Should().BeOfType<List<MobilePhoneCSV>>();
            File.Delete(mobilePhonePath);
        }

        [Fact]
        public void RetriveMultimediasFromCSVTest()
        {
            //Arrange
            var multimediaPath = "..\\..\\..\\..\\OnlineShop.Web\\Infrastructure\\Helper\\CSVSeed\\Multimedia.csv";
            var fileManager = new FileManager("..\\..\\..\\..\\OnlineShop.Web\\Infrastructure\\Helper");
            var cSVDBContext = new CSVDBContext(null, null, null, null, multimediaPath, fileManager);
            cSVDBContext.CreateCSVFiles();
            //Act
            var list = cSVDBContext.RetriveMultimediasFromCSV();
            //Assert
            list.Should().HaveCount(2);
            list.Should().BeOfType<List<MultimediaCSV>>();
            File.Delete(multimediaPath);
        }

        [Fact]
        public void CreateCSVFilesTest()
        {
            //Arrange
            var cameraPath = "..\\..\\..\\..\\OnlineShop.Web\\Infrastructure\\Helper\\CSVSeed\\Camera.csv";
            var hardwarePath = "..\\..\\..\\..\\OnlineShop.Web\\Infrastructure\\Helper\\CSVSeed\\Hardware.csv";
            var screenPath = "..\\..\\..\\..\\OnlineShop.Web\\Infrastructure\\Helper\\CSVSeed\\Screen.csv";
            var mobilePhonePath = "..\\..\\..\\..\\OnlineShop.Web\\Infrastructure\\Helper\\CSVSeed\\MobilePhone.csv";
            var multimediaPath = "..\\..\\..\\..\\OnlineShop.Web\\Infrastructure\\Helper\\CSVSeed\\Multimedia.csv";
            var fileManager = new FileManager("..\\..\\..\\..\\OnlineShop.Web\\Infrastructure\\Helper");
            var cSVDBContext = new CSVDBContext(cameraPath, hardwarePath, screenPath, mobilePhonePath, multimediaPath, fileManager);
            //Act
            cSVDBContext.CreateCSVFiles();
            //Assert
            File.Exists(cameraPath).Should().BeTrue();
            File.Exists(hardwarePath).Should().BeTrue();
            File.Exists(screenPath).Should().BeTrue();
            File.Exists(mobilePhonePath).Should().BeTrue();
            File.Exists(multimediaPath).Should().BeTrue();
            //Clean Up
            cSVDBContext.CreateCSVFiles();
            File.Delete(cameraPath);
            File.Delete(hardwarePath);
            File.Delete(screenPath);
            File.Delete(mobilePhonePath);
            File.Delete(multimediaPath);
        }
    }
}
