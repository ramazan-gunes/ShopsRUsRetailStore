using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using ShopsRUsRetailStore.Entities.Concrete;
using ShopsRUsRetailStore.Entities.DTOs.Discount;
using ShopsRUsRetailStore.Entities.DTOs.Invoice;

namespace ShopsRUsRetailStore.Services.AutoMapper.Profiles
{
    public class InvoiceProfile : Profile
    {
        public InvoiceProfile()
        {
            CreateMap<InvoiceDto, Invoice>().ReverseMap();
            CreateMap<AddInvoiceDto, Invoice>().ForMember(m => m.CreatedDate, o => o.MapFrom(s => DateTime.Now)).ForMember(m => m.ModifiedDate, o => o.MapFrom(s => DateTime.Now));
        }

    }
}
