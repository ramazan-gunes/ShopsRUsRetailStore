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
    public class OrderController : BaseController
    {
        private readonly IOrderService _orderService;
        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }
         
        [HttpGet]
        public async Task<IActionResult> GetList()
        {
            return ActionResultInstance(await _orderService.GetListAsync());
        }

    }
}
