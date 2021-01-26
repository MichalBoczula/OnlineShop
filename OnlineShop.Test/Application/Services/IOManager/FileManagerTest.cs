using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using OnlineShop.Infrastructure.IOHelper;
using FluentAssertions;
using OnlineShop.Domain.Model;
using System.IO;

namespace OnlineShop.Test.Application.Services.IOManager
{
    public class FileManagerTest
    {
        [Fact]
        public void IsFileExist()
        {
            //Arrange
            var fileManager = new FileManager()
            {
                path = "..\\..\\..\\..\\OnlineShop.Web\\wwwroot\\seed\\TextFile.txt"
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
            var fileManager = new FileManager()
            {
                path = "..\\..\\..\\..\\OnlineShop.Web\\wwwroot\\seed\\TextFile.txt"
            };
            //Act
            fileManager.CreateFile();
            var result = fileManager.IsFileExist();
            //Assert
            result.Should().BeTrue();
        }
    }
}
