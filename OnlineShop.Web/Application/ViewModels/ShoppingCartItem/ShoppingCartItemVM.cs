using AutoMapper;
using OnlineShop.Web.Application.Mapping;
using OnlineShop.Web.Application.ViewModels.Mobile;
using OnlineShop.Web.Models.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.Web.Application.ViewModels.ShoppingCartItem
{
    public class ShoppingCartItemVM : IMapFrom<OnlineShop.Web.Models.Entity.ShoppingCartMobilePhone>
    {
        public int Id { get; set; }
        public MobilePhoneDetailsVM MobilePhone { get; set; }
        public int Quantity { get; set; }
        public string ShoppingCartId { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap< OnlineShop.Web.Models.Entity.ShoppingCartMobilePhone, ShoppingCartItemVM>();
        }
    }
}
