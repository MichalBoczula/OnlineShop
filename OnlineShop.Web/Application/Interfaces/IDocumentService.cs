using OnlineShop.Web.Application.ViewModels.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Web.Application.Interfaces
{
    public interface IDocumentService
    {
        string GetHTMLString(OrderDetailsVM order);
# nullable enable
        void CreatePDF(OrderDetailsVM order, string? path);
        byte[] CreatePDFStream(OrderDetailsVM order, string? path);
#nullable disable
    }
}
