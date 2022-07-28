using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopsRUsRetailStore.Core.DTOs.Result;

namespace ShopsRUsRetailStore.Data.Abstract
{
    public interface IUnitOfWork
    {

        IDiscount Discount { get; }
        IInvoice Invoice { get; }
        IInvoiceDetail InvoiceDetail { get; }
        IOrder Order { get; }

        Task<ResponseDto<NoDataDto>> SaveChangesAsync();
        ResponseDto<NoDataDto> SaveChanges();

    }
}
