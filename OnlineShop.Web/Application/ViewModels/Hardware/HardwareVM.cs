using AutoMapper;
using OnlineShop.Web.Application.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.Web.Application.ViewModels.Hardware
{
    public class HardwareVM : IMapFrom<OnlineShop.Web.Models.Entity.Hardware>
    {
        public int Id;
        public string ProcessorName;
        public string OperationSystem;
        public string GraphicsProcessor;
        public int OperationMemory;
        public int MemorySpace;
        public string SimCardType;
        public int BatteryCapacity;

        public void Mapping(Profile profile)
        {
            profile.CreateMap<OnlineShop.Web.Models.Entity.Hardware, HardwareVM>();
        }
    }
}
