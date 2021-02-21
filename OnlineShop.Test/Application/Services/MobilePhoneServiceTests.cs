using AutoMapper;
using FluentAssertions;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using OnlineShop.Web.Application.Services;
using OnlineShop.Web.Application.ViewModels.Camera;
using OnlineShop.Web.Application.ViewModels.Hardware;
using OnlineShop.Web.Application.ViewModels.Mobile;
using OnlineShop.Web.Application.ViewModels.Multimedia;
using OnlineShop.Web.Application.ViewModels.Screen;
using OnlineShop.Web.Infrastructure;
using OnlineShop.Web.Infrastructure.Repositories;
using OnlineShop.Web.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace OnlineShop.Test.Application.Services
{
    public class MobilePhoneServiceTests
    {
        private IServiceProvider BuildInMemoryDBProvider()
        {
            var services = new ServiceCollection();
            services.AddDbContext<DatabaseContext>(opt => opt.UseInMemoryDatabase(databaseName: $"InMemoryTest{Guid.NewGuid()}"),
                ServiceLifetime.Scoped,
                ServiceLifetime.Scoped);
            return services.BuildServiceProvider();
        }

        [Fact]
        public async Task GetMobilePhonesForHomeTest_DBEmpty()
        {
            var service = BuildInMemoryDBProvider();
            using (var dbContext = service.GetService<DatabaseContext>())
            {
                var configuration = new MapperConfiguration(cfg =>
                {
                    cfg.CreateMap<MobilePhone, MobilePhoneForHomeVM>();
                });
                //Arrange
                var mapper = new Mapper(configuration);
                var mobilePhoneRepository = new MobilePhoneRepository(dbContext);
                var mobilePhoneService = new MobilePhoneService(mobilePhoneRepository, mapper);
                //Act 
                var result = await mobilePhoneService.GetMobilePhonesForHome();
                //Assert
                result.Should().HaveCount(0);
            }
        }

        [Fact]
        public async Task GetMobilePhonesForHomeTest_ShouldGetThreeObjects()
        {
            var service = BuildInMemoryDBProvider();
            using (var dbContext = service.GetService<DatabaseContext>())
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
                    BestSeller = true
                });

                dbContext.SaveChanges();

                var configuration = new MapperConfiguration(cfg =>
                {
                    cfg.CreateMap<MobilePhone, MobilePhoneForHomeVM>();
                });
                var mapper = new Mapper(configuration);
                var mobilePhoneRepository = new MobilePhoneRepository(dbContext);
                var mobilePhoneService = new MobilePhoneService(mobilePhoneRepository, mapper);
                //Act 
                var result = await mobilePhoneService.GetMobilePhonesForHome();
                //Assert
                result.Should().HaveCount(3);
                result.Should().BeOfType<List<MobilePhoneForHomeVM>>();
            }
        }

        [Fact]
        public async Task GetMobilePhonesForListTest_ShouldGetThreeObjects()
        {
            var service = BuildInMemoryDBProvider();
            using (var dbContext = service.GetService<DatabaseContext>())
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
                    BestSeller = true
                });

                dbContext.SaveChanges();

                var configuration = new MapperConfiguration(cfg =>
                {
                    cfg.CreateMap<MobilePhone, MobilePhoneForListVM>();
                });
                var mapper = new Mapper(configuration);
                var mobilePhoneRepository = new MobilePhoneRepository(dbContext);
                var mobilePhoneService = new MobilePhoneService(mobilePhoneRepository, mapper);
                //Act 
                var result = await mobilePhoneService.GetMobilePhonesForList();
                //Assert
                result.Should().HaveCount(3);
                result.Should().BeOfType<List<MobilePhoneForListVM>>();
            }
        }

        [Fact]
        public async Task GetFilteredMobilePhonesTest_ShouldGetTwoObjectsWithAndroid()
        {
            var service = BuildInMemoryDBProvider();
            using (var dbContext = service.GetService<DatabaseContext>())
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
                    Hardware = new Hardware()
                    {
                        Id = 1,
                        OperationSystem = "iOS",
                        MobilePhoneId = 1
                    }
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
                    Hardware = new Hardware()
                    {
                        Id = 2,
                        OperationSystem = "Android",
                        MobilePhoneId = 4
                    }
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
                    BestSeller = true,
                    Hardware = new Hardware()
                    {
                        Id = 3,
                        OperationSystem = "Android",
                        MobilePhoneId = 24
                    }
                });

                dbContext.SaveChanges();

                var configuration = new MapperConfiguration(cfg =>
                {
                    cfg.CreateMap<MobilePhone, MobilePhoneForListVM>();
                });
                var mapper = new Mapper(configuration);
                var mobilePhoneRepository = new MobilePhoneRepository(dbContext);
                var mobilePhoneService = new MobilePhoneService(mobilePhoneRepository, mapper);
                //Act 
                var result = await mobilePhoneService.GetFilteredMobilePhones("Android");
                //Assert
                result.Should().HaveCount(2);
                result.Should().BeOfType<List<MobilePhoneForListVM>>();
            }
        }

        [Fact]
        public async Task GetFilteredMobilePhonesTest_ShouldGetOneObjectsWithIOS()
        {
            var service = BuildInMemoryDBProvider();
            using (var dbContext = service.GetService<DatabaseContext>())
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
                    Hardware = new Hardware()
                    {
                        Id = 1,
                        OperationSystem = "iOS",
                        MobilePhoneId = 1
                    }
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
                    Hardware = new Hardware()
                    {
                        Id = 2,
                        OperationSystem = "Android",
                        MobilePhoneId = 4
                    }
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
                    BestSeller = true,
                    Hardware = new Hardware()
                    {
                        Id = 3,
                        OperationSystem = "Android",
                        MobilePhoneId = 24
                    }
                });

                dbContext.SaveChanges();

                var configuration = new MapperConfiguration(cfg =>
                {
                    cfg.CreateMap<MobilePhone, MobilePhoneForListVM>();
                });
                var mapper = new Mapper(configuration);
                var mobilePhoneRepository = new MobilePhoneRepository(dbContext);
                var mobilePhoneService = new MobilePhoneService(mobilePhoneRepository, mapper);
                //Act 
                var result = await mobilePhoneService.GetFilteredMobilePhones("iOS");
                //Assert
                result.Should().HaveCount(1);
                result.Should().BeOfType<List<MobilePhoneForListVM>>();
            }
        }


        [Fact]
        public async Task GetMobilePhonesForListTest_EmptyDB()
        {
            var service = BuildInMemoryDBProvider();
            using (var dbContext = service.GetService<DatabaseContext>())
            {
                //Arrange
                var configuration = new MapperConfiguration(cfg =>
                {
                    cfg.CreateMap<MobilePhone, MobilePhoneForListVM>();
                });
                var mapper = new Mapper(configuration);
                var mobilePhoneRepository = new MobilePhoneRepository(dbContext);
                var mobilePhoneService = new MobilePhoneService(mobilePhoneRepository, mapper);
                //Act 
                var result = await mobilePhoneService.GetMobilePhonesForList();
                //Assert
                result.Should().HaveCount(0);
                result.Should().BeOfType<List<MobilePhoneForListVM>>();
            }
        }

        [Fact]
        public async Task GetMobilePhoneDetailsTest_ShouldGetAnObject()
        {
            var service = BuildInMemoryDBProvider();
            using (var dbContext = service.GetService<DatabaseContext>())
            {
                //Arrange
                var iPhone12 = new MobilePhone()
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
                };

                dbContext.Add(iPhone12);
                dbContext.SaveChanges();

                var configuration = new MapperConfiguration(cfg =>
                {
                    cfg.CreateMap<MobilePhone, MobilePhoneDetailsVM>();
                });
                var mapper = new Mapper(configuration);
                var mobilePhoneRepository = new MobilePhoneRepository(dbContext);
                var mobilePhoneService = new MobilePhoneService(mobilePhoneRepository, mapper);
                //Act 
                var result = await mobilePhoneService.GetMobilePhoneDetails(1);
                //Assert
                result.Should().BeOfType<MobilePhoneDetailsVM>();
            }
        }

        [Fact]
        public async Task GetMobilePhoneDetailsTest_EmptyDb()
        {
            var service = BuildInMemoryDBProvider();
            using (var dbContext = service.GetService<DatabaseContext>())
            {
                //Arrange
                var configuration = new MapperConfiguration(cfg =>
                {
                    cfg.CreateMap<MobilePhone, MobilePhoneDetailsVM>();
                });
                var mapper = new Mapper(configuration);
                var mobilePhoneRepository = new MobilePhoneRepository(dbContext);
                var mobilePhoneService = new MobilePhoneService(mobilePhoneRepository, mapper);
                //Act 
                var result = await mobilePhoneService.GetMobilePhoneDetails(1);
                //Assert
                result.Should().BeNull();
            }
        }

        [Fact]
        public void GetCameraVMTest()
        {
            var service = BuildInMemoryDBProvider();
            using (var dbContext = service.GetService<DatabaseContext>())
            {
                //Arrange
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
                var iPhone12 = new MobilePhone()
                {
                    Id = 1,
                    Brand = "Apple",
                    Name = "iPhone 12",
                    Price = 3000,
                    ShortDescription = "short",
                    Description = "description",
                    ActiveStatus = true,
                    QuantityInStack = QuantityStatus.Full,
                    MainImage = "/Apple/iPhone 12/Main.png",
                    FirstImage = "/Apple/iPhone 12/First.png",
                    SecondImage = "/Apple/iPhone 12/Second.png",
                    Camera = cameraiPhone12,
                    BestSeller = true
                };

                var configuration = new MapperConfiguration(cfg =>
                {
                    cfg.CreateMap<Camera, CameraVM>();
                });
                var mapper = new Mapper(configuration);
                var mobilePhoneRepository = new MobilePhoneRepository(dbContext);
                var mobilePhoneService = new MobilePhoneService(mobilePhoneRepository, mapper);
                //Act 
                var result = mobilePhoneService.GetCameraVM(iPhone12);
                //Assert
                result.Should().BeOfType<CameraVM>();
            }
        }

        [Fact]
        public void GetCameraVMTest_Null()
        {
            var service = BuildInMemoryDBProvider();
            using (var dbContext = service.GetService<DatabaseContext>())
            {
                //Arrange
                var iPhone12 = new MobilePhone()
                {
                    Id = 1,
                    Brand = "Apple",
                    Name = "iPhone 12",
                    Price = 3000,
                    ShortDescription = "short",
                    Description = "description",
                    ActiveStatus = true,
                    QuantityInStack = QuantityStatus.Full,
                    MainImage = "/Apple/iPhone 12/Main.png",
                    FirstImage = "/Apple/iPhone 12/First.png",
                    SecondImage = "/Apple/iPhone 12/Second.png",
                    BestSeller = true
                };

                var configuration = new MapperConfiguration(cfg =>
                {
                    cfg.CreateMap<Camera, CameraVM>();
                });
                var mapper = new Mapper(configuration);
                var mobilePhoneRepository = new MobilePhoneRepository(dbContext);
                var mobilePhoneService = new MobilePhoneService(mobilePhoneRepository, mapper);
                //Act 
                var result = mobilePhoneService.GetCameraVM(iPhone12);
                //Assert
                result.Should().BeNull();
            }
        }

        [Fact]
        public void GetHardwareVM()
        {
            var service = BuildInMemoryDBProvider();
            using (var dbContext = service.GetService<DatabaseContext>())
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
                var iPhone12 = new MobilePhone()
                {
                    Id = 1,
                    Brand = "Apple",
                    Name = "iPhone 12",
                    Price = 3000,
                    ShortDescription = "short",
                    Description = "description",
                    ActiveStatus = true,
                    QuantityInStack = QuantityStatus.Full,
                    MainImage = "/Apple/iPhone 12/Main.png",
                    FirstImage = "/Apple/iPhone 12/First.png",
                    SecondImage = "/Apple/iPhone 12/Second.png",
                    Hardware = hardwareiPhone12,
                    BestSeller = true
                };

                var configuration = new MapperConfiguration(cfg =>
                {
                    cfg.CreateMap<Hardware, HardwareVM>();
                });
                var mapper = new Mapper(configuration);
                var mobilePhoneRepository = new MobilePhoneRepository(dbContext);
                var mobilePhoneService = new MobilePhoneService(mobilePhoneRepository, mapper);
                //Act 
                var result = mobilePhoneService.GetHardwareVM(iPhone12);
                //Assert
                result.Should().BeOfType<HardwareVM>();
            }
        }

        [Fact]
        public void GetHardwareVM_Null()
        {
            var service = BuildInMemoryDBProvider();
            using (var dbContext = service.GetService<DatabaseContext>())
            {
                //Arrange
                var iPhone12 = new MobilePhone()
                {
                    Id = 1,
                    Brand = "Apple",
                    Name = "iPhone 12",
                    Price = 3000,
                    ShortDescription = "short",
                    Description = "description",
                    ActiveStatus = true,
                    QuantityInStack = QuantityStatus.Full,
                    MainImage = "/Apple/iPhone 12/Main.png",
                    FirstImage = "/Apple/iPhone 12/First.png",
                    SecondImage = "/Apple/iPhone 12/Second.png",
                    BestSeller = true
                };

                var configuration = new MapperConfiguration(cfg =>
                {
                    cfg.CreateMap<Hardware, HardwareVM>();
                });
                var mapper = new Mapper(configuration);
                var mobilePhoneRepository = new MobilePhoneRepository(dbContext);
                var mobilePhoneService = new MobilePhoneService(mobilePhoneRepository, mapper);
                //Act 
                var result = mobilePhoneService.GetHardwareVM(iPhone12);
                //Assert
                result.Should().BeNull();
            }
        }

        [Fact]
        public void GetMultimediaVM()
        {
            var service = BuildInMemoryDBProvider();
            using (var dbContext = service.GetService<DatabaseContext>())
            {
                //Arrange
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
                    ShortDescription = "short",
                    Description = "description",
                    ActiveStatus = true,
                    QuantityInStack = QuantityStatus.Full,
                    MainImage = "/Apple/iPhone 12/Main.png",
                    FirstImage = "/Apple/iPhone 12/First.png",
                    SecondImage = "/Apple/iPhone 12/Second.png",
                    Multimedia = multimediaApple,
                    BestSeller = true
                };

                var configuration = new MapperConfiguration(cfg =>
                {
                    cfg.CreateMap<Multimedia, MultimediaVM>();
                });
                var mapper = new Mapper(configuration);
                var mobilePhoneRepository = new MobilePhoneRepository(dbContext);
                var mobilePhoneService = new MobilePhoneService(mobilePhoneRepository, mapper);
                //Act 
                var result = mobilePhoneService.GetMultimediaVM(iPhone12);
                //Assert
                result.Should().BeOfType<MultimediaVM>();
            }
        }

        [Fact]
        public void GetMultimediaVM_Null()
        {
            var service = BuildInMemoryDBProvider();
            using (var dbContext = service.GetService<DatabaseContext>())
            {
                //Arrange
                var iPhone12 = new MobilePhone()
                {
                    Id = 1,
                    Brand = "Apple",
                    Name = "iPhone 12",
                    Price = 3000,
                    ShortDescription = "short",
                    Description = "description",
                    ActiveStatus = true,
                    QuantityInStack = QuantityStatus.Full,
                    MainImage = "/Apple/iPhone 12/Main.png",
                    FirstImage = "/Apple/iPhone 12/First.png",
                    SecondImage = "/Apple/iPhone 12/Second.png",
                    BestSeller = true
                };

                var configuration = new MapperConfiguration(cfg =>
                {
                    cfg.CreateMap<Multimedia, MultimediaVM>();
                });
                var mapper = new Mapper(configuration);
                var mobilePhoneRepository = new MobilePhoneRepository(dbContext);
                var mobilePhoneService = new MobilePhoneService(mobilePhoneRepository, mapper);
                //Act 
                var result = mobilePhoneService.GetMultimediaVM(iPhone12);
                //Assert
                result.Should().BeNull();
            }
        }

        [Fact]
        public void GetScreenVM()
        {
            var service = BuildInMemoryDBProvider();
            using (var dbContext = service.GetService<DatabaseContext>())
            {
                //Arrange
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
                var iPhone12 = new MobilePhone()
                {
                    Id = 1,
                    Brand = "Apple",
                    Name = "iPhone 12",
                    Price = 3000,
                    ShortDescription = "short",
                    Description = "description",
                    ActiveStatus = true,
                    QuantityInStack = QuantityStatus.Full,
                    MainImage = "/Apple/iPhone 12/Main.png",
                    FirstImage = "/Apple/iPhone 12/First.png",
                    SecondImage = "/Apple/iPhone 12/Second.png",
                    Screen = screeniPhone12,
                    BestSeller = true
                };

                var configuration = new MapperConfiguration(cfg =>
                {
                    cfg.CreateMap<Screen, ScreenVM>();
                });
                var mapper = new Mapper(configuration);
                var mobilePhoneRepository = new MobilePhoneRepository(dbContext);
                var mobilePhoneService = new MobilePhoneService(mobilePhoneRepository, mapper);
                //Act 
                var result = mobilePhoneService.GetScreenVM(iPhone12);
                //Assert
                result.Should().BeOfType<ScreenVM>();
            }
        }

        [Fact]
        public void GetScreenVM_Null()
        {
            var service = BuildInMemoryDBProvider();
            using (var dbContext = service.GetService<DatabaseContext>())
            {
                //Arrange
                var iPhone12 = new MobilePhone()
                {
                    Id = 1,
                    Brand = "Apple",
                    Name = "iPhone 12",
                    Price = 3000,
                    ShortDescription = "short",
                    Description = "description",
                    ActiveStatus = true,
                    QuantityInStack = QuantityStatus.Full,
                    MainImage = "/Apple/iPhone 12/Main.png",
                    FirstImage = "/Apple/iPhone 12/First.png",
                    SecondImage = "/Apple/iPhone 12/Second.png",
                    BestSeller = true
                };

                var configuration = new MapperConfiguration(cfg =>
                {
                    cfg.CreateMap<Screen, ScreenVM>();
                });
                var mapper = new Mapper(configuration);
                var mobilePhoneRepository = new MobilePhoneRepository(dbContext);
                var mobilePhoneService = new MobilePhoneService(mobilePhoneRepository, mapper);
                //Act 
                var result = mobilePhoneService.GetScreenVM(iPhone12);
                //Assert
                result.Should().BeNull();
            }
        }
    }
}
