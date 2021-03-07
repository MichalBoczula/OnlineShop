using Microsoft.AspNetCore.Identity.UI.Services;
using OnlineShop.Web.Application.ViewModels.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Web.Application.Interfaces
{
    public interface IEmailSenderExtension : IEmailSender
    {
        Task SendEmailAsyncWithAttachment(string email, string subject, string message, OrderDetailsVM order);
    }
}
