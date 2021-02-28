using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using OnlineShop.Web.Application.Interfaces;
using OnlineShop.Web.Application.ViewModels.ShippingAddress;
using OnlineShop.Web.Models.Entity;
using OnlineShop.Web.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Web.Application.Services
{
    public class ShippingAddressService : IShippingAddressService
    {
        private readonly IShippingAddressRepository _repo;
        private readonly IMapper _mapper;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public ShippingAddressService(IShippingAddressRepository repo,
                                      IMapper mapper,
                                      UserManager<ApplicationUser> userManager,
                                      IHttpContextAccessor httpContextAccessor)
        {
            _repo = repo;
            _mapper = mapper;
            _userManager = userManager;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task AddShippingAddress(ShippingAddressCreateVM shippingAddressAddVM)
        {
            var shippingAddress = MapVMToEntityAndAssingUserId(shippingAddressAddVM);
            await _repo.AddShippingAddress(shippingAddress);
        }

        public async Task<List<ShippingAddressVM>> GetShippingAddresses()
        {
            var userId = GetUserId();
            var list = await _repo.GetShippingAddresses(userId)
                                  .ProjectTo<ShippingAddressVM>(_mapper.ConfigurationProvider)
                                  .ToListAsync();
            return list;
        }

        public async Task<ShippingAddressVM> GetShippingAddressById(int shippingAddressId)
        {
            var shippingAddressV = await _repo.GetShippingAddressById(shippingAddressId);
            var shippingAddressVM = _mapper.Map<ShippingAddressVM>(shippingAddressV);
            return shippingAddressVM;
        }

        public async Task RemoveShippingAddress(int shippingAddressId)
        {
            await _repo.RemoveShippingAddress(shippingAddressId);
        }

        public async Task UpdateShippingAddress(ShippingAddressVM shippingAddressVM)
        {
            var shippingAddress = MapVMToEntityAndAssingUserId(shippingAddressVM);
            await _repo.UpdateShippingAddress(shippingAddress);
        }
        
        private ShippingAddress MapVMToEntityAndAssingUserId(ShippingAddressVM shippingAddressVM)
        {
            var userId = GetUserId();
            var shippingAddress = _mapper.Map<ShippingAddress>(shippingAddressVM);
            shippingAddress.ApplicationUserId = userId;
            return shippingAddress;
        }

        private ShippingAddress MapVMToEntityAndAssingUserId(ShippingAddressCreateVM shippingAddressVM)
        {
            var userId = GetUserId();
            var shippingAddress = _mapper.Map<ShippingAddress>(shippingAddressVM);
            shippingAddress.ApplicationUserId = userId;
            return shippingAddress;
        }

        private string GetUserId()
        {
            var loggedUser = _httpContextAccessor.HttpContext.User;
            var userId = _userManager.GetUserId(loggedUser);
            return userId;
        }

    }
}
