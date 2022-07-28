using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using ShopsRUsRetailStore.Entities.Concrete;
using ShopsRUsRetailStore.Entities.DTOs.Discount;

namespace ShopsRUsRetailStore.Services.AutoMapper.Profiles
{
    public class DiscountProfile : Profile
    {
        public DiscountProfile()
        {
            CreateMap<DiscountDto, Discount>().ReverseMap();

            CreateMap<AddDiscountDto, Discount>().ForMember(m => m.CreatedDate, o => o.MapFrom(s => DateTime.Now))
                .ForMember(m => m.ModifiedDate, o => o.MapFrom(s => DateTime.Now));
        }

    }
}
