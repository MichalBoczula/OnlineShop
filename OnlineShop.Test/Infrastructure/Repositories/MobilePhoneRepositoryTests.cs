using FluentAssertions;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using OnlineShop.Application.ViewModels.Mobile;
using OnlineShop.Domain.Model;
using OnlineShop.Infrastructure;
using OnlineShop.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace OnlineShop.Test.Infrastructure.Repositories
{
    public class MobilePhoneRepositoryTests
    {
        private IServiceProvider BuildSqliteDBProvider()
        {
            var services = new ServiceCollection();
            var connectionStringBuilder = new SqliteConnectionStringBuilder { DataSource = ":memory:" };
            var connection = new SqliteConnection(connectionStringBuilder.ToString());
            services.AddDbContext<DatabaseContext>(opt => opt.UseSqlite(connection),
                ServiceLifetime.Scoped,
                ServiceLifetime.Scoped);

            return services.BuildServiceProvider();
        }

        private IServiceProvider BuildInMemoryDBProvider()
        {
            var services = new ServiceCollection();
            services.AddDbContext<DatabaseContext>(opt => opt.UseInMemoryDatabase(databaseName: $"InMemoryTest{Guid.NewGuid()}"),
                ServiceLifetime.Scoped,
                ServiceLifetime.Scoped);

            return services.BuildServiceProvider();
        }

        [Fact]
        public void GetAllActiveMobilePhonesTest()
        {
            var serviceProvider = BuildSqliteDBProvider();
            using (var dbContext = serviceProvider.GetService<DatabaseContext>())
            {
                //Arrange
                dbContext.Database.OpenConnection();
                dbContext.Database.EnsureCreated();
                var mobilePhoneRepository = new MobilePhoneRepository(dbContext);
                //Act
                var result = mobilePhoneRepository.GetAllActiveMobilePhones();
                //Assert
                result.Should().HaveCount(30);
            }
        }

        [Fact]
        public async Task GetMobilePhoneByIdTest()
        {
            var serviceProvider = BuildSqliteDBProvider();
            using (var dbContext = serviceProvider.GetService<DatabaseContext>())
            {
                //Arrange
                dbContext.Database.OpenConnection();
                dbContext.Database.EnsureCreated();
                var mobilePhoneRepository = new MobilePhoneRepository(dbContext);
                //Act
                var result = await mobilePhoneRepository.GetMobilePhoneById(1);
                //Assert
                result.Brand.Should().Be("Apple");
                result.Name.Should().Be("iPhone 12");
                result.Multimedia.Id.Should().Be(1);
                result.Camera.Id.Should().Be(1);
                result.Hardware.Id.Should().Be(1);
                result.Screen.Id.Should().Be(1);
            }
        }

        [Fact]
        public async Task GetMobilePhoneByIdTestNoData()
        {
            var serviceProvider = BuildSqliteDBProvider();
            using (var dbContext = serviceProvider.GetService<DatabaseContext>())
            {
                //Arrange
                dbContext.Database.OpenConnection();
                dbContext.Database.EnsureCreated();
                var mobilePhoneRepository = new MobilePhoneRepository(dbContext);
                //Act
                var result = await mobilePhoneRepository.GetMobilePhoneById(31);
                //Assert
                result.Should().BeNull();
            }
        }

        [Fact]
        public void GetBestSellersTest()
        {
            var serviceProvider = BuildSqliteDBProvider();
            using (var dbContext = serviceProvider.GetService<DatabaseContext>())
            {
                //Arrange
                dbContext.Database.OpenConnection();
                dbContext.Database.EnsureCreated();
                var mobilePhoneRepository = new MobilePhoneRepository(dbContext);
                //Act
                var result = mobilePhoneRepository.GetBestSellers();
                //Assert
                result.Should().HaveCount(3);
            }
        }

        [Fact]
        public void GetAllActiveMobilePhonesTest_ThereAreNoMobilePhonesInDB()
        {
            var serviceProvider = BuildInMemoryDBProvider();
            using (var dbContext = serviceProvider.GetService<DatabaseContext>())
            {
                //Arrange
                var mobilePhoneRepository = new MobilePhoneRepository(dbContext);
                //Act
                var result = mobilePhoneRepository.GetAllActiveMobilePhones();
                //Assert
                result.Should().BeEmpty();
            }
        }

        [Fact]
        public void GetAllActiveMobilePhonesTest_ThereAreThreeMobiles()
        {
            var serviceProvider = BuildInMemoryDBProvider();
            using (var dbContext = serviceProvider.GetService<DatabaseContext>())
            {
                //Arrange
                dbContext.Add(new MobilePhone()
                {
                    Id = 1,
                    Brand = "Apple",
                    Name = "iPhone 12",
                    Price = 3000,
                    ShortDescription = "short",
                    Description = "Description",
                    ActiveStatus = true,
                    QuantityInStack = QuantityStatus.Full,
                    MainImage = "/Apple/iPhone 12/Main.png",
                    FirstImage = "/Apple/iPhone 12/First.png",
                    SecondImage = "/Apple/iPhone 12/Second.png",
                    BestSeller = true
                });
                dbContext.Add(new MobilePhone()
                {
                    Id = 4,
                    Brand = "LG",
                    Name = "Wing 5G",
                    Price = 4500,
                    ShortDescription = "short",
                    Description = "Description",
                    ActiveStatus = true,
                    QuantityInStack = QuantityStatus.Full,
                    MainImage = "/LG/Wing/Main.png",
                    FirstImage = "/LG/Wing/First.png",
                    SecondImage = "/LG/Wing/Second.png",
                    BestSeller = true
                });
                dbContext.Add(new MobilePhone()
                {
                    Id = 24,
                    Brand = "Apple",
                    Name = "iPhone SE",
                    Price = 2100,
                    ShortDescription = "short",
                    Description = "Description",
                    ActiveStatus = true,
                    QuantityInStack = QuantityStatus.Full,
                    MainImage = "/Apple/iPhone SE/Main.png",
                    FirstImage = "/Apple/iPhone SE/First.png",
                    SecondImage = "/Apple/iPhone SE/Second.png",
                    BestSeller = false
                });
                dbContext.SaveChanges();

                var mobilePhoneRepository = new MobilePhoneRepository(dbContext);
                //Act
                var result = mobilePhoneRepository.GetAllActiveMobilePhones();
                //Assert
                result.Should().HaveCount(3);
            }
        }

        [Fact]
        public void GetAllActiveMobilePhonesTest_ThereAreTwoActive()
        {
            var serviceProvider = BuildInMemoryDBProvider();
            using (var dbContext = serviceProvider.GetService<DatabaseContext>())
            {
                //Arrange
                dbContext.Add(new MobilePhone()
                {
                    Id = 1,
                    Brand = "Apple",
                    Name = "iPhone 12",
                    Price = 3000,
                    ShortDescription = "short",
                    Description = "Description",
                    ActiveStatus = true,
                    QuantityInStack = QuantityStatus.Full,
                    MainImage = "/Apple/iPhone 12/Main.png",
                    FirstImage = "/Apple/iPhone 12/First.png",
                    SecondImage = "/Apple/iPhone 12/Second.png",
                    BestSeller = true
                });
                dbContext.Add(new MobilePhone()
                {
                    Id = 4,
                    Brand = "LG",
                    Name = "Wing 5G",
                    Price = 4500,
                    ShortDescription = "short",
                    Description = "Description",
                    ActiveStatus = true,
                    QuantityInStack = QuantityStatus.Full,
                    MainImage = "/LG/Wing/Main.png",
                    FirstImage = "/LG/Wing/First.png",
                    SecondImage = "/LG/Wing/Second.png",
                    BestSeller = true
                });
                dbContext.Add(new MobilePhone()
                {
                    Id = 24,
                    Brand = "Apple",
                    Name = "iPhone SE",
                    Price = 2100,
                    ShortDescription = "short",
                    Description = "Description",
                    ActiveStatus = false,
                    QuantityInStack = QuantityStatus.Full,
                    MainImage = "/Apple/iPhone SE/Main.png",
                    FirstImage = "/Apple/iPhone SE/First.png",
                    SecondImage = "/Apple/iPhone SE/Second.png",
                    BestSeller = false
                });
                dbContext.SaveChanges();

                var mobilePhoneRepository = new MobilePhoneRepository(dbContext);
                //Act
                var result = mobilePhoneRepository.GetAllActiveMobilePhones();
                //Assert
                result.Should().HaveCount(2);
            }
        }

        [Fact]
        public void GetBestSellers_ThereAreTwo()
        {
            var serviceProvider = BuildInMemoryDBProvider();
            using (var dbContext = serviceProvider.GetService<DatabaseContext>())
            {
                //Arrange
                dbContext.Add(new MobilePhone()
                {
                    Id = 1,
                    Brand = "Apple",
                    Name = "iPhone 12",
                    Price = 3000,
                    ShortDescription = "short",
                    Description = "Description",
                    ActiveStatus = true,
                    QuantityInStack = QuantityStatus.Full,
                    MainImage = "/Apple/iPhone 12/Main.png",
                    FirstImage = "/Apple/iPhone 12/First.png",
                    SecondImage = "/Apple/iPhone 12/Second.png",
                    BestSeller = true
                });
                dbContext.Add(new MobilePhone()
                {
                    Id = 4,
                    Brand = "LG",
                    Name = "Wing 5G",
                    Price = 4500,
                    ShortDescription = "short",
                    Description = "Description",
                    ActiveStatus = true,
                    QuantityInStack = QuantityStatus.Full,
                    MainImage = "/LG/Wing/Main.png",
                    FirstImage = "/LG/Wing/First.png",
                    SecondImage = "/LG/Wing/Second.png",
                    BestSeller = true
                });
                dbContext.Add(new MobilePhone()
                {
                    Id = 24,
                    Brand = "Apple",
                    Name = "iPhone SE",
                    Price = 2100,
                    ShortDescription = "short",
                    Description = "Description",
                    ActiveStatus = false,
                    QuantityInStack = QuantityStatus.Full,
                    MainImage = "/Apple/iPhone SE/Main.png",
                    FirstImage = "/Apple/iPhone SE/First.png",
                    SecondImage = "/Apple/iPhone SE/Second.png",
                    BestSeller = false
                });
                dbContext.SaveChanges();

                var mobilePhoneRepository = new MobilePhoneRepository(dbContext);
                //Act
                var result = mobilePhoneRepository.GetBestSellers();
                //Assert
                result.Should().HaveCount(2);
            }
        }

        [Fact]
        public void GetBestSellers_EmptyDB()
        {
            var serviceProvider = BuildInMemoryDBProvider();
            using (var dbContext = serviceProvider.GetService<DatabaseContext>())
            {
                //Arrange
                var mobilePhoneRepository = new MobilePhoneRepository(dbContext);
                //Act
                var result = mobilePhoneRepository.GetBestSellers();
                //Assert
                result.Should().BeEmpty();
            }
        }

        [Fact]
        public async Task GetMobilePhoneById_InMemoryTest()
        {
            var serviceProvider = BuildInMemoryDBProvider();
            using (var dbContext = serviceProvider.GetService<DatabaseContext>())
            {
                //Arrange
                dbContext.Add(new MobilePhone()
                {
                    Id = 1,
                    Brand = "Apple",
                    Name = "iPhone 12",
                    Price = 3000,
                    ShortDescription = "short",
                    Description = "Description",
                    ActiveStatus = true,
                    QuantityInStack = QuantityStatus.Full,
                    MainImage = "/Apple/iPhone 12/Main.png",
                    FirstImage = "/Apple/iPhone 12/First.png",
                    SecondImage = "/Apple/iPhone 12/Second.png",
                    BestSeller = true
                });
                dbContext.Add(new MobilePhone()
                {
                    Id = 4,
                    Brand = "LG",
                    Name = "Wing 5G",
                    Price = 4500,
                    ShortDescription = "short",
                    Description = "Description",
                    ActiveStatus = true,
                    QuantityInStack = QuantityStatus.Full,
                    MainImage = "/LG/Wing/Main.png",
                    FirstImage = "/LG/Wing/First.png",
                    SecondImage = "/LG/Wing/Second.png",
                    BestSeller = true
                });
                dbContext.SaveChanges();

                var mobilePhoneRepository = new MobilePhoneRepository(dbContext);
                //Act
                var result = await mobilePhoneRepository.GetMobilePhoneById(1);
                //Assert
                result.Brand.Should().Be("Apple");
                result.Name.Should().Be("iPhone 12");
            }
        }

        [Fact]
        public async Task GetMobilePhoneById_ThereIsNoMobile()
        {
            var serviceProvider = BuildInMemoryDBProvider();
            using (var dbContext = serviceProvider.GetService<DatabaseContext>())
            {
                //Arrange
                dbContext.Add(new MobilePhone()
                {
                    Id = 1,
                    Brand = "Apple",
                    Name = "iPhone 12",
                    Price = 3000,
                    ShortDescription = "short",
                    Description = "Description",
                    ActiveStatus = true,
                    QuantityInStack = QuantityStatus.Full,
                    MainImage = "/Apple/iPhone 12/Main.png",
                    FirstImage = "/Apple/iPhone 12/First.png",
                    SecondImage = "/Apple/iPhone 12/Second.png",
                    BestSeller = true
                });
                dbContext.Add(new MobilePhone()
                {
                    Id = 4,
                    Brand = "LG",
                    Name = "Wing 5G",
                    Price = 4500,
                    ShortDescription = "short",
                    Description = "Description",
                    ActiveStatus = true,
                    QuantityInStack = QuantityStatus.Full,
                    MainImage = "/LG/Wing/Main.png",
                    FirstImage = "/LG/Wing/First.png",
                    SecondImage = "/LG/Wing/Second.png",
                    BestSeller = true
                });
                dbContext.SaveChanges();

                var mobilePhoneRepository = new MobilePhoneRepository(dbContext);
                //Act
                var result = await mobilePhoneRepository.GetMobilePhoneById(2);
                //Assert
                result.Should().BeNull();
            }
        }

        [Fact]
        public async Task GetMobilePhoneById_EmptyDB()
        {
            var serviceProvider = BuildInMemoryDBProvider();
            using (var dbContext = serviceProvider.GetService<DatabaseContext>())
            {
                //Arrange
                var mobilePhoneRepository = new MobilePhoneRepository(dbContext);
                //Act
                var result = await mobilePhoneRepository.GetMobilePhoneById(2);
                //Assert
                result.Should().BeNull();
            }
        }
    }
}
