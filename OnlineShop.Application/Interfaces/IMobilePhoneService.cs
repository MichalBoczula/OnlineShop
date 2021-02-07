﻿using OnlineShop.Application.ViewModels;
using OnlineShop.Application.ViewModels.Mobile;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Application.Interfaces
{
    public interface IMobilePhoneService
    {
        Task<List<MobilePhoneForListVM>> GetMobilePhonesForList();
        Task<MobilePhoneDetailsVM> GetMobilePhoneDetails(int mobileId);
        Task<List<MobilePhoneForHomeVM>> GetMobilePhonesForHome();
    }
}