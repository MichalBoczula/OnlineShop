using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Web.Models.Filters
{
    public class Filters
    {
        public Filters()
        {
            Brands = new List<string>();
        }

        public List<string> Brands { get; set; }
        public int? LowerPrice { get; set; }
        public int? MaxPrice { get; set; }
        public string OperationSystem{ get; set; }
        public decimal? ScreenSize { get; set; }
        public int? OperationMemory { get; set; }
        public int? MemorySpace { get; set; }
        public int? MainResolution { get; set; }
        public int? FrontResolution { get; set; }
    }
}
