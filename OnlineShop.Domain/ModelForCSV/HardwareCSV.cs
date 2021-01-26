using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.Domain.ModelForCSV
{
    public class HardwareCSV
    {
        public int Id { get; set; }
        public string ProcessorName { get; set; }
        public string OperationSystem { get; set; }
        public string GraphicsProcessor { get; set; }
        public int OperationMemory { get; set; }
        public int MemorySpace { get; set; }
        public string SimCardType { get; set; }
        public int BatteryCapacity { get; set; }
        public int MobilePhoneId { get; set; }
    }
}
