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
    public class MobilePhoneService : IMobilePhoneService
    {
        private readonly IMobilePhoneRepository _repository;
        private readonly IMapper _mapper;

        public MobilePhoneService(IMobilePhoneRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<MobilePhoneForListVM>> GetMobilePhonesForList()
        {
            var mobilesForListVm = await _repository.GetAllActiveMobilePhones()
              .ProjectTo<MobilePhoneForListVM>(_mapper.ConfigurationProvider)
              .ToListAsync();
            return mobilesForListVm;
        }

        public async Task<MobilePhoneDetailsVM> GetMobilePhoneDetails(int mobilePhonesId)
        {
            var mobile = await _repository.GetMobilePhoneById(mobilePhonesId);
            var mobileDetailsVM = _mapper.Map<MobilePhoneDetailsVM>(mobile);
            if (mobile != null)
            {
                mobileDetailsVM.Camera = GetCameraVM(mobile);
                mobileDetailsVM.Hardware = GetHardwareVM(mobile);
                mobileDetailsVM.Screen = GetScreenVM(mobile);
                mobileDetailsVM.Multimedia = GetMultimediaVM(mobile);
            }
            return mobileDetailsVM;
        }
        public async Task<List<MobilePhoneForHomeVM>> GetMobilePhonesForHome()
        {
            var mobilePhones = await _repository.GetBestSellers()
                                          .ProjectTo<MobilePhoneForHomeVM>(_mapper.ConfigurationProvider)
                                          .ToListAsync();
            return mobilePhones;
        }

        public ScreenVM GetScreenVM(MobilePhone mobile) => _mapper.Map<ScreenVM>(mobile.Screen);

        public HardwareVM GetHardwareVM(MobilePhone mobile) => _mapper.Map<HardwareVM>(mobile.Hardware);

        public CameraVM GetCameraVM(MobilePhone mobile) => _mapper.Map<CameraVM>(mobile.Camera);
       
        public MultimediaVM GetMultimediaVM(MobilePhone mobile) => _mapper.Map<MultimediaVM>(mobile.Multimedia);

    }
}
