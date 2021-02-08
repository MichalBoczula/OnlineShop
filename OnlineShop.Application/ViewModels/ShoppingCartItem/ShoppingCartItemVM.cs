using AutoMapper;
using OnlineShop.Application.Mapping;
using OnlineShop.Application.ViewModels.Mobile;
using OnlineShop.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.Application.ViewModels.ShoppingCartItem
{
    public class ShoppingCartItemVM : IMapFrom<OnlineShop.Domain.Model.ShoppingCartItem>
    {
        public int Id { get; set; }
        public MobilePhoneDetailsVM MobilePhone { get; set; }
        public int Quantity { get; set; }
        public string ShoppingCartId { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<OnlineShop.Domain.Model.ShoppingCartItem, ShoppingCartItemVM>();
        }
    }
}
