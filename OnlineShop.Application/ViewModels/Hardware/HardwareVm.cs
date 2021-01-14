using AutoMapper;
using OnlineShop.Application.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.Application.ViewModels.Hardware
{
    public class HardwareVM : IMapFrom<OnlineShop.Domain.Model.Hardware>
    {
        public int Id;
        public string ProcessorName;
        public string ProcessorClock;
        public string GraphicsProcessor;
        public int OperationMemory;
        public int MemorySpace;
        public string SimCardType;
        public int BatteryCapacity;

        public void Mapping(Profile profile)
        {
            profile.CreateMap<OnlineShop.Domain.Model.Hardware, HardwareVM>();
        }
    }
}
