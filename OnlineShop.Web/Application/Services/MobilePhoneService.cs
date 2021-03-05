using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using OnlineShop.Web.Application.Interfaces;
using OnlineShop.Web.Application.ViewModels.Camera;
using OnlineShop.Web.Application.ViewModels.Hardware;
using OnlineShop.Web.Application.ViewModels.Mobile;
using OnlineShop.Web.Application.ViewModels.Multimedia;
using OnlineShop.Web.Application.ViewModels.Screen;
using OnlineShop.Web.Models.Entity;
using OnlineShop.Web.Models.Filters;
using OnlineShop.Web.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OnlineShop.Web.Application.Services
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

        public async Task<List<MobilePhoneForListVM>> GetFilteredMobilePhones(Filters filters)
        {
            var mobilesForListVm = await _repository.RetriveFilteredMobilePhones(filters)
              .ProjectTo<MobilePhoneForListVM>(_mapper.ConfigurationProvider)
              .ToListAsync();
            if (filters.OrderBy.HasValue)
            {
                if (filters.OrderBy.Value)
                {
                    mobilesForListVm = mobilesForListVm.OrderBy(m => m.Price).ThenBy(m => m.Name).ToList();
                }
                else
                {
                    mobilesForListVm = mobilesForListVm.OrderByDescending(m => m.Price).ThenBy(m => m.Name).ToList();
                }
            }
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
