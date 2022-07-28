using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopsRUsRetailStore.Core.DTOs.Result;
using ShopsRUsRetailStore.Entities.DTOs.Discount;
using ShopsRUsRetailStore.Entities.DTOs.Order;
using ShopsRUsRetailStore.Entities.Filter.Discount;
using ShopsRUsRetailStore.Entities.Filter.Order;

namespace ShopsRUsRetailStore.Services.Abstract
{
    public interface IOrderService
    {
        Task<ResponseDto<OrderDto?>> GetAsync(GetOrderFilter getOrderFilter);
        Task<ResponseDto<IList<OrderDto>>> GetListAsync();

    }
}
