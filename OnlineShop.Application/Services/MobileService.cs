using OnlineShop.Application.Interfaces;
using OnlineShop.Application.ViewModels;
using OnlineShop.Application.ViewModels.Mobile;
using OnlineShop.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.Application.Services
{
    public class MobileService : IMobileService
    {
        private readonly IMobileRepository _repository;

        public List<MobileForListVM> GetMobilesForList()
        {
            var mobiles = _repository.GetAllActiveMobiles();
            var mobilesForListVm = new List<MobileForListVM>();
            foreach(var mobile in mobiles)
            {
                var mobileVM = new MobileForListVM()
                {
                    Id = mobile.Id,
                    Name = mobile.Name,
                    Price = mobile.Price,
                    MainImage = mobile.MainImage,
                    ShortDescription = mobile.ShortDescription
                };
                mobilesForListVm.Add(mobileVM);
            }
            return mobilesForListVm;
        }

        public MobileDetailsVM GetDetails(int mobilePhonesId)
        {
            var mobile = _repository.GetMobileById(mobilePhonesId);
            var mobileDetailsVM = new MobileDetailsVM()
            { 
                Id = mobile.Id,
                Name = mobile.Name,
                Price = mobile.Price,
                MainImage = mobile.MainImage,
                FirstImage = mobile.FirstImage,
                SecondImage = mobile.SecondImage,
                ThirdImage = mobile.ThirdImage,
                Description = mobile.Description,
                Camera = mobile.Camera,
                Screen = mobile.Screen,
                Hardware = mobile.Hardware
            };
            return mobileDetailsVM;
        }
        public int AddNewMobile(NewMobileVM newMobile)
        {
            throw new NotImplementedException();
        }
    }
}
