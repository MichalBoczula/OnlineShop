using AutoMapper;
using AutoMapper.QueryableExtensions;
using OnlineShop.Application.Interfaces;
using OnlineShop.Application.ViewModels;
using OnlineShop.Application.ViewModels.Camera;
using OnlineShop.Application.ViewModels.Hardware;
using OnlineShop.Application.ViewModels.Mobile;
using OnlineShop.Application.ViewModels.Screen;
using OnlineShop.Domain.Interfaces;
using OnlineShop.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnlineShop.Application.Services
{
    public class MobileService : IMobileService
    {
        private readonly IMobileRepository _repository;
        private readonly IMapper _mapper;

        public List<MobileForListVM> GetMobilesForList()
        {
            var mobilesForListVm = _repository.GetAllActiveMobiles()
                .ProjectTo<MobileForListVM>(_mapper.ConfigurationProvider).ToList();
            return mobilesForListVm;
        }

        public MobileDetailsVM GetDetails(int mobilePhonesId)
        {
            var mobile = _repository.GetMobileById(mobilePhonesId);
            var mobileDetailsVM = _mapper.Map<MobileDetailsVM>(mobile);
            mobileDetailsVM.Camera = GetCameraVM(mobile);
            mobileDetailsVM.Hardware = GetHardwareVM(mobile);
            mobileDetailsVM.Screen = GetScreenVM(mobile);
            return mobileDetailsVM;
        }

        public int AddNewMobile(NewMobileVM newMobile)
        {
            throw new NotImplementedException();
        }


        private ScreenVM GetScreenVM(MobilePhone mobile)
        {
            return _mapper.Map<ScreenVM>(mobile.Screen);
        }

        private HardwareVM GetHardwareVM(MobilePhone mobile)
        {
            return _mapper.Map<HardwareVM>(mobile.Hardware);
        }

        private CameraVM GetCameraVM(MobilePhone mobile)
        {
            return _mapper.Map<CameraVM>(mobile.Camera);
        }
    }
}
