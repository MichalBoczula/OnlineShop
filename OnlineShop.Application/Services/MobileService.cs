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
            foreach (var mobile in mobiles)
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
            CameraVM cameraVm = GetCameraVM(mobile);
            HardwareVM hardwareVm = GetHardwareVM(mobile);
            ScreenVM screenVm = GetScreenVM(mobile);
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
                Camera = cameraVm,
                Hardware = hardwareVm,
                Screen = screenVm
            };
            return mobileDetailsVM;
        }

        public int AddNewMobile(NewMobileVM newMobile)
        {
            throw new NotImplementedException();
        }


        private ScreenVM GetScreenVM(MobilePhone mobile)
        {
            return new ScreenVM()
            {
                Id = mobile.Screen.Id,
                Size = mobile.Screen.Size,
                ColorsQuantity = mobile.Screen.ColorsQuantity,
                ScreenType = mobile.Screen.ScreenType,
                HorizontalResolution = mobile.Screen.HorizontalResolution,
                VerticalResolution = mobile.Screen.VerticalResolution,
            };
        }

        private HardwareVM GetHardwareVM(MobilePhone mobile)
        {
            return new HardwareVM()
            {
                Id = mobile.Hardware.Id,
                ProcessorName = mobile.Hardware.ProcessorName,
                ProcessorClock = mobile.Hardware.ProcessorClock,
                GraphicsProcessor = mobile.Hardware.GraphicsProcessor,
                OperationMemory = mobile.Hardware.OperationMemory,
                MemorySpace = mobile.Hardware.MemorySpace,
                SimCardType = mobile.Hardware.SimCardType,
                BatteryCapacity = mobile.Hardware.BatteryCapacity,
            };
        }

        private CameraVM GetCameraVM(MobilePhone mobile)
        {
            return new CameraVM()
            {
                Id = mobile.Camera.Id,
                Zoom = mobile.Camera.Zoom,
                Front = mobile.Camera.Front,
                FrontResulution = mobile.Camera.FrontResulution,
                Main = mobile.Camera.Main,
                MainResulution = mobile.Camera.MainResulution,
                Additional = mobile.Camera.Additional,
                AdditionalResulution = mobile.Camera.AdditionalResulution,
                VideoRecorderResolution = mobile.Camera.VideoRecorderResolution,
                VideoFPS = mobile.Camera.VideoFPS,
                Functions = mobile.Camera.Functions
            };
        }
    }
}
