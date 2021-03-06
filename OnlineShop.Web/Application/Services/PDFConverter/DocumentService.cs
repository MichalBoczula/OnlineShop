using DinkToPdf;
using DinkToPdf.Contracts;
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
    public class DocumentService
    {

        private readonly IConverter _converter;

        public DocumentService(IConverter converter)
        {
            _converter = converter;
        }

        public string GetHTMLString(OrderVM order)
        {
            var sb = new StringBuilder();
            sb.Append(@"
                        <html>
                            <head>
                            </head>
                            <body>
                                <div class='header'><h1>This is the generated PDF report!!!</h1></div>
                                <table align='center'>
                                    <tr>
                                        <th>Brand</th>
                                        <th>Name</th>
                                        <th>Quantity</th>
                                        <th>Price</th>
                                        <th>Total</th>
                                    </tr>");

            sb.AppendFormat($@"<tr>
                                    <td>{order.ShoppingCartVM.Items[0].MobilePhoneRef.Brand}</td>
                                    <td>{order.ShoppingCartVM.Items[0].MobilePhoneRef.Name}</td>
                                    <td>{order.ShoppingCartVM.Items[0].Quantity}</td>
                                    <td>{order.ShoppingCartVM.Items[0].MobilePhoneRef.Price}</td>
                                    <td>{order.ShoppingCartVM.Items[0].MobilePhoneRef.Price * order.ShoppingCartVM.Items[0].Quantity}</td>
                                  </tr>");
            sb.Append(@"
                                </table>
                            </body>
                        </html>");
            return sb.ToString();
        }

        public void CreatePDF(OrderVM order)
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
            var objectSettings = new ObjectSettings
            {
                PagesCount = true,
                HtmlContent = GetHTMLString(order),
                WebSettings = { DefaultEncoding = "utf-8", UserStyleSheet = Path.Combine(Directory.GetCurrentDirectory(), "Assets", "PDFStyles.css") },
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
    }
}
