using Microsoft.AspNetCore.Mvc;
using OnlineShop.Web.Models.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Web.Components
{
    public class FiltersForm : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var VM = new Filters();
            return View(VM);
        }
    }
}
