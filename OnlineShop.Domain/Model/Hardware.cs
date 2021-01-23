using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.Domain.Model
{
    public class Hardware
    {
        public int Id { get; set; }
        public string ProcessorName { get; set; }
        public string OperationSystem { get; set; }
        public string GraphicsProcessor { get; set; }
        public int OperationMemory { get; set; }
        public int MemorySpace { get; set; }
        public string SimCardType { get; set; }
        public int BatteryCapacity { get; set; }
        public ICollection<MobilePhone> MobilePhones { get; set; }

    }
}
