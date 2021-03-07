using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OnlineShop.Web.Application.Interfaces;
using OnlineShop.Web.Application.ViewModels.Mobile;
using OnlineShop.Web.Application.ViewModels.Order;
using OnlineShop.Web.Models.Filters;
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
        private readonly IDocumentService _documentService;

        public MobilePhoneController(ILogger<MobilePhoneController> logger,
                                     IMobilePhoneService mobileService,
                                     IDocumentService documentService)
        {
            _logger = logger;
            _mobileService = mobileService;
            _documentService = documentService;
        }

        public async Task<IActionResult> Index()
        {
            var orderVm = new OrderVM()
            {
                ShoppingCartVM = new Web.Application.ViewModels.ShoppingCart.ShoppingCartVM()
                {
                    Items = new List<Web.Models.Entity.ShoppingCartMobilePhone>()
                    {
                        new Web.Models.Entity.ShoppingCartMobilePhone()
                        {
                            Quantity = 1,
                            MobilePhoneRef = new Web.Models.Entity.MobilePhone()
                            {
                                Brand = "Apple",
                                Name = "Iphone12",
                                Price = 3000
                            }
                        }
                    }
                }
            };
            _documentService.CreatePDF(orderVm,  null);
            var model = await _mobileService.GetMobilePhonesForList();
            var VM = new MobilePhoneAndFiltersVM()
            {
                Filters = new Filters(),
                MobilePhoneVMs = model
            };
            return View(VM);
        }

        [HttpPost]
        public async Task<IActionResult> Index(Filters filters)
        {
            var model = await _mobileService.GetFilteredMobilePhones(filters);
            var VM = new MobilePhoneAndFiltersVM()
            {
                Filters = filters,
                MobilePhoneVMs = model
            };
            return View(VM);
        }

        public async Task<IActionResult> Details(int mobilePhoneId)
        {
            var model = await _mobileService.GetMobilePhoneDetails(mobilePhoneId);
            return View(model);
        }
    }
}
