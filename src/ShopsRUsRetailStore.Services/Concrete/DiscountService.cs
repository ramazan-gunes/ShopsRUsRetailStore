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
using ShopsRUsRetailStore.Entities.DTOs.User;
using ShopsRUsRetailStore.Entities.Filter.Discount;
using ShopsRUsRetailStore.Services.Abstract;

namespace ShopsRUsRetailStore.Services.Concrete
{
    public class DiscountService : IDiscountService
    {

        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public DiscountService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<ResponseDto<DiscountDto>> GetAsync(GetDiscountFilter? filter)
        {
            var discount = await _unitOfWork.Discount.GetAsync<DiscountDto>(x => filter != null && (!filter.Id.HasValue || x.Id == filter.Id) && (!filter.UserType.HasValue || x.UserType == filter.UserType));
            return ResponseDto<DiscountDto>.Success(discount, 200);
        }

        public async Task<ResponseDto<IList<DiscountDto>>> GetListAsync(GetDiscountFilter? filter)
        {
            var discounts = await _unitOfWork.Discount.GetAllList<DiscountDto>(x => filter != null && (!filter.Id.HasValue || x.Id == filter.Id) && (!filter.UserType.HasValue || x.UserType == filter.UserType));
            return ResponseDto<IList<DiscountDto>>.Success(discounts, 200);
        }

        public async Task<ResponseDto<NoDataDto>> AddAsync(AddDiscountDto addDiscountDto)
        {
            if (await _unitOfWork.Discount.AnyAsync(x => x.UserType == addDiscountDto.UserType))
            {
                return ResponseDto<NoDataDto>.Fail("You have added a discount before.", 403);
            }

            var newEntity = _mapper.Map<Discount>(addDiscountDto);
            await _unitOfWork.Discount.AddAsync(newEntity);
            await _unitOfWork.SaveChangesAsync();
            return ResponseDto<NoDataDto>.Success(200);
        }
    }
}
