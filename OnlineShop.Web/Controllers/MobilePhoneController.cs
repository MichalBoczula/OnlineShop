using Microsoft.AspNetCore.Mvc;
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
        private readonly MobilePhoneRepository<MobilePhone> _mobilePhoneRepository;

        public MobilePhoneController(MobilePhoneRepository<MobilePhone> mobilePhoneRepository)
        {
            _mobilePhoneRepository = mobilePhoneRepository;
        }


    }
}
