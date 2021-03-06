using DinkToPdf;
using DinkToPdf.Contracts;
using FluentAssertions;
using Microsoft.Extensions.DependencyInjection;
using OnlineShop.Web.Application.Services.PDFConverter;
using OnlineShop.Web.Application.ViewModels.Order;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Xunit;

namespace OnlineShop.Test.Infrastructure.IOHelper.PDFConverter
{
    public class DocumentServiceTests
    {
        private IServiceProvider InjectServices()
        {
            var services = new ServiceCollection();
            services.AddSingleton(typeof(IConverter), new SynchronizedConverter(new PdfTools()));
            return services.BuildServiceProvider();
        }

        [Fact]
        public void CreatePDFTest()
        {
            //Arrange
            var converter = InjectServices().GetService<IConverter>();
            var documentService = new DocumentService(converter);
            var orderVm = new OrderVM()
            {
                ShoppingCartVM = new Web.Application.ViewModels.ShoppingCart.ShoppingCartVM()
                {
                    Items = new List<Web.Models.Entity.ShoppingCartMobilePhone>()
                    {
                        new Web.Models.Entity.ShoppingCartMobilePhone()
                        {
                            Quantity = 1,
                            MobilePhoneRef = new Web.Models.Entity.MobilePhone()
                            {
                                Brand = "Apple",
                                Name = "Iphone12",
                                Price = 3000
                            }
                        }
                    }
                }
            };
            //Act
            documentService.CreatePDF(orderVm);
            var pathToFile = @"A:\Programowanie\C#\Kurs\Apps\OnlineShop\OnlineShop.Web\Application\Services\PDFConverter\PDF\Invoice.pdf";
            //Assert
            File.Exists(pathToFile).Should().BeTrue();
            //CleanUp
            File.Delete(pathToFile);
        }
    }
}
