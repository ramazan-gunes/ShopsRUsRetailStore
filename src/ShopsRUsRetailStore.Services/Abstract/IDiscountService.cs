using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopsRUsRetailStore.Core.DTOs.Result;
using ShopsRUsRetailStore.Entities.DTOs.Discount;
using ShopsRUsRetailStore.Entities.DTOs.User;
using ShopsRUsRetailStore.Entities.Filter.Discount;
using ShopsRUsRetailStore.Entities.Filter.User;

namespace ShopsRUsRetailStore.Services.Abstract
{
    public interface IDiscountService
    {
        Task<ResponseDto<DiscountDto>> GetAsync(GetDiscountFilter? filter);
        Task<ResponseDto<IList<DiscountDto>>> GetListAsync(GetDiscountFilter? filter);
        Task<ResponseDto<NoDataDto>> AddAsync(AddDiscountDto addDiscountDto);
    }
}
