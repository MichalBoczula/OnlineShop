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
                var mockHttpContextAccessor = new Mock<IHttpContextAccessor>();
                mockHttpContextAccessor.Object.HttpContext = new DefaultHttpContext();
                var claims = new ClaimsPrincipal();
                mockHttpContextAccessor.Setup(x => x.HttpContext.User).Returns(claims);
                List<ApplicationUser> _users = new List<ApplicationUser>();
                var userManager = MockUserManager<ApplicationUser>(_users).Object;
                var orderRepository = new OrderRepository(dbContext);
                //Act
                var result = await orderRepository.AddOrder(shoppingCart, 1);
                //Assert
                dbContext.ApplicationUserOrders
                    .FirstOrDefaultAsync(i => i.ApplicationUserId == "1" && i.OrderId == result)
                    .Should()
                    .NotBeNull();
                dbContext.Orders
                    .FirstOrDefaultAsync(o => o.Id == result)
                    .Should()
                    .NotBeNull();
                result.Should().BeGreaterThan(0);
            }
        }

        [Fact]
        public async Task AddOrder_Fail()
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
                var orderRepository = new OrderRepository(dbContext);
                //Act
                var result = await orderRepository.AddOrder(shoppingCart, 1);
                //Assert
                result.Should().Be(-1);
            }
        }
    }
}
