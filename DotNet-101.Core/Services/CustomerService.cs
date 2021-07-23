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
    public class CustomerService : ICustomerService
    {
        private IUnitOfWork _uow;
        private readonly IMapper _mapper;
        public CustomerService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _uow = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IEnumerable<CustomerDTO>> GetAllCustomer()
        {
            try
            {
                var customerModel = await _uow.CustomerRepository.GetAllCustomer();
                return _mapper.Map<IEnumerable<CustomerDTO>>(customerModel);
            }
            catch (Exception ex)
            {
                throw new AppException(ex.Message);
            }
        }

        public async Task<bool> InsertCustomer(CustomerDTO productDTO)
        {
            try
            {
                var customer = _mapper.Map<Customer>(productDTO);
                var res = await _uow.CustomerRepository.Add(customer);
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