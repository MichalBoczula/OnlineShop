using OnlineShop.Web.Application.ViewModels.Mobile;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Web.Application.Interfaces
{
    public interface IMobilePhoneService
    {
        Task<List<MobilePhoneForListVM>> GetMobilePhonesForList();
        Task<MobilePhoneDetailsVM> GetMobilePhoneDetails(int mobileId);
        Task<List<MobilePhoneForListVM>> GetFilteredMobilePhones(string filter);
        Task<List<MobilePhoneForHomeVM>> GetMobilePhonesForHome();
    }
}
