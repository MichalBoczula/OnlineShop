using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using OnlineShop.Application.Interfaces;
using OnlineShop.Application.ViewModels;
using OnlineShop.Application.ViewModels.Camera;
using OnlineShop.Application.ViewModels.Hardware;
using OnlineShop.Application.ViewModels.Mobile;
using OnlineShop.Application.ViewModels.Multimedia;
using OnlineShop.Application.ViewModels.Screen;
using OnlineShop.Domain.Interfaces;
using OnlineShop.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OnlineShop.Application.Services
{
    public class MobileService : IMobileService
    {
        private readonly IMobileRepository _repository;
        private readonly IMapper _mapper;

        public MobileService(IMobileRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<MobileForListVM>> GetMobilesForList()
        {
            var mobilesForListVm = await _repository.GetAllActiveMobiles()
              .ProjectTo<MobileForListVM>(_mapper.ConfigurationProvider)
              .ToListAsync();
            return mobilesForListVm;
        }

        public async Task<MobileDetailsVM> GetDetails(int mobilePhonesId)
        {
            var mobile = await _repository.GetMobileById(mobilePhonesId);
            var mobileDetailsVM = _mapper.Map<MobileDetailsVM>(mobile);
            mobileDetailsVM.Camera = GetCameraVM(mobile);
            mobileDetailsVM.Hardware = GetHardwareVM(mobile);
            mobileDetailsVM.Screen = GetScreenVM(mobile);
            mobileDetailsVM.Multimedia = GetMultimediaVM(mobile);
            return mobileDetailsVM;
        }
        public async Task<List<MobilePhoneForHomeVM>> GetMobilesForHome()
        {
            var mobilePhones = await _repository.GetBestSellers()
                                          .ProjectTo<MobilePhoneForHomeVM>(_mapper.ConfigurationProvider)
                                          .ToListAsync();
            return mobilePhones;
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

        private MultimediaVM GetMultimediaVM(MobilePhone mobile)
        {
            return _mapper.Map<MultimediaVM>(mobile.Multimedia);
        }

    }
}
