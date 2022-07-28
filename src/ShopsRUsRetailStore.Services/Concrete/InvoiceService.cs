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
using ShopsRUsRetailStore.Entities.DTOs.Invoice;
using ShopsRUsRetailStore.Entities.Filter.Discount;
using ShopsRUsRetailStore.Entities.Filter.Invoice;
using ShopsRUsRetailStore.Services.Abstract;

namespace ShopsRUsRetailStore.Services.Concrete
{
    public class InvoiceService : IInvoiceService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IOrderService _orderService;
        private readonly IMapper _mapper;
        private readonly IDiscountService _discountService;
        private readonly IUserService _userService;

        public InvoiceService(IUnitOfWork unitOfWork, IOrderService orderService, IDiscountService discountService, IUserService userService, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _orderService = orderService;
            _discountService = discountService;
            _userService = userService;
            _mapper = mapper;
        }

        public async Task<ResponseDto<IList<InvoiceDto>>> GetListAsync(GetInvoiceFilter filter)
        {
            var invoices = await _unitOfWork.Invoice.GetAllList<InvoiceDto>(x => (!filter.Id.HasValue || x.Id == filter.Id) && (!filter.OrderId.HasValue || x.OrderId == filter.OrderId));
            return ResponseDto<IList<InvoiceDto>>.Success(invoices, 200);
        }

        public async Task<ResponseDto<InvoiceDto>> AddAsync(AddInvoiceDto addInvoiceDto)
        {
            var order = await _orderService.GetAsync(new Entities.Filter.Order.GetOrderFilter() { Id = addInvoiceDto.OrderId });
            if (order.Data == null)
            {
                return ResponseDto<InvoiceDto>.Fail("Order not found ", 403);
            }
            var user = await _userService.GetByIdAsync(order.Data.UserId);
            if (user.Data == null)
            {
                return ResponseDto<InvoiceDto>.Fail("User not found ", 403);
            }

            if (await _unitOfWork.Invoice.AnyAsync(x => x.Number == addInvoiceDto.Number))
            {
                return ResponseDto<InvoiceDto>.Fail("Invoice number must be a unique value", 403);
            }

            var isIsPercentageApply = false;

            var discount = await _discountService.GetAsync(new GetDiscountFilter { UserType = user.Data.Type });
            bool isTwoYears = (user.Data.CreatedDate.AddYears(2) <= DateTime.Now);

            if (discount.Data != null)
            {
                switch (discount.Data)
                {
                    case { IsPercentage: true }:
                        {
                            var discountValue = addInvoiceDto.TotalPrice * (discount.Data.Rate / 100);
                            addInvoiceDto.TotalPrice -= discountValue;
                            isIsPercentageApply = true;
                            break;
                        }
                    case { IsPercentage: false } when isTwoYears && user.Data.Type == Entities.Enums.UserTypeEnum.Customer:
                        addInvoiceDto.TotalPrice -= discount.Data.Rate;
                        break;
                }
            }

            if (!isIsPercentageApply)
            {
                discount = await _discountService.GetAsync(new GetDiscountFilter { UserType = Entities.Enums.UserTypeEnum.User });
                if (discount.Data != null)
                {
                    if (addInvoiceDto.TotalPrice > 100)
                    {
                        var deduction = (Math.Truncate(addInvoiceDto.TotalPrice / 100)) * discount.Data.Rate;
                        addInvoiceDto.TotalPrice -= deduction;
                    }
                }
            }

            var entity = _mapper.Map<Invoice>(addInvoiceDto);
            await _unitOfWork.Invoice.AddAsync(entity);
            await _unitOfWork.SaveChangesAsync();
            var responseDto = _mapper.Map<InvoiceDto>(entity);
            return ResponseDto<InvoiceDto>.Success(responseDto, 200);
        }
    }
}
