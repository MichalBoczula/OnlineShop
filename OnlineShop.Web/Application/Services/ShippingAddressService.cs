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
        private readonly IUserRepository _userRepository;

        public ShippingAddressService(IShippingAddressRepository repo,
                                      IMapper mapper,
                                      IUserRepository userRepository)
        {
            _repo = repo;
            _mapper = mapper;
            _userRepository = userRepository;
        }

        public async Task AddShippingAddress(ShippingAddressCreateVM shippingAddressAddVM)
        {
            var shippingAddress = await MapVMToEntityAndAssingUserId(shippingAddressAddVM);
            await _repo.AddShippingAddress(shippingAddress);
        }

        public async Task<List<ShippingAddressVM>> GetShippingAddresses()
        {
            var userId = await GetUserId();
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
            var shippingAddress = await MapVMToEntityAndAssingUserId(shippingAddressVM);
            await _repo.UpdateShippingAddress(shippingAddress);
        }
        
        private async Task<ShippingAddress> MapVMToEntityAndAssingUserId(ShippingAddressVM shippingAddressVM)
        {
            var userId = await GetUserId();
            var shippingAddress = _mapper.Map<ShippingAddress>(shippingAddressVM);
            shippingAddress.ApplicationUserId = userId;
            return shippingAddress;
        }

        private async Task<ShippingAddress> MapVMToEntityAndAssingUserId(ShippingAddressCreateVM shippingAddressVM)
        {
            var userId = await GetUserId();
            var shippingAddress = _mapper.Map<ShippingAddress>(shippingAddressVM);
            shippingAddress.ApplicationUserId = userId;
            return shippingAddress;
        }

        private async Task<string> GetUserId()
        {
            var userId = await _userRepository.GetUserId();
            return userId;
        }

    }
}
