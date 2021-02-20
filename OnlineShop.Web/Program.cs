using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Execute().Wait();
            CreateHostBuilder(args).Build().Run();
        }

        /// <summary>
        /// Method used to verify SendGrid integrity
        /// </summary>
        //static async Task Execute()
        //{
        //    var _apiKey = "Put API Key...";
        //    var client = new SendGridClient(_apiKey);
        //    var from = new EmailAddress("YouMail...", "Majk");
        //    var subject = "Sending with SendGrid is Fun";
        //    var to = new EmailAddress("YouMail...", "Majk");
        //    var plainTextContent = "and easy to do anywhere, even with C#";
        //    var htmlContent = "<strong>and easy to do anywhere, even with C#</strong>";
        //    var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
        //    var response = await client.SendEmailAsync(msg);
        //}


        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
