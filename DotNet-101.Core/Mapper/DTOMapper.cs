﻿using AutoMapper;
using DotNet_101.Core.DTOs;
using DotNet_101.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;


namespace DotNet_101.Core.Mapper
{

    public class DTOMapper : Profile
    {
        public DTOMapper()
        {
            CreateMap<Product, ProductDTO>().ReverseMap();
            CreateMap<Customer, CustomerDTO>().ReverseMap();
            CreateMap<Order, OrderDTO>().ReverseMap();
        }
    }
}
