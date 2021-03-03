using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
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
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IShoppingCartRepository _shoppingCartRepository;
        private readonly IShippingAddressRepository _shippingAddressRepository;

        public OrderService(IOrderRepository repo,
                            IMapper mapper,
                            UserManager<ApplicationUser> userManager,
                            IHttpContextAccessor httpContextAccessor,
                            IShoppingCartRepository shoppingCartRepository,
                            IShippingAddressRepository shippingAddressRepository)
        {
            _repo = repo;
            _mapper = mapper;
            _userManager = userManager;
            _httpContextAccessor = httpContextAccessor;
            _shoppingCartRepository = shoppingCartRepository;
            _shippingAddressRepository = shippingAddressRepository;
        }


        public async Task<OrderVM> GetOrderDetails(int shippingAddressId)
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
                UserId = GetUserId(),
                ShippingAddressVM = shippingAddressVM
            };
        }

        private string GetUserId()
        {
            var loggedUser = _httpContextAccessor.HttpContext.User;
            var userId = _userManager.GetUserId(loggedUser);
            return userId;
        }

        public async Task<string> AddOrder(OrderVM orderVM)
        {
            var result = await _repo.AddOrder(orderVM.ShoppingCartVM, orderVM.UserId, orderVM.ShippingAddressVM.Id);
            var shoppingCart = await _shoppingCartRepository.GetShoppingCart();
            await _shoppingCartRepository.DeleteAllItems(shoppingCart);
            return result;
        }
    }
}
