using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Web.Controllers
{
    public class ItemController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public IActionResult List()
        {
            return View();
        }
    }
}
