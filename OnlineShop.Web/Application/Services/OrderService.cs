using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
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
        private readonly IEmailSender _emailSender;

        public OrderService(IOrderRepository repo,
                            IMapper mapper,
                            IShoppingCartRepository shoppingCartRepository,
                            IShippingAddressRepository shippingAddressRepository,
                            IUserRepository userRepository,
                            IEmailSender emailSender)
        {
            _repo = repo;
            _mapper = mapper;
            _shoppingCartRepository = shoppingCartRepository;
            _shippingAddressRepository = shippingAddressRepository;
            _userRepository = userRepository;
            _emailSender = emailSender;
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
            if(result != "-1")
            {
                await SendOrderEMail(result);
            }
            return result;
        }

        public async Task<List<OrderForSummaryListVM>> GetOrders()
        {
            var userId = await GetUserId();
            return await _repo.GetOrders(userId)
                .ProjectTo<OrderForSummaryListVM>(_mapper.ConfigurationProvider)
                .ToListAsync();
        }

        private async Task SendOrderEMail(string orderId)
        {
            var subject = "Order";
            var htmlMsg= $"Thank You for trust and order in our shop.\n" +
                $"We will send product as fas as possible." +
                $" Your order number: {orderId}.\n Regards Mobile Galactica Team";
            await _emailSender.SendEmailAsync(
                await _userRepository.GetUserEmail(),
                subject,
                htmlMsg);
        }
    }
}
