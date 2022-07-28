using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopsRUsRetailStore.Core.DTOs.Result;
using ShopsRUsRetailStore.Entities.DTOs.Discount;
using ShopsRUsRetailStore.Entities.DTOs.Invoice;
using ShopsRUsRetailStore.Entities.Filter.Discount;
using ShopsRUsRetailStore.Entities.Filter.Invoice;

namespace ShopsRUsRetailStore.Services.Abstract
{
    public interface IInvoiceService
    {

        Task<ResponseDto<IList<InvoiceDto>>> GetListAsync(GetInvoiceFilter filter);
        Task<ResponseDto<InvoiceDto>> AddAsync(AddInvoiceDto addInvoiceDto);

    }
}
