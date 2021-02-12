using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OnlineShop.Web.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMobilePhoneService _mobileService;

        public HomeController(ILogger<HomeController> logger,
                              IMobilePhoneService mobileService = null)
        {
            _logger = logger;
            _mobileService = mobileService;
        }

        public async Task<IActionResult> Index()
        {
            var model = await _mobileService.GetMobilePhonesForHome();
            return View(model);
        }

    }
}
