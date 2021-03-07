using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Configuration;
using OnlineShop.Web.Application.Interfaces;
using OnlineShop.Web.Application.ViewModels.Order;
using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Web.Application.Services.EmailSender
{
    public class EmailSender : IEmailSenderExtension
    {
        private readonly string _apiKey;
        private readonly string _from;
        private readonly string _email;
        private readonly IDocumentService _documentService;

        public EmailSender(IConfiguration options, IDocumentService documentService)
        {
            _apiKey = options["SendGrid:ApiKey"];
            _from = options["SendGrid:User"];
            _email = options["SendGrid:SenderEmail"];
            _documentService = documentService;
        }

        public async Task SendEmailAsync(string email, string subject, string message)
        {
            var client = new SendGridClient(_apiKey);
            var msg = new SendGridMessage()
            {
                From = new EmailAddress(_email, _from),
                Subject = subject,
                PlainTextContent = message,
                HtmlContent = message
            };
            msg.AddTo(new EmailAddress(email));

            msg.SetClickTracking(false, false);
            msg.SetOpenTracking(false);
            msg.SetGoogleAnalytics(false);
            msg.SetSubscriptionTracking(false);

            await client.SendEmailAsync(msg);
        }

        public async Task SendEmailAsyncWithAttachment(string email, string subject, string message, OrderDetailsVM order)
        {
            var client = new SendGridClient(_apiKey);
            var msg = new SendGridMessage()
            {
                From = new EmailAddress(_email, _from),
                Subject = subject,
                PlainTextContent = message,
                HtmlContent = message
            };
            msg.AddTo(new EmailAddress(email));

            msg.SetClickTracking(false, false);
            msg.SetOpenTracking(false);
            msg.SetGoogleAnalytics(false);
            msg.SetSubscriptionTracking(false);

            var path = @"A:\Programowanie\C#\Kurs\Apps\OnlineShop\OnlineShop.Web\Application\Services\PDFConverter\PDF\Invoice.pdf";
            _documentService.CreatePDF(order, null);

            using (var fileStream = File.OpenRead(path))
            {
                await msg.AddAttachmentAsync("Invoice.pdf", fileStream);
                var response = await client.SendEmailAsync(msg);
            }
            File.Delete(path);
        }
    }
}
