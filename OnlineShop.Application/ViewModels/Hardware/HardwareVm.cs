using AutoMapper;
using OnlineShop.Application.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.Application.ViewModels.Hardware
{
    public class HardwareVM : IMapFrom<OnlineShop.Domain.Model.Hardware>
    {
        public int Id { get; set; }
        public string ProcessorName { get; set; }
        public string ProcessorClock { get; set; }
        public string GraphicsProcessor { get; set; }
        public int OperationMemory { get; set; }
        public int MemorySpace { get; set; }
        public string SimCardType { get; set; }
        public int BatteryCapacity { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<OnlineShop.Domain.Model.Hardware, HardwareVM>();
        }
    }
}
