using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OnlineShop.Application.Interfaces;
using OnlineShop.Domain.Model;
using OnlineShop.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Web.Controllers
{
    public class MobilePhoneController : Controller
    {
        private readonly ILogger<MobilePhoneController> _logger;
        private readonly IMobileService _mobileService;

        public MobilePhoneController(ILogger<MobilePhoneController> logger, IMobileService mobileService)
        {
            _logger = logger;
            _mobileService = mobileService;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
