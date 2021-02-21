using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OnlineShop.Web.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Web.Controllers
{
    public class MobilePhoneController : Controller
    {
        private readonly ILogger<MobilePhoneController> _logger;
        private readonly IMobilePhoneService _mobileService;

        public MobilePhoneController(ILogger<MobilePhoneController> logger,
                                     IMobilePhoneService mobileService)
        {
            _logger = logger;
            _mobileService = mobileService;
        }

        public async Task<IActionResult> Index()
        {
            var model = await _mobileService.GetMobilePhonesForList();
            return View(model);
        }

        public async Task<IActionResult> Details(int mobilePhoneId)
        {
            var model = await _mobileService.GetMobilePhoneDetails(mobilePhoneId);
            return View(model);
        }
    }
}
