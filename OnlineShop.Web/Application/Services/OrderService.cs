using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using OnlineShop.Web.Application.Interfaces;
using OnlineShop.Web.Application.ViewModels.Order;
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


        public OrderService(IOrderRepository repo,
                            IMapper mapper,
                            UserManager<ApplicationUser> userManager,
                            IHttpContextAccessor httpContextAccessor,
                            IShoppingCartRepository shoppingCartRepository)
        {
            _repo = repo;
            _mapper = mapper;
            _userManager = userManager;
            _httpContextAccessor = httpContextAccessor;
            _shoppingCartRepository = shoppingCartRepository;
        }

        public async Task AddOrder(OrderVM orderVM)
        {

            await _repo.AddOrder(orderVM.ShoppingCartVM,
                                 GetUserId(),
                                 orderVM.ShippingAddressId);
        }

        public async Task<OrderVM> GetOrderDetails(int shippingAddressId)
        {
            var shoppingCartVM =
                _mapper.Map<ShoppingCartVM>(
                    await _shoppingCartRepository.GetShoppingCart()
                );
            return new OrderVM()
            {
                ShoppingCartVM = shoppingCartVM,
                UserId = GetUserId(),
                ShippingAddressId = shippingAddressId
            };
        }

        private string GetUserId()
        {
            var loggedUser = _httpContextAccessor.HttpContext.User;
            var userId = _userManager.GetUserId(loggedUser);
            return userId;
        }
    }
}
