using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using DotNet_101.Core.DTOs;
using DotNet_101.Core.Entities;
using DotNet_101.Core.Interfaces.Repository;
using DotNet_101.Core.Interfaces.Service;

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
            var customerModel = await _uow.CustomerRepository.GetAllCustomer();
            return _mapper.Map<IEnumerable<CustomerDTO>>(customerModel);
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
                throw ex;
            }
        }
    }
}