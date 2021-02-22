using OnlineShop.Web.Models.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Web.Application.ViewModels.Mobile
{
    public class MobilePhoneAndFiltersVM
    {
        public Filters Filters { get; set; }
        public List<MobilePhoneForListVM> MobilePhoneVMs { get; set; }
    }
}
