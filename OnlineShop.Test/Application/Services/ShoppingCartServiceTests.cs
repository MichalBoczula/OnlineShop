using FluentAssertions;
using Moq;
using OnlineShop.Web.Application.Services;
using OnlineShop.Web.Application.ViewModels.ShoppingCart;
using OnlineShop.Web.Models.Entity;
using OnlineShop.Web.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace OnlineShop.Test.Application.Services
{
    public class ShoppingCartServiceTests
    {
        [Fact]
        public async Task RetriveShopppingCartTest()
        {
            //Arrange
            var sc = new ShoppingCart()
            {
                Id = "1"
            };
            sc.Items = new List<ShoppingCartMobilePhone>();
            var mobilePhone = new MobilePhone()
            {
                Id = 1
            };
            var item = new ShoppingCartMobilePhone()
            {
                MobilePhoneId = 1,
                MobilePhoneRef = mobilePhone
            };
            sc.Items.Add(item);
            var repoMock = new Mock<IShoppingCartRepository>();
            repoMock.Setup(sc => sc.GetShoppingCart()).ReturnsAsync(sc);
            var service = new ShoppingCartService(repoMock.Object);
            //Act
            var result = await service.RetriveShopppingCart();
            //Assert
            result.Should().NotBeNull();
            result.Should().BeOfType<ShoppingCartVM>();
            result.Items.Should().HaveCount(1);
        }
    }
}
