using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using ShopsRUsRetailStore.Core.DTOs.Result;
using ShopsRUsRetailStore.Data.Abstract;
using ShopsRUsRetailStore.Entities.Concrete;
using ShopsRUsRetailStore.Entities.DTOs.Discount;
using ShopsRUsRetailStore.Entities.DTOs.Order;
using ShopsRUsRetailStore.Entities.DTOs.User;
using ShopsRUsRetailStore.Entities.Filter.Discount;
using ShopsRUsRetailStore.Entities.Filter.Order;
using ShopsRUsRetailStore.Services.Abstract;

namespace ShopsRUsRetailStore.Services.Concrete
{
    public class OrderService : IOrderService
    {

        private readonly IUnitOfWork _unitOfWork;

        public OrderService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<ResponseDto<OrderDto?>> GetAsync(GetOrderFilter filter)
        {
            var order = await _unitOfWork.Order.GetAsync<OrderDto>(x => (!filter.Id.HasValue || x.Id == filter.Id));
            return ResponseDto<OrderDto>.Success(order, 200);
        }

        public async Task<ResponseDto<IList<OrderDto>>> GetListAsync()
        {
            var orders = await _unitOfWork.Order.GetAllList<OrderDto>();
            return ResponseDto<IList<OrderDto>>.Success(orders, 200);
        }
    }
}
