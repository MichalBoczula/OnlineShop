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
            Brands = new Brands();
        }

        public Brands Brands { get; set; }
        public int? MinPrice { get; set; }
        public int? MaxPrice { get; set; }
        public string OperationSystem{ get; set; }
        public int? OperationMemory { get; set; }
        public int? MemorySpace { get; set; }
        public int? MainResolution { get; set; }
        public int? FrontResolution { get; set; }
    }
}
