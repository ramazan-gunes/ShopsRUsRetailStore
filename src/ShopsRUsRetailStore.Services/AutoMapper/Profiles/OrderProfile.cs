using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using ShopsRUsRetailStore.Entities.Concrete;
using ShopsRUsRetailStore.Entities.DTOs.Order;
using ShopsRUsRetailStore.Entities.DTOs.User;

namespace ShopsRUsRetailStore.Services.AutoMapper.Profiles
{
    public class OrderProfile : Profile
    {
        public OrderProfile()
        {
            CreateMap<OrderDto, Order>().ReverseMap();
        }
    }
}
