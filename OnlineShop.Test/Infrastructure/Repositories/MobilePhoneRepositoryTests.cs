using FluentAssertions;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using OnlineShop.Web.Infrastructure;
using OnlineShop.Web.Infrastructure.Repositories;
using OnlineShop.Web.Models.Entity;
using OnlineShop.Web.Models.Filters;
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
        public void RetriveFilteredMobilePhonesTest_RetriveApple()
        {
            var serviceProvider = BuildSqliteDBProvider();
            using (var dbContext = serviceProvider.GetService<DatabaseContext>())
            {
                //Arrange
                var filters = new Filters();
                filters.Brands.Add("Apple");
                dbContext.Database.OpenConnection();
                dbContext.Database.EnsureCreated();
                var mobilePhoneRepository = new MobilePhoneRepository(dbContext);
                //Act
                var result = mobilePhoneRepository.RetriveFilteredMobilePhones(filters);
                //Assert
                result.Should().HaveCount(5);
            }
        }

        [Fact]
        public void RetriveFilteredMobilePhonesTest_RetriveAppleAndSony()
        {
            var serviceProvider = BuildSqliteDBProvider();
            using (var dbContext = serviceProvider.GetService<DatabaseContext>())
            {
                //Arrange
                var filters = new Filters();
                filters.Brands.Add("Apple");
                filters.Brands.Add("Sony");
                dbContext.Database.OpenConnection();
                dbContext.Database.EnsureCreated();
                var mobilePhoneRepository = new MobilePhoneRepository(dbContext);
                //Act
                var result = mobilePhoneRepository.RetriveFilteredMobilePhones(filters);
                //Assert
                result.Should().HaveCount(7);
            }
        }

        [Fact]
        public void RetriveFilteredMobilePhonesTest_FiltredByScreenSize()
        {
            var serviceProvider = BuildSqliteDBProvider();
            using (var dbContext = serviceProvider.GetService<DatabaseContext>())
            {
                //Arrange
                var filters = new Filters();
                filters.ScreenSize = 6.8m;
                dbContext.Database.OpenConnection();
                dbContext.Database.EnsureCreated();
                var mobilePhoneRepository = new MobilePhoneRepository(dbContext);
                //Act
                var result = mobilePhoneRepository.RetriveFilteredMobilePhones(filters);
                //Assert
                result.Should().HaveCount(4);
            }
        }

        [Fact]
        public void RetriveFilteredMobilePhonesTest_FiltredByMemorySpace()
        {
            var serviceProvider = BuildSqliteDBProvider();
            using (var dbContext = serviceProvider.GetService<DatabaseContext>())
            {
                //Arrange
                var filters = new Filters();
                filters.MemorySpace = 256;
                dbContext.Database.OpenConnection();
                dbContext.Database.EnsureCreated();
                var mobilePhoneRepository = new MobilePhoneRepository(dbContext);
                //Act
                var result = mobilePhoneRepository.RetriveFilteredMobilePhones(filters);
                //Assert
                result.Should().HaveCount(8);
            }
        }

        [Fact]
        public void RetriveFilteredMobilePhonesTest_FiltredByOperationMemory()
        {
            var serviceProvider = BuildSqliteDBProvider();
            using (var dbContext = serviceProvider.GetService<DatabaseContext>())
            {
                //Arrange
                var filters = new Filters();
                filters.OperationMemory = 12;
                dbContext.Database.OpenConnection();
                dbContext.Database.EnsureCreated();
                var mobilePhoneRepository = new MobilePhoneRepository(dbContext);
                //Act
                var result = mobilePhoneRepository.RetriveFilteredMobilePhones(filters);
                //Assert
                result.Should().HaveCount(2);
            }
        }

        [Fact]
        public void RetriveFilteredMobilePhonesTest_FiltredByCameraMainResolution()
        {
            var serviceProvider = BuildSqliteDBProvider();
            using (var dbContext = serviceProvider.GetService<DatabaseContext>())
            {
                //Arrange
                var filters = new Filters();
                filters.MainResolution = 64;
                dbContext.Database.OpenConnection();
                dbContext.Database.EnsureCreated();
                var mobilePhoneRepository = new MobilePhoneRepository(dbContext);
                //Act
                var result = mobilePhoneRepository.RetriveFilteredMobilePhones(filters);
                //Assert
                result.Should().HaveCount(7);
            }
        }

        [Fact]
        public void RetriveFilteredMobilePhonesTest_FiltredByCameraFrontResolution()
        {
            var serviceProvider = BuildSqliteDBProvider();
            using (var dbContext = serviceProvider.GetService<DatabaseContext>())
            {
                //Arrange
                var filters = new Filters();
                filters.FrontResolution = 32;
                dbContext.Database.OpenConnection();
                dbContext.Database.EnsureCreated();
                var mobilePhoneRepository = new MobilePhoneRepository(dbContext);
                //Act
                var result = mobilePhoneRepository.RetriveFilteredMobilePhones(filters);
                //Assert
                result.Should().HaveCount(5);
            }
        }

        [Fact]
        public void RetriveFilteredMobilePhonesTest_FiltredByLowerPrice()
        {
            var serviceProvider = BuildSqliteDBProvider();
            using (var dbContext = serviceProvider.GetService<DatabaseContext>())
            {
                //Arrange
                var filters = new Filters();
                filters.LowerPrice = 4000;
                dbContext.Database.OpenConnection();
                dbContext.Database.EnsureCreated();
                var mobilePhoneRepository = new MobilePhoneRepository(dbContext);
                //Act
                var result = mobilePhoneRepository.RetriveFilteredMobilePhones(filters);
                //Assert
                result.Should().HaveCount(7);
            }
        }

        [Fact]
        public void RetriveFilteredMobilePhonesTest_FiltredByMaxPrice()
        {
            var serviceProvider = BuildSqliteDBProvider();
            using (var dbContext = serviceProvider.GetService<DatabaseContext>())
            {
                //Arrange
                var filters = new Filters();
                filters.MaxPrice = 4000;
                dbContext.Database.OpenConnection();
                dbContext.Database.EnsureCreated();
                var mobilePhoneRepository = new MobilePhoneRepository(dbContext);
                //Act
                var result = mobilePhoneRepository.RetriveFilteredMobilePhones(filters);
                //Assert
                result.Should().HaveCount(23);
            }
        }

        [Fact]
        public void RetriveFilteredMobilePhonesTest_GetIOSPhones()
        {
            var serviceProvider = BuildSqliteDBProvider();
            using (var dbContext = serviceProvider.GetService<DatabaseContext>())
            {
                //Arrange
                var filters = new Filters();
                filters.OperationSystem = "iOS";
                dbContext.Database.OpenConnection();
                dbContext.Database.EnsureCreated();
                var mobilePhoneRepository = new MobilePhoneRepository(dbContext);
                //Act
                var result = mobilePhoneRepository.RetriveFilteredMobilePhones(filters);
                //Assert
                result.Should().HaveCount(5);
            }
        }

        [Fact]
        public void RetriveFilteredMobilePhonesTest_GetAndroidPhones()
        {
            var serviceProvider = BuildSqliteDBProvider();
            using (var dbContext = serviceProvider.GetService<DatabaseContext>())
            {
                //Arrange
                var filters = new Filters();
                filters.OperationSystem = "Android";
                dbContext.Database.OpenConnection();
                dbContext.Database.EnsureCreated();
                var mobilePhoneRepository = new MobilePhoneRepository(dbContext);
                //Act
                var result = mobilePhoneRepository.RetriveFilteredMobilePhones(filters);
                //Assert
                result.Should().HaveCount(25);
            }
        }

        [Fact]
        public void RetriveFilteredMobilePhonesTest_WithManyFilters()
        {
            var serviceProvider = BuildSqliteDBProvider();
            using (var dbContext = serviceProvider.GetService<DatabaseContext>())
            {
                //Arrange
                var filters = new Filters();
                filters.LowerPrice = 4000;
                filters.Brands.Add("Apple");
                filters.Brands.Add("Samsung");
                dbContext.Database.OpenConnection();
                dbContext.Database.EnsureCreated();
                var mobilePhoneRepository = new MobilePhoneRepository(dbContext);
                //Act
                var result = mobilePhoneRepository.RetriveFilteredMobilePhones(filters);
                //Assert
                result.Should().HaveCount(3);
            }
        }

        [Fact]
        public void RetriveFilteredMobilePhonesTest_WithManyFiltersSecondTest()
        {
            var serviceProvider = BuildSqliteDBProvider();
            using (var dbContext = serviceProvider.GetService<DatabaseContext>())
            {
                //Arrange
                var filters = new Filters();
                filters.OperationMemory = 8; 
                filters.MemorySpace = 64; 
                filters.LowerPrice = 2000; 
                filters.MaxPrice = 4000; 
                dbContext.Database.OpenConnection();
                dbContext.Database.EnsureCreated();
                var mobilePhoneRepository = new MobilePhoneRepository(dbContext);
                //Act
                var result = mobilePhoneRepository.RetriveFilteredMobilePhones(filters);
                //Assert
                result.Should().HaveCount(4);
            }
        }

        [Fact]
        public void RetriveFilteredMobilePhonesTest_WithManyFiltersThirdTest()
        {
            var serviceProvider = BuildSqliteDBProvider();
            using (var dbContext = serviceProvider.GetService<DatabaseContext>())
            {
                //Arrange
                var filters = new Filters();
                filters.OperationMemory = 6;
                filters.MemorySpace = 32;
                filters.Brands.Add("Apple");
                filters.Brands.Add("Xiaomi");
                filters.Brands.Add("Nokia");
                filters.Brands.Add("Motorola");
                filters.MaxPrice = 3000;
                dbContext.Database.OpenConnection();
                dbContext.Database.EnsureCreated();
                var mobilePhoneRepository = new MobilePhoneRepository(dbContext);
                //Act
                var result = mobilePhoneRepository.RetriveFilteredMobilePhones(filters);
                //Assert
                result.Should().HaveCount(3);
            }
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
                    BestSeller = true,
                    MultimediaId = 1
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
                    BestSeller = true,
                    MultimediaId = 1
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
