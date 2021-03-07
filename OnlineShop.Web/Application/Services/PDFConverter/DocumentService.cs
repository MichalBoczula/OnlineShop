using DinkToPdf;
using DinkToPdf.Contracts;
using OnlineShop.Web.Application.Interfaces;
using OnlineShop.Web.Application.ViewModels.Order;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Web.Application.Services.PDFConverter
{
    /// <summary>
    ///  download and install Microsoft Visual C ++ Redistributable for Visual Studio 2015, 2017, and 2019 
    ///  then add 3 files from https://github.com/rdvojmoc/DinkToPdf/tree/master/v0.12.4/64%20bit to project
    ///  More information in https://github.com/sendgrid/sendgrid-csharp/issues/831
    ///  Add library to csproject look on code between <!--*--> in csproj
    /// </summary>
    public class DocumentService : IDocumentService
    {

        private readonly IConverter _converter;

        public DocumentService(IConverter converter)
        {
            _converter = converter;
        }

        public string GetHTMLString(OrderDetailsVM order)
        {
            var sb = new StringBuilder();

            sb.Append($@" <!DOCTYPE html>
                    <html>
                    <head>
                        <meta charset='utf-8' />
                        <link rel='stylesheet' href='./PDFStyles.css' />
                        <title></title>
                    </head>
                    <body>
                        <div class='SalesManData'>
                            <h3>John Smith</h3>
                            <p>1234 Wroclaw</p>
                            <p>Long Street 12/34</p>
                        </div>
                        <table class='CustomerDataTable'>
                            <thead>
                                <tr>
                                    <th>Bill To</th>
                                    <th>Ship To</th>
                                </tr>
                            </thead>
                            <tbody>
                                <tr>
                                    <td>CustomerName</td>
                                    <td>{order.ShippingAddressRef.PostalCode} {order.ShippingAddressRef.City} </td>
                                </tr> ");

            if (string.IsNullOrEmpty(order.ShippingAddressRef.FlatNumber))
            {
                sb.Append($@"
                                <tr>
                                    <td>CustomerSurname</td>
                                    <td>{order.ShippingAddressRef.Street} {order.ShippingAddressRef.HouseNumber}</td>
                                </tr>");
            }
            else
            {
                sb.Append($@"
                                <tr>
                                    <td>CustomerSurname</td>
                                    <td>{order.ShippingAddressRef.Street} {order.ShippingAddressRef.HouseNumber}/{order.ShippingAddressRef.FlatNumber}</td>
                                </tr>");
            }

            sb.Append($@"
                            </tbody>
                        </table>
                        <table class='table'>
                            <thead class='Head'>
                                <tr>
                                    <th>
                                        Brand
                                    </th>
                                    <th>
                                        Product
                                    </th>
                                    <th>
                                        Quntity
                                    </th>
                                    <th>
                                        Unit Price
                                    </th>
                                    <th>
                                        Total
                                    </th>
                                </tr>
                            </thead>
                    <tbody class='Body'>
                        ");


            foreach (var item in order.Items)
            {
                sb.Append($@"
                        <tr> 
                            <td>{item.MobilePhoneRef.Brand}</td>
                            <td>{item.MobilePhoneRef.Name}</td>
                            <td>{item.Quantity}</td>
                            <td>{item.MobilePhoneRef.Price}</td>
                            <td>{item.MobilePhoneRef.Price * item.Quantity}</td>
                        </tr>"
                  );
            }
            sb.Append($@"
                    </tbody>
                    <tfoot>
                        <tr class='Foot'>
                            <td colspan='5'>
                                <p class='total'>
                                    Total Price: {order.Total}
                                </p>
                            </td>
                        </tr>
                    </tfoot>
                </table>
                <div>
                    <h3>Terms & Conditions</h3>
                    <p>Payment in due within 15 days</p>
                    <br />
                    <p>Name of Bank: PolBank</p>
                    <p>Account Number: 20 1111 2222 3333 4444 5555 66666</p>
                </div>
            </body>
            </html>");
            return sb.ToString();
        }

# nullable enable
        public void CreatePDF(OrderDetailsVM order, string? path)
        {
            var globalSettings = new GlobalSettings
            {
                ColorMode = ColorMode.Color,
                Orientation = Orientation.Portrait,
                PaperSize = PaperKind.A4,
                Margins = new MarginSettings { Top = 10 },
                DocumentTitle = "PDF Report",
                Out = @"A:\Programowanie\C#\Kurs\Apps\OnlineShop\OnlineShop.Web\Application\Services\PDFConverter\PDF\Invoice.pdf"
            };

            path ??= Path.Combine(Directory.GetCurrentDirectory(), @"Application\Services\PDFConverter\Assets", "PDFStyles.css");
            var objectSettings = new ObjectSettings
            {
                PagesCount = true,
                HtmlContent = GetHTMLString(order),
                WebSettings = { DefaultEncoding = "utf-8", UserStyleSheet = path },
                HeaderSettings = { FontName = "Arial", FontSize = 9, Right = "Page [page] of [toPage]", Line = true },
                FooterSettings = { FontName = "Arial", FontSize = 9, Line = true, Center = "Report Footer" }
            };
            var pdf = new HtmlToPdfDocument()
            {
                GlobalSettings = globalSettings,
                Objects = { objectSettings }
            };
            _converter.Convert(pdf);
        }

        public byte[] CreatePDFStream(OrderDetailsVM order, string? path)
        {
            var globalSettings = new GlobalSettings
            {
                ColorMode = ColorMode.Color,
                Orientation = Orientation.Portrait,
                PaperSize = PaperKind.A4,
                Margins = new MarginSettings { Top = 10 },
                DocumentTitle = "PDF Report",
            };

            path ??= Path.Combine(Directory.GetCurrentDirectory(), @"Application\Services\PDFConverter\Assets", "PDFStyles.css");
            var objectSettings = new ObjectSettings
            {
                PagesCount = true,
                HtmlContent = GetHTMLString(order),
                WebSettings = { DefaultEncoding = "utf-8", UserStyleSheet = path },
                HeaderSettings = { FontName = "Arial", FontSize = 9, Right = "Page [page] of [toPage]", Line = true },
                FooterSettings = { FontName = "Arial", FontSize = 9, Line = true, Center = "Report Footer" }
            };

            var pdf = new HtmlToPdfDocument()
            {
                GlobalSettings = globalSettings,
                Objects = { objectSettings }
            };
            var file = _converter.Convert(pdf);
            return file;
        }
# nullable disable

    }
}
