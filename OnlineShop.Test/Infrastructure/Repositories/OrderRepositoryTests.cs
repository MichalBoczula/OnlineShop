using FluentAssertions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using OnlineShop.Web.Application.ViewModels.ShoppingCart;
using OnlineShop.Web.Infrastructure;
using OnlineShop.Web.Infrastructure.Repositories;
using OnlineShop.Web.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace OnlineShop.Test.Infrastructure.Repositories
{
    public class OrderRepositoryTests
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
        public async Task AddOrder_Success()
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
                var shoppingCartVM = new ShoppingCartVM()
                {
                    Items = shoppingCart.Items.ToList(),
                };
                var mockHttpContextAccessor = new Mock<IHttpContextAccessor>();
                mockHttpContextAccessor.Object.HttpContext = new DefaultHttpContext();
                var claims = new ClaimsPrincipal();
                mockHttpContextAccessor.Setup(x => x.HttpContext.User).Returns(claims);
                List<ApplicationUser> _users = new List<ApplicationUser>();
                var userManager = MockUserManager<ApplicationUser>(_users).Object;
                var orderRepository = new OrderRepository(dbContext);
                //Act
                var result = await orderRepository.AddOrder(shoppingCartVM, user.Id, 1);
                //Assert
                dbContext.Orders
                    .FirstOrDefaultAsync(o => o.Id == result)
                    .Should()
                    .NotBeNull();
                result.Should().NotBe("-1");
            }
        }

        [Fact]
        public async Task AddOrder_FailEmptyShoppingCart()
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
                var shoppingCartVM = new ShoppingCartVM()
                {
                    Items = shoppingCart.Items.ToList(),
                };
                var mockHttpContextAccessor = new Mock<IHttpContextAccessor>();
                mockHttpContextAccessor.Object.HttpContext = new DefaultHttpContext();
                var claims = new ClaimsPrincipal();
                mockHttpContextAccessor.Setup(x => x.HttpContext.User).Returns(claims);
                List<ApplicationUser> _users = new List<ApplicationUser>();
                var userManager = MockUserManager<ApplicationUser>(_users).Object;
                var orderRepository = new OrderRepository(dbContext);
                //Act
                var result = await orderRepository.AddOrder(shoppingCartVM, user.Id, 1);
                //Assert
                result.Should().Be("-1");
            }
        }

        [Fact]
        public async Task GetOrders_OneOrder()
        {
            var serviceProvider = BuildInMemoryDBProvider();
            using (var dbContext = serviceProvider.GetService<DatabaseContext>())
            {
                //Arrange
                var user = new ApplicationUser()
                {
                    Id = "1",
                };
                var order = new Order()
                {
                    Id = "1",
                    Items = new List<OrderMobilePhone>(),
                    ApplicationUserId = user.Id
                };
                var item = new OrderMobilePhone()
                {
                    MobilePhoneId = 1,
                    OrderId = "1",
                    Quantity = 2
                };
                var item2 = new OrderMobilePhone()
                {
                    MobilePhoneId = 2,
                    OrderId = "1",
                    Quantity = 1
                };
                order.Items.Add(item);
                order.Items.Add(item2);
                dbContext.Add(order);
                dbContext.Add(user);
                await dbContext.SaveChangesAsync();
                var mockHttpContextAccessor = new Mock<IHttpContextAccessor>();
                mockHttpContextAccessor.Object.HttpContext = new DefaultHttpContext();
                var claims = new ClaimsPrincipal();
                mockHttpContextAccessor.Setup(x => x.HttpContext.User).Returns(claims);
                List<ApplicationUser> _users = new List<ApplicationUser>();
                var userManager = MockUserManager<ApplicationUser>(_users).Object;
                var orderRepository = new OrderRepository(dbContext);
                //Act
                var result = await orderRepository.GetOrders(user.Id).ToListAsync();
                //Assert
                result.Should().HaveCount(1);
                result[0].Items.Should().HaveCount(2);
                result[0].ApplicationUserId.Should().Be(user.Id);
            }
        }

        [Fact]
        public async Task GetOrders_ManyOrders()
        {
            var serviceProvider = BuildInMemoryDBProvider();
            using (var dbContext = serviceProvider.GetService<DatabaseContext>())
            {
                //Arrange
                var user = new ApplicationUser()
                {
                    Id = "1",
                };
                var order = new Order()
                {
                    Id = "1",
                    Items = new List<OrderMobilePhone>(),
                    ApplicationUserId = user.Id
                };
                var order2 = new Order()
                {
                    Id = "2",
                    Items = new List<OrderMobilePhone>(),
                    ApplicationUserId = user.Id
                };
                var item = new OrderMobilePhone()
                {
                    MobilePhoneId = 1,
                    OrderId = "1",
                    Quantity = 2
                };
                var item2 = new OrderMobilePhone()
                {
                    MobilePhoneId = 2,
                    OrderId = "1",
                    Quantity = 1
                };
                order.Items.Add(item);
                order2.Items.Add(item2);
                dbContext.Add(order);
                dbContext.Add(order2);
                dbContext.Add(user);
                await dbContext.SaveChangesAsync();
                var mockHttpContextAccessor = new Mock<IHttpContextAccessor>();
                mockHttpContextAccessor.Object.HttpContext = new DefaultHttpContext();
                var claims = new ClaimsPrincipal();
                mockHttpContextAccessor.Setup(x => x.HttpContext.User).Returns(claims);
                List<ApplicationUser> _users = new List<ApplicationUser>();
                var userManager = MockUserManager<ApplicationUser>(_users).Object;
                var orderRepository = new OrderRepository(dbContext);
                //Act
                var result = await orderRepository.GetOrders(user.Id).ToListAsync();
                //Assert
                result.Should().HaveCount(2);
                result[0].Items.Should().HaveCount(1);
                result[1].Items.Should().HaveCount(1);
                result[0].ApplicationUserId.Should().Be(user.Id);
                result[1].ApplicationUserId.Should().Be(user.Id);
            }
        }


        [Fact]
        public async Task GetOrders_NoOrders()
        {
            var serviceProvider = BuildInMemoryDBProvider();
            using (var dbContext = serviceProvider.GetService<DatabaseContext>())
            {
                //Arrange
                var user = new ApplicationUser()
                {
                    Id = "1",
                };
                dbContext.Add(user);
                await dbContext.SaveChangesAsync();
                var mockHttpContextAccessor = new Mock<IHttpContextAccessor>();
                mockHttpContextAccessor.Object.HttpContext = new DefaultHttpContext();
                var claims = new ClaimsPrincipal();
                mockHttpContextAccessor.Setup(x => x.HttpContext.User).Returns(claims);
                List<ApplicationUser> _users = new List<ApplicationUser>();
                var userManager = MockUserManager<ApplicationUser>(_users).Object;
                var orderRepository = new OrderRepository(dbContext);
                //Act
                var result = await orderRepository.GetOrders(user.Id).ToListAsync();
                //Assert
                result.Should().HaveCount(0);
            }
        }

        [Fact]
        public async Task GetOrderById_Success()
        {
            var serviceProvider = BuildInMemoryDBProvider();
            using (var dbContext = serviceProvider.GetService<DatabaseContext>())
            {
                //Arrange
                var user = new ApplicationUser()
                {
                    Id = "1",
                };
                var order = new Order()
                {
                    Id = "1",
                    Items = new List<OrderMobilePhone>(),
                    ApplicationUserId = user.Id
                };
                var item = new OrderMobilePhone()
                {
                    MobilePhoneId = 1,
                    OrderId = "1",
                    Quantity = 2
                };
                var item2 = new OrderMobilePhone()
                {
                    MobilePhoneId = 2,
                    OrderId = "1",
                    Quantity = 1
                };
                order.Items.Add(item);
                order.Items.Add(item2);
                dbContext.Add(order);
                await dbContext.SaveChangesAsync();
                dbContext.Add(user);
                await dbContext.SaveChangesAsync();
                var mockHttpContextAccessor = new Mock<IHttpContextAccessor>();
                mockHttpContextAccessor.Object.HttpContext = new DefaultHttpContext();
                var claims = new ClaimsPrincipal();
                mockHttpContextAccessor.Setup(x => x.HttpContext.User).Returns(claims);
                List<ApplicationUser> _users = new List<ApplicationUser>();
                var userManager = MockUserManager<ApplicationUser>(_users).Object;
                var orderRepository = new OrderRepository(dbContext);
                //Act
                var result = await dbContext.Orders.FirstOrDefaultAsync(i => i.Id == order.Id);
                //Assert
                result.Should().BeOfType<Order>();
                result.Items.Should().HaveCount(2);
                result.ApplicationUserId.Should().Be(user.Id);
            }
        }

        [Fact]
        public async Task GetOrderById_NoOrder()
        {
            var serviceProvider = BuildInMemoryDBProvider();
            using (var dbContext = serviceProvider.GetService<DatabaseContext>())
            {
                //Arrange
                var user = new ApplicationUser()
                {
                    Id = "1",
                };
                dbContext.Add(user);
                await dbContext.SaveChangesAsync();
                var mockHttpContextAccessor = new Mock<IHttpContextAccessor>();
                mockHttpContextAccessor.Object.HttpContext = new DefaultHttpContext();
                var claims = new ClaimsPrincipal();
                mockHttpContextAccessor.Setup(x => x.HttpContext.User).Returns(claims);
                List<ApplicationUser> _users = new List<ApplicationUser>();
                var userManager = MockUserManager<ApplicationUser>(_users).Object;
                var orderRepository = new OrderRepository(dbContext);
                //Act
                var result = await orderRepository.GetOrderbyId("1");
                //Assert
                result.Should().BeNull();
            }
        }

    }
}
