using FluentAssertions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using OnlineShop.Web.Infrastructure;
using OnlineShop.Web.Infrastructure.Repositories;
using OnlineShop.Web.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace OnlineShop.Test.Infrastructure.Repositories
{
    public class ShoppingCartRepositoryTests
    {
        public static Mock<UserManager<TUser>> MockUserManager<TUser>(List<TUser> ls) where TUser : class
        {
            var store = new Mock<IUserStore<TUser>>();
            var mgr = new Mock<UserManager<TUser>>(store.Object, null, null, null, null, null, null, null, null);
            mgr.Object.UserValidators.Add(new UserValidator<TUser>());
            mgr.Object.PasswordValidators.Add(new PasswordValidator<TUser>());
            mgr.Setup(x => x.DeleteAsync(It.IsAny<TUser>())).ReturnsAsync(IdentityResult.Success);
            mgr.Setup(x => x.CreateAsync(It.IsAny<TUser>(), It.IsAny<string>())).ReturnsAsync(IdentityResult.Success).Callback<TUser, string>((x, y) => ls.Add(x));
            mgr.Setup(x => x.UpdateAsync(It.IsAny<TUser>())).ReturnsAsync(IdentityResult.Success);
            mgr.Setup(x => x.GetUserId(It.IsAny<ClaimsPrincipal>())).Returns("1");

            return mgr;
        }

        private IServiceProvider BuildInMemoryDBProvider()
        {
            var services = new ServiceCollection();
            services.AddDbContext<DatabaseContext>(opt =>
                opt.UseInMemoryDatabase(databaseName: $"InMemoryTest{Guid.NewGuid()}"),
                ServiceLifetime.Scoped,
                ServiceLifetime.Scoped);

            return services.BuildServiceProvider();
        }

        [Fact]
        public async Task GetShoppingCart()
        {
            var serviceProvider = BuildInMemoryDBProvider();
            using (var dbContext = serviceProvider.GetService<DatabaseContext>())
            {
                //Arrange
                var shoppingCart = new ShoppingCart();
                var user = new ApplicationUser()
                {
                    Id = "1",
                    ShoppingCart = shoppingCart
                };
                dbContext.Add(user);
                await dbContext.SaveChangesAsync();
                var mockHttpContextAccessor = new Mock<IHttpContextAccessor>();
                mockHttpContextAccessor.Object.HttpContext = new DefaultHttpContext();
                var claims = new ClaimsPrincipal();
                mockHttpContextAccessor.Setup(x => x.HttpContext.User).Returns(claims);
                List<ApplicationUser> _users = new List<ApplicationUser>();
                var userManager = MockUserManager<ApplicationUser>(_users).Object;
                var shoppingCartRepository = new ShoppingCartRepository(dbContext, userManager, mockHttpContextAccessor.Object);
                //Act
                var sc = await shoppingCartRepository.GetShoppingCart();
                //Assert
                sc.Should().BeOfType<ShoppingCart>();
                sc.Should().NotBeNull();
            }
        }

        [Fact]
        public async Task DeleteAllItems_OneItem()
        {
            var serviceProvider = BuildInMemoryDBProvider();
            using (var dbContext = serviceProvider.GetService<DatabaseContext>())
            {
                //Arrange
                var shoppingCart = new ShoppingCart()
                {
                    Id = "1",
                    Items = new List<ShoppingCartMobilePhone>()
                };
                var item = new ShoppingCartMobilePhone()
                {
                    MobilePhoneId = 1,
                    ShoppingCartId = "1",
                    Quantity = 1
                };
                shoppingCart.Items.Add(item);
                var user = new ApplicationUser()
                {
                    Id = "1",
                    ShoppingCart = shoppingCart
                };
                dbContext.Add(user);
                await dbContext.SaveChangesAsync();
                var mockHttpContextAccessor = new Mock<IHttpContextAccessor>();
                mockHttpContextAccessor.Object.HttpContext = new DefaultHttpContext();
                var claims = new ClaimsPrincipal();
                mockHttpContextAccessor.Setup(x => x.HttpContext.User).Returns(claims);
                List<ApplicationUser> _users = new List<ApplicationUser>();
                var userManager = MockUserManager<ApplicationUser>(_users).Object;
                var shoppingCartRepository = new ShoppingCartRepository(dbContext, userManager, mockHttpContextAccessor.Object);
                //Act
                await shoppingCartRepository.DeleteAllItems(shoppingCart);
                var sc = await shoppingCartRepository.GetShoppingCart();
                //Assert
                sc.Should().BeOfType<ShoppingCart>();
                sc.Should().NotBeNull();
                sc.Items.Should().HaveCount(0);
            }
        }

        [Fact]
        public async Task DeleteAllItems_TwoTheSameItems()
        {
            var serviceProvider = BuildInMemoryDBProvider();
            using (var dbContext = serviceProvider.GetService<DatabaseContext>())
            {
                //Arrange
                var shoppingCart = new ShoppingCart()
                {
                    Id = "1",
                    Items = new List<ShoppingCartMobilePhone>()
                };
                var item = new ShoppingCartMobilePhone()
                {
                    MobilePhoneId = 1,
                    ShoppingCartId = "1",
                    Quantity = 2
                };
                shoppingCart.Items.Add(item);
                var user = new ApplicationUser()
                {
                    Id = "1",
                    ShoppingCart = shoppingCart
                };
                dbContext.Add(user);
                await dbContext.SaveChangesAsync();
                var mockHttpContextAccessor = new Mock<IHttpContextAccessor>();
                mockHttpContextAccessor.Object.HttpContext = new DefaultHttpContext();
                var claims = new ClaimsPrincipal();
                mockHttpContextAccessor.Setup(x => x.HttpContext.User).Returns(claims);
                List<ApplicationUser> _users = new List<ApplicationUser>();
                var userManager = MockUserManager<ApplicationUser>(_users).Object;
                var shoppingCartRepository = new ShoppingCartRepository(dbContext, userManager, mockHttpContextAccessor.Object);
                //Act
                await shoppingCartRepository.DeleteAllItems(shoppingCart);
                var sc = await shoppingCartRepository.GetShoppingCart();
                //Assert
                sc.Should().BeOfType<ShoppingCart>();
                sc.Should().NotBeNull();
                sc.Items.Should().HaveCount(0);
            }
        }

        [Fact]
        public async Task DeleteAllItems_TwoDiffrentItems()
        {
            var serviceProvider = BuildInMemoryDBProvider();
            using (var dbContext = serviceProvider.GetService<DatabaseContext>())
            {
                //Arrange
                var shoppingCart = new ShoppingCart()
                {
                    Id = "1",
                    Items = new List<ShoppingCartMobilePhone>()
                };
                var item = new ShoppingCartMobilePhone()
                {
                    MobilePhoneId = 1,
                    ShoppingCartId = "1",
                    Quantity = 2
                };
                var item2 = new ShoppingCartMobilePhone()
                {
                    MobilePhoneId = 2,
                    ShoppingCartId = "1",
                    Quantity = 1
                };
                shoppingCart.Items.Add(item);
                shoppingCart.Items.Add(item2);
                var user = new ApplicationUser()
                {
                    Id = "1",
                    ShoppingCart = shoppingCart
                };
                dbContext.Add(user);
                await dbContext.SaveChangesAsync();
                var mockHttpContextAccessor = new Mock<IHttpContextAccessor>();
                mockHttpContextAccessor.Object.HttpContext = new DefaultHttpContext();
                var claims = new ClaimsPrincipal();
                mockHttpContextAccessor.Setup(x => x.HttpContext.User).Returns(claims);
                List<ApplicationUser> _users = new List<ApplicationUser>();
                var userManager = MockUserManager<ApplicationUser>(_users).Object;
                var shoppingCartRepository = new ShoppingCartRepository(dbContext, userManager, mockHttpContextAccessor.Object);
                //Act
                await shoppingCartRepository.DeleteAllItems(shoppingCart);
                var sc = await shoppingCartRepository.GetShoppingCart();
                //Assert
                sc.Should().BeOfType<ShoppingCart>();
                sc.Should().NotBeNull();
                sc.Items.Should().HaveCount(0);
            }
        }

        [Fact]
        public async Task DeleteAllItems_EmptyShoppingCart()
        {
            var serviceProvider = BuildInMemoryDBProvider();
            using (var dbContext = serviceProvider.GetService<DatabaseContext>())
            {
                //Arrange
                var shoppingCart = new ShoppingCart()
                {
                    Id = "1",
                    Items = new List<ShoppingCartMobilePhone>()
                };
                var user = new ApplicationUser()
                {
                    Id = "1",
                    ShoppingCart = shoppingCart
                };
                dbContext.Add(user);
                await dbContext.SaveChangesAsync();
                var mockHttpContextAccessor = new Mock<IHttpContextAccessor>();
                mockHttpContextAccessor.Object.HttpContext = new DefaultHttpContext();
                var claims = new ClaimsPrincipal();
                mockHttpContextAccessor.Setup(x => x.HttpContext.User).Returns(claims);
                List<ApplicationUser> _users = new List<ApplicationUser>();
                var userManager = MockUserManager<ApplicationUser>(_users).Object;
                var shoppingCartRepository = new ShoppingCartRepository(dbContext, userManager, mockHttpContextAccessor.Object);
                //Act
                await shoppingCartRepository.DeleteAllItems(shoppingCart);
                var sc = await shoppingCartRepository.GetShoppingCart();
                //Assert
                sc.Should().BeOfType<ShoppingCart>();
                sc.Should().NotBeNull();
                sc.Items.Should().HaveCount(0);
            }
        }

        [Fact]
        public async Task RemoveItemFromCart_OneItem()
        {
            var serviceProvider = BuildInMemoryDBProvider();
            using (var dbContext = serviceProvider.GetService<DatabaseContext>())
            {
                //Arrange
                var shoppingCart = new ShoppingCart()
                {
                    Id = "1",
                    Items = new List<ShoppingCartMobilePhone>()
                };
                var item = new ShoppingCartMobilePhone()
                {
                    MobilePhoneId = 1,
                    ShoppingCartId = "1",
                    Quantity = 1
                };
                shoppingCart.Items.Add(item);
                var user = new ApplicationUser()
                {
                    Id = "1",
                    ShoppingCart = shoppingCart
                };
                dbContext.Add(user);
                await dbContext.SaveChangesAsync();
                var mockHttpContextAccessor = new Mock<IHttpContextAccessor>();
                mockHttpContextAccessor.Object.HttpContext = new DefaultHttpContext();
                var claims = new ClaimsPrincipal();
                mockHttpContextAccessor.Setup(x => x.HttpContext.User).Returns(claims);
                List<ApplicationUser> _users = new List<ApplicationUser>();
                var userManager = MockUserManager<ApplicationUser>(_users).Object;
                var shoppingCartRepository = new ShoppingCartRepository(dbContext, userManager, mockHttpContextAccessor.Object);
                //Act
                await shoppingCartRepository.RemoveItemFromCart(shoppingCart, 1);
                var sc = await shoppingCartRepository.GetShoppingCart();
                //Assert
                sc.Should().BeOfType<ShoppingCart>();
                sc.Should().NotBeNull();
                sc.Items.Should().HaveCount(0);
            }
        }

        [Fact]
        public async Task RemoveItemFromCart_TwoTheSameItems()
        {
            var serviceProvider = BuildInMemoryDBProvider();
            using (var dbContext = serviceProvider.GetService<DatabaseContext>())
            {
                //Arrange
                var shoppingCart = new ShoppingCart()
                {
                    Id = "1",
                    Items = new List<ShoppingCartMobilePhone>()
                };
                var item = new ShoppingCartMobilePhone()
                {
                    MobilePhoneId = 1,
                    ShoppingCartId = "1",
                    Quantity = 2
                };
                shoppingCart.Items.Add(item);
                var user = new ApplicationUser()
                {
                    Id = "1",
                    ShoppingCart = shoppingCart
                };
                dbContext.Add(user);
                await dbContext.SaveChangesAsync();
                var mockHttpContextAccessor = new Mock<IHttpContextAccessor>();
                mockHttpContextAccessor.Object.HttpContext = new DefaultHttpContext();
                var claims = new ClaimsPrincipal();
                mockHttpContextAccessor.Setup(x => x.HttpContext.User).Returns(claims);
                List<ApplicationUser> _users = new List<ApplicationUser>();
                var userManager = MockUserManager<ApplicationUser>(_users).Object;
                var shoppingCartRepository = new ShoppingCartRepository(dbContext, userManager, mockHttpContextAccessor.Object);
                //Act
                await shoppingCartRepository.RemoveItemFromCart(shoppingCart, 1);
                var sc = await shoppingCartRepository.GetShoppingCart();
                //Assert
                sc.Should().BeOfType<ShoppingCart>();
                sc.Should().NotBeNull();
                sc.Items.Should().HaveCount(1);
                sc.Items.ToList()[0].Quantity.Should().Be(1);
            }
        }

        [Fact]
        public async Task RemoveItemFromCart_TwoDiffrentItemsRemoveOneOfThem()
        {
            var serviceProvider = BuildInMemoryDBProvider();
            using (var dbContext = serviceProvider.GetService<DatabaseContext>())
            {
                //Arrange
                var shoppingCart = new ShoppingCart()
                {
                    Id = "1",
                    Items = new List<ShoppingCartMobilePhone>()
                };
                var item = new ShoppingCartMobilePhone()
                {
                    MobilePhoneId = 1,
                    ShoppingCartId = "1",
                    Quantity = 1
                };
                var item2 = new ShoppingCartMobilePhone()
                {
                    MobilePhoneId = 2,
                    ShoppingCartId = "1",
                    Quantity = 1
                };
                shoppingCart.Items.Add(item);
                shoppingCart.Items.Add(item2);
                var user = new ApplicationUser()
                {
                    Id = "1",
                    ShoppingCart = shoppingCart
                };
                dbContext.Add(user);
                await dbContext.SaveChangesAsync();
                var mockHttpContextAccessor = new Mock<IHttpContextAccessor>();
                mockHttpContextAccessor.Object.HttpContext = new DefaultHttpContext();
                var claims = new ClaimsPrincipal();
                mockHttpContextAccessor.Setup(x => x.HttpContext.User).Returns(claims);
                List<ApplicationUser> _users = new List<ApplicationUser>();
                var userManager = MockUserManager<ApplicationUser>(_users).Object;
                var shoppingCartRepository = new ShoppingCartRepository(dbContext, userManager, mockHttpContextAccessor.Object);
                //Act
                await shoppingCartRepository.RemoveItemFromCart(shoppingCart, 1);
                var sc = await shoppingCartRepository.GetShoppingCart();
                //Assert
                sc.Should().BeOfType<ShoppingCart>();
                sc.Should().NotBeNull();
                sc.Items.Should().HaveCount(1);
                sc.Items.ToList()[0].MobilePhoneId.Should().Be(2);
            }
        }

        [Fact]
        public async Task RemoveItemFromCart_TwoDiffrentItemsRemoveBothOfThem()
        {
            var serviceProvider = BuildInMemoryDBProvider();
            using (var dbContext = serviceProvider.GetService<DatabaseContext>())
            {
                //Arrange
                var shoppingCart = new ShoppingCart()
                {
                    Id = "1",
                    Items = new List<ShoppingCartMobilePhone>()
                };
                var item = new ShoppingCartMobilePhone()
                {
                    MobilePhoneId = 1,
                    ShoppingCartId = "1",
                    Quantity = 1
                };
                var item2 = new ShoppingCartMobilePhone()
                {
                    MobilePhoneId = 2,
                    ShoppingCartId = "1",
                    Quantity = 1
                };
                shoppingCart.Items.Add(item);
                shoppingCart.Items.Add(item2);
                var user = new ApplicationUser()
                {
                    Id = "1",
                    ShoppingCart = shoppingCart
                };
                dbContext.Add(user);
                await dbContext.SaveChangesAsync();
                var mockHttpContextAccessor = new Mock<IHttpContextAccessor>();
                mockHttpContextAccessor.Object.HttpContext = new DefaultHttpContext();
                var claims = new ClaimsPrincipal();
                mockHttpContextAccessor.Setup(x => x.HttpContext.User).Returns(claims);
                List<ApplicationUser> _users = new List<ApplicationUser>();
                var userManager = MockUserManager<ApplicationUser>(_users).Object;
                var shoppingCartRepository = new ShoppingCartRepository(dbContext, userManager, mockHttpContextAccessor.Object);
                //Act
                await shoppingCartRepository.RemoveItemFromCart(shoppingCart, 1);
                await shoppingCartRepository.RemoveItemFromCart(shoppingCart, 2);
                var sc = await shoppingCartRepository.GetShoppingCart();
                //Assert
                sc.Should().BeOfType<ShoppingCart>();
                sc.Should().NotBeNull();
                sc.Items.Should().HaveCount(0);
            }
        }

        [Fact]
        public async Task AddItemToCart_AddItem()
        {
            var serviceProvider = BuildInMemoryDBProvider();
            using (var dbContext = serviceProvider.GetService<DatabaseContext>())
            {
                //Arrange
                var shoppingCart = new ShoppingCart()
                {
                    Id = "1",
                    Items = new List<ShoppingCartMobilePhone>()
                };
                var user = new ApplicationUser()
                {
                    Id = "1",
                    ShoppingCart = shoppingCart
                };
                var mobilePhone = new MobilePhone()
                {
                    Id = 1
                };
                dbContext.Add(mobilePhone);
                dbContext.Add(user);
                await dbContext.SaveChangesAsync();
                var mockHttpContextAccessor = new Mock<IHttpContextAccessor>();
                mockHttpContextAccessor.Object.HttpContext = new DefaultHttpContext();
                var claims = new ClaimsPrincipal();
                mockHttpContextAccessor.Setup(x => x.HttpContext.User).Returns(claims);
                List<ApplicationUser> _users = new List<ApplicationUser>();
                var userManager = MockUserManager<ApplicationUser>(_users).Object;
                var shoppingCartRepository = new ShoppingCartRepository(dbContext, userManager, mockHttpContextAccessor.Object);
                //Act
                await shoppingCartRepository.AddItemToCart(shoppingCart, mobilePhone.Id);
                var sc = await shoppingCartRepository.GetShoppingCart();
                //Assert
                sc.Should().BeOfType<ShoppingCart>();
                sc.Should().NotBeNull();
                sc.Items.Should().HaveCount(1);
                sc.Items.ToList()[0].Quantity.Should().Be(1);
            }
        }

        [Fact]
        public async Task AddItemToCart_AddExistsItem()
        {
            var serviceProvider = BuildInMemoryDBProvider();
            using (var dbContext = serviceProvider.GetService<DatabaseContext>())
            {
                //Arrange
                var shoppingCart = new ShoppingCart()
                {
                    Id = "1",
                    Items = new List<ShoppingCartMobilePhone>()
                };
                var user = new ApplicationUser()
                {
                    Id = "1",
                    ShoppingCart = shoppingCart
                };
                var mobilePhone = new MobilePhone()
                {
                    Id = 1
                };
                var item = new ShoppingCartMobilePhone()
                {
                    MobilePhoneId = 1,
                    ShoppingCartId = "1",
                    Quantity = 1
                };
                shoppingCart.Items.Add(item);
                dbContext.Add(mobilePhone);
                dbContext.Add(user);
                await dbContext.SaveChangesAsync();
                var mockHttpContextAccessor = new Mock<IHttpContextAccessor>();
                mockHttpContextAccessor.Object.HttpContext = new DefaultHttpContext();
                var claims = new ClaimsPrincipal();
                mockHttpContextAccessor.Setup(x => x.HttpContext.User).Returns(claims);
                List<ApplicationUser> _users = new List<ApplicationUser>();
                var userManager = MockUserManager<ApplicationUser>(_users).Object;
                var shoppingCartRepository = new ShoppingCartRepository(dbContext, userManager, mockHttpContextAccessor.Object);
                //Act
                await shoppingCartRepository.AddItemToCart(shoppingCart, mobilePhone.Id);
                var sc = await shoppingCartRepository.GetShoppingCart();
                //Assert
                sc.Should().BeOfType<ShoppingCart>();
                sc.Should().NotBeNull();
                sc.Items.Should().HaveCount(1);
                sc.Items.ToList()[0].Quantity.Should().Be(2);
            }
        }

        [Fact]
        public async Task AddItemToCart_AddNewItem()
        {
            var serviceProvider = BuildInMemoryDBProvider();
            using (var dbContext = serviceProvider.GetService<DatabaseContext>())
            {
                //Arrange
                var shoppingCart = new ShoppingCart()
                {
                    Id = "1",
                    Items = new List<ShoppingCartMobilePhone>()
                };
                var user = new ApplicationUser()
                {
                    Id = "1",
                    ShoppingCart = shoppingCart
                };
                var mobilePhone = new MobilePhone()
                {
                    Id = 2
                };
                var item = new ShoppingCartMobilePhone()
                {
                    MobilePhoneId = 1,
                    ShoppingCartId = "1",
                    Quantity = 1
                };
                shoppingCart.Items.Add(item);
                dbContext.Add(mobilePhone);
                dbContext.Add(user);
                await dbContext.SaveChangesAsync();
                var mockHttpContextAccessor = new Mock<IHttpContextAccessor>();
                mockHttpContextAccessor.Object.HttpContext = new DefaultHttpContext();
                var claims = new ClaimsPrincipal();
                mockHttpContextAccessor.Setup(x => x.HttpContext.User).Returns(claims);
                List<ApplicationUser> _users = new List<ApplicationUser>();
                var userManager = MockUserManager<ApplicationUser>(_users).Object;
                var shoppingCartRepository = new ShoppingCartRepository(dbContext, userManager, mockHttpContextAccessor.Object);
                //Act
                await shoppingCartRepository.AddItemToCart(shoppingCart, mobilePhone.Id);
                var sc = await shoppingCartRepository.GetShoppingCart();
                //Assert
                sc.Should().BeOfType<ShoppingCart>();
                sc.Should().NotBeNull();
                sc.Items.Should().HaveCount(2);
                sc.Items.ToList()[0].Quantity.Should().Be(1);
                sc.Items.ToList()[1].Quantity.Should().Be(1);
            }
        }

        [Fact]
        public async Task CountTotal_EmptyShoppingCart()
        {
            var serviceProvider = BuildInMemoryDBProvider();
            using (var dbContext = serviceProvider.GetService<DatabaseContext>())
            {
                //Arrange
                var shoppingCart = new ShoppingCart()
                {
                    Id = "1",
                    Items = new List<ShoppingCartMobilePhone>()
                };
                var user = new ApplicationUser()
                {
                    Id = "1",
                    ShoppingCart = shoppingCart
                };
                dbContext.Add(user);
                await dbContext.SaveChangesAsync();
                var mockHttpContextAccessor = new Mock<IHttpContextAccessor>();
                mockHttpContextAccessor.Object.HttpContext = new DefaultHttpContext();
                var claims = new ClaimsPrincipal();
                mockHttpContextAccessor.Setup(x => x.HttpContext.User).Returns(claims);
                List<ApplicationUser> _users = new List<ApplicationUser>();
                var userManager = MockUserManager<ApplicationUser>(_users).Object;
                var shoppingCartRepository = new ShoppingCartRepository(dbContext, userManager, mockHttpContextAccessor.Object);
                //Act
                var result = await shoppingCartRepository.CountTotal(shoppingCart);
                var sc = await shoppingCartRepository.GetShoppingCart();
                //Assert
                result.Should().Be(0);
                sc.Should().BeOfType<ShoppingCart>();
                sc.Should().NotBeNull();
                sc.Items.Should().HaveCount(0);
            }
        }

        [Fact]
        public async Task CountTotal_OneItem()
        {
            var serviceProvider = BuildInMemoryDBProvider();
            using (var dbContext = serviceProvider.GetService<DatabaseContext>())
            {
                //Arrange
                var shoppingCart = new ShoppingCart()
                {
                    Id = "1",
                    Items = new List<ShoppingCartMobilePhone>()
                };
                var user = new ApplicationUser()
                {
                    Id = "1",
                    ShoppingCart = shoppingCart
                };
                var mobilePhone = new MobilePhone()
                {
                    Id = 1,
                    Price = 2000
                };
                var item = new ShoppingCartMobilePhone()
                {
                    MobilePhoneId = 1,
                    ShoppingCartId = "1",
                    Quantity = 1
                };
                shoppingCart.Items.Add(item);
                dbContext.Add(mobilePhone);
                dbContext.Add(user);
                await dbContext.SaveChangesAsync();
                var mockHttpContextAccessor = new Mock<IHttpContextAccessor>();
                mockHttpContextAccessor.Object.HttpContext = new DefaultHttpContext();
                var claims = new ClaimsPrincipal();
                mockHttpContextAccessor.Setup(x => x.HttpContext.User).Returns(claims);
                List<ApplicationUser> _users = new List<ApplicationUser>();
                var userManager = MockUserManager<ApplicationUser>(_users).Object;
                var shoppingCartRepository = new ShoppingCartRepository(dbContext, userManager, mockHttpContextAccessor.Object);
                //Act
                var result = await shoppingCartRepository.CountTotal(shoppingCart);
                var sc = await shoppingCartRepository.GetShoppingCart();
                //Assert
                result.Should().Be(2000);
                sc.Should().BeOfType<ShoppingCart>();
                sc.Should().NotBeNull();
                sc.Items.Should().HaveCount(1);
                sc.Items.ToList()[0].Quantity.Should().Be(1);
            }
        }

        [Fact]
        public async Task CountTotal_TwoDiffrentItems()
        {
            var serviceProvider = BuildInMemoryDBProvider();
            using (var dbContext = serviceProvider.GetService<DatabaseContext>())
            {
                //Arrange
                var shoppingCart = new ShoppingCart()
                {
                    Id = "1",
                    Items = new List<ShoppingCartMobilePhone>()
                };
                var user = new ApplicationUser()
                {
                    Id = "1",
                    ShoppingCart = shoppingCart
                };
                var mobilePhone = new MobilePhone()
                {
                    Id = 1,
                    Price = 2000
                };
                var mobilePhone2 = new MobilePhone()
                {
                    Id = 2,
                    Price = 3000
                };
                var item = new ShoppingCartMobilePhone()
                {
                    MobilePhoneId = 1,
                    ShoppingCartId = "1",
                    Quantity = 1
                };
                var item2 = new ShoppingCartMobilePhone()
                {
                    MobilePhoneId = 2,
                    ShoppingCartId = "1",
                    Quantity = 1
                };
                shoppingCart.Items.Add(item);
                shoppingCart.Items.Add(item2);
                dbContext.Add(mobilePhone);
                dbContext.Add(mobilePhone2);
                dbContext.Add(user);
                await dbContext.SaveChangesAsync();
                var mockHttpContextAccessor = new Mock<IHttpContextAccessor>();
                mockHttpContextAccessor.Object.HttpContext = new DefaultHttpContext();
                var claims = new ClaimsPrincipal();
                mockHttpContextAccessor.Setup(x => x.HttpContext.User).Returns(claims);
                List<ApplicationUser> _users = new List<ApplicationUser>();
                var userManager = MockUserManager<ApplicationUser>(_users).Object;
                var shoppingCartRepository = new ShoppingCartRepository(dbContext, userManager, mockHttpContextAccessor.Object);
                //Act
                var result = await shoppingCartRepository.CountTotal(shoppingCart);
                var sc = await shoppingCartRepository.GetShoppingCart();
                //Assert
                result.Should().Be(5000);
                sc.Should().BeOfType<ShoppingCart>();
                sc.Should().NotBeNull();
                sc.Items.Should().HaveCount(2);
                sc.Items.ToList()[0].Quantity.Should().Be(1);
                sc.Items.ToList()[1].Quantity.Should().Be(1);
            }
        }

        [Fact]
        public async Task CountTotal_TwoDiffrentItemsAndDiffrentQuantity()
        {
            var serviceProvider = BuildInMemoryDBProvider();
            using (var dbContext = serviceProvider.GetService<DatabaseContext>())
            {
                //Arrange
                var shoppingCart = new ShoppingCart()
                {
                    Id = "1",
                    Items = new List<ShoppingCartMobilePhone>()
                };
                var user = new ApplicationUser()
                {
                    Id = "1",
                    ShoppingCart = shoppingCart
                };
                var mobilePhone = new MobilePhone()
                {
                    Id = 1,
                    Price = 2000
                };
                var mobilePhone2 = new MobilePhone()
                {
                    Id = 2,
                    Price = 3000
                };
                var item = new ShoppingCartMobilePhone()
                {
                    MobilePhoneId = 1,
                    ShoppingCartId = "1",
                    Quantity = 5
                };
                var item2 = new ShoppingCartMobilePhone()
                {
                    MobilePhoneId = 2,
                    ShoppingCartId = "1",
                    Quantity = 2
                };
                shoppingCart.Items.Add(item);
                shoppingCart.Items.Add(item2);
                dbContext.Add(mobilePhone);
                dbContext.Add(mobilePhone2);
                dbContext.Add(user);
                await dbContext.SaveChangesAsync();
                var mockHttpContextAccessor = new Mock<IHttpContextAccessor>();
                mockHttpContextAccessor.Object.HttpContext = new DefaultHttpContext();
                var claims = new ClaimsPrincipal();
                mockHttpContextAccessor.Setup(x => x.HttpContext.User).Returns(claims);
                List<ApplicationUser> _users = new List<ApplicationUser>();
                var userManager = MockUserManager<ApplicationUser>(_users).Object;
                var shoppingCartRepository = new ShoppingCartRepository(dbContext, userManager, mockHttpContextAccessor.Object);
                //Act
                var result = await shoppingCartRepository.CountTotal(shoppingCart);
                var sc = await shoppingCartRepository.GetShoppingCart();
                //Assert
                result.Should().Be(16000);
                sc.Should().BeOfType<ShoppingCart>();
                sc.Should().NotBeNull();
                sc.Items.Should().HaveCount(2);
                sc.Items.ToList()[0].Quantity.Should().Be(5);
                sc.Items.ToList()[1].Quantity.Should().Be(2);
            }
        }
    }
}
