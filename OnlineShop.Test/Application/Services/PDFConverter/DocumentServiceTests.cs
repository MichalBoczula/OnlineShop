using DinkToPdf;
using DinkToPdf.Contracts;
using FluentAssertions;
using Microsoft.Extensions.DependencyInjection;
using OnlineShop.Web.Application.Services.PDFConverter;
using OnlineShop.Web.Application.ViewModels.Mobile;
using OnlineShop.Web.Application.ViewModels.Order;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Xunit;

namespace OnlineShop.Test.Application.Services.PDFConverter
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
            var orderVm = new OrderDetailsVM()
            {
                ShippingAddressRef = new Web.Application.ViewModels.ShippingAddress.ShippingAddressVM()
                {
                    City = "Wrolaw",
                    PostalCode = "59-999",
                    Street = "Long Street",
                    HouseNumber = "54"
                },
                Total = 6000,
                Items = new List<OrderMobilePhoneVM>()
                {
                    new OrderMobilePhoneVM()
                    {
                        Quantity = 1,
                        MobilePhoneRef= new MobilePhoneForOrderSummaryVM()
                        {
                            Name = "Iphone12",
                            Price = 3000
                        }
                    },
                    new OrderMobilePhoneVM()
                    {
                        Quantity = 1,
                        MobilePhoneRef= new MobilePhoneForOrderSummaryVM()
                        {
                            Name = "Iphone11",
                            Price = 2000
                        }
                    },
                    new OrderMobilePhoneVM()
                    {
                        Quantity = 1,
                        MobilePhoneRef= new MobilePhoneForOrderSummaryVM()
                        {
                            Name = "Iphone10",
                            Price = 1000
                        }
                    },
                }
            };
            var css = @"A:\Programowanie\C#\Kurs\Apps\OnlineShop\OnlineShop.Web\Application\Services\PDFConverter\Assets\PDFStyles.css";
            //Act
            documentService.CreatePDF(orderVm, css);
            var pathToFile = @"A:\Programowanie\C#\Kurs\Apps\OnlineShop\OnlineShop.Web\Application\Services\PDFConverter\PDF\Invoice.pdf";
            //Assert
            File.Exists(pathToFile).Should().BeTrue();
            //CleanUp
            File.Delete(pathToFile);
        }
    }
}
