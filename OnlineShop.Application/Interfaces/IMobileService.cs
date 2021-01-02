using OnlineShop.Application.ViewModels;
using OnlineShop.Application.ViewModels.Mobile;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.Application.Interfaces
{
    public interface IMobileService
    {
        List<MobileForListVM> GetMobilesForList();
        MobileDetailsVM GetDetails(int mobileId);
        int AddNewMobile(NewMobileVM newMobile);
    }
}
