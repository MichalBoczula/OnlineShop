using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using OnlineShop.Web.Application.Interfaces;
using OnlineShop.Web.Application.ViewModels.Order;
using OnlineShop.Web.Application.ViewModels.ShippingAddress;
using OnlineShop.Web.Application.ViewModels.ShoppingCart;
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
        private readonly IShoppingCartRepository _shoppingCartRepository;
        private readonly IShippingAddressRepository _shippingAddressRepository;
        private readonly IUserRepository _userRepository;

        public OrderService(IOrderRepository repo,
                            IMapper mapper,
                            IShoppingCartRepository shoppingCartRepository,
                            IShippingAddressRepository shippingAddressRepository,
                            IUserRepository userRepository)
        {
            _repo = repo;
            _mapper = mapper;
            _shoppingCartRepository = shoppingCartRepository;
            _shippingAddressRepository = shippingAddressRepository;
            _userRepository = userRepository;
        }


        public async Task<OrderVM> GetOrderSummary(int shippingAddressId)
        {
            var shoppingCart = await _shoppingCartRepository.GetShoppingCart();
            var shoppingCartVM = _mapper.Map<ShoppingCartVM>(shoppingCart);
            shoppingCartVM.Total = await _shoppingCartRepository.CountTotal(shoppingCart);
            var shippingAddressVM = _mapper.Map<ShippingAddressVM>(
                     await _shippingAddressRepository.GetShippingAddressById(shippingAddressId)
                 );
            return new OrderVM()
            {
                ShoppingCartVM = shoppingCartVM,
                UserId = await GetUserId(),
                ShippingAddressVM = shippingAddressVM
            };
        }

        public async Task<OrderDetailsVM> GetOrderDetails(string orderId)
        {
            var VM = _mapper.Map<OrderDetailsVM>(
                    await _repo.GetOrderbyId(orderId)
                );
            VM.CountTotal();
            return VM;
        }


        private async Task<string> GetUserId()
        {
            var userId = await _userRepository.GetUserId();
            return userId;
        }

        public async Task<string> AddOrder(OrderVM orderVM)
        {
            var result = await _repo.AddOrder(orderVM.ShoppingCartVM, orderVM.UserId, orderVM.ShippingAddressVM.Id);
            var shoppingCart = await _shoppingCartRepository.GetShoppingCart();
            await _shoppingCartRepository.DeleteAllItems(shoppingCart);
            return result;
        }

        public async Task<List<OrderForSummaryListVM>> GetOrders()
        {
            var userId = await GetUserId();
            return await _repo.GetOrders(userId)
                .ProjectTo<OrderForSummaryListVM>(_mapper.ConfigurationProvider)
                .ToListAsync();
        }
    }
}
