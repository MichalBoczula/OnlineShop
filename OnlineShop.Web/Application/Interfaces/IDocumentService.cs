using OnlineShop.Web.Application.ViewModels.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Web.Application.Interfaces
{
    public interface IDocumentService
    {
        string GetHTMLString(OrderVM order);
# nullable enable
        void CreatePDF(OrderVM order, string? path);
# nullable disable
    }
}
