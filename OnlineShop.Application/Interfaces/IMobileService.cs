using OnlineShop.Application.ViewModels;
using OnlineShop.Application.ViewModels.Mobile;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Application.Interfaces
{
    public interface IMobileService
    {
        Task<List<MobileForListVM>> GetMobilesForList();
        Task<MobileDetailsVM> GetDetails(int mobileId);
        int AddNewMobile(NewMobileVM newMobile);
        Task<List<MobilePhoneForHomeVM>> GetMobilesForHome();
    }
}
