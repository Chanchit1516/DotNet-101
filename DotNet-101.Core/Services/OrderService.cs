using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using DotNet_101.Core.DTOs;
using DotNet_101.Core.Entities;
using DotNet_101.Core.Interfaces.Repository;
using DotNet_101.Core.Interfaces.Service;
using DotNet_101.SharedKernel.Helpers;

namespace DotNet_101.Core.Services
{
    public class OrderService : IOrderService
    {
        private IUnitOfWork _uow;
        private readonly IMapper _mapper;
        public OrderService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _uow = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IEnumerable<OrderDTO>> GetAllOrder()
        {
            try
            {
                var orderModel = await _uow.OrderRepository.GetAllOrder();
                return _mapper.Map<IEnumerable<OrderDTO>>(orderModel);
            }
            catch (Exception ex)
            {
                throw new AppException(ex.Message);
            }
        }

        public async Task<bool> InsertOrder(OrderDTO productDTO)
        {
            try
            {
                var order = _mapper.Map<Order>(productDTO);
                var res = await _uow.OrderRepository.Add(order);
                await _uow.CompleteAsync();
                return res;
            }
            catch (Exception ex)
            {
                throw new AppException(ex.Message);
            }
        }
    }
}
