using AutoMapper;
using OnlineShop.Web.Application.Mapping;
using OnlineShop.Web.Application.ViewModels.Screen;
using OnlineShop.Web.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Web.Application.ViewModels.ShoppingCart
{
    public class ShoppingCartVM : IMapFrom<OnlineShop.Web.Models.Entity.ShoppingCart>
    {
        public List<ShoppingCartMobilePhone> Items { get; set; }
        public double Total { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Models.Entity.ShoppingCart, ShoppingCartVM>()
                .ForMember(vm => vm.Total, opt => opt.Ignore());
        }
    }
}
