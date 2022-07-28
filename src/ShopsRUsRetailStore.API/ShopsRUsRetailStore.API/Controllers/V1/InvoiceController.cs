using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopsRUsRetailStore.Entities.DTOs.Discount;
using ShopsRUsRetailStore.Entities.DTOs.Invoice;
using ShopsRUsRetailStore.Entities.Filter.Discount;
using ShopsRUsRetailStore.Entities.Filter.Invoice;
using ShopsRUsRetailStore.Services.Abstract;
using ShopsRUsRetailStore.Services.Concrete;

namespace ShopsRUsRetailStore.API.Controllers.V1
{
    [Route("api/v{version:apiVersion}/[controller]/[action]")]
    [ApiController]
    [ApiVersion("1.0")]
    public class InvoiceController : BaseController
    {
        private readonly IInvoiceService _invoiceService;
        public InvoiceController(IInvoiceService invoiceService)
        {
            _invoiceService = invoiceService;
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] AddInvoiceDto addInvoiceDto)
        {
            return ActionResultInstance(await _invoiceService.AddAsync(addInvoiceDto));
        }

        [HttpGet]
        public async Task<IActionResult> GetList([FromQuery] GetInvoiceFilter? filter)
        {
            return ActionResultInstance(await _invoiceService.GetListAsync(filter));
        }

    }
}
