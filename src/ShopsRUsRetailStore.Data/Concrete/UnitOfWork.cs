using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopsRUsRetailStore.Data.Abstract;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ShopsRUsRetailStore.Core.DTOs.Result;
using ShopsRUsRetailStore.Data.Concrete.EntityFramework.Contexts;
using ShopsRUsRetailStore.Data.Concrete.EntityFramework.Repositories;

namespace ShopsRUsRetailStore.Data.Concrete
{
    public class UnitOfWork : IUnitOfWork
    {

        private readonly IMapper _mapper;
        private readonly DbContext _context;
        private EfDiscountRepository efDiscountRepository;
        private EfInvoiceRepository efInvoiceRepository;
        private EfInvoiceDetailRepository efInvoiceDetailRepository;
        private EfOrderRepository efOrderRepository;



        public UnitOfWork(ShopsRUsDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public IDiscount Discount => efDiscountRepository ?? new EfDiscountRepository(_context, _mapper);

        public IInvoice Invoice => efInvoiceRepository ?? new EfInvoiceRepository(_context, _mapper);   

        public IInvoiceDetail InvoiceDetail => efInvoiceDetailRepository ?? new EfInvoiceDetailRepository(_context, _mapper);
        public IOrder Order => efOrderRepository ?? new EfOrderRepository(_context, _mapper);

        public ResponseDto<NoDataDto> SaveChanges()
        {
            try
            {
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                return ResponseDto<NoDataDto>.Fail(ex.Message, 500, false);
            }

            return ResponseDto<NoDataDto>.Success(200);
        }

        public async Task<ResponseDto<NoDataDto>> SaveChangesAsync()
        {
            var dbContextTransaction = await _context.Database.BeginTransactionAsync();
            try
            {
                await _context.SaveChangesAsync();
                await dbContextTransaction.CommitAsync();
            }
            catch (Exception ex)
            {
                //Log Exception Handling message                      
                await dbContextTransaction.RollbackAsync();

                return ResponseDto<NoDataDto>.Fail(ex.Message,500,false);

            }

            return ResponseDto<NoDataDto>.Success(200);


        }
    }
}
