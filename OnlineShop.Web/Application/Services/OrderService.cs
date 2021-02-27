using AutoMapper;
using Microsoft.AspNetCore.Identity;
using OnlineShop.Web.Application.Interfaces;
using OnlineShop.Web.Application.ViewModels.Order;
using OnlineShop.Web.Infrastructure;
using OnlineShop.Web.Models.Entity;
using OnlineShop.Web.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Web.Application.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _repo;
        private readonly IMapper _mapper;

        public OrderService(IOrderRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task AddOrder(OrderVM orderVM)
        {
            await _repo.AddOrder(orderVM.ShoppingCartVM, orderVM.UserId, orderVM.ShippingAddressId);
        }

    }
}
