using Microsoft.AspNetCore.Mvc;
using ShopsRUsRetailStore.Entities.DTOs.Discount;
using ShopsRUsRetailStore.Entities.Filter.Discount;
using ShopsRUsRetailStore.Entities.Filter.User;
using ShopsRUsRetailStore.Services.Abstract;

namespace ShopsRUsRetailStore.API.Controllers.V1
{
    [Route("api/v{version:apiVersion}/[controller]/[action]")]
    [ApiController]
    [ApiVersion("1.0")]
    public class DiscountController : BaseController
    {
        private readonly IDiscountService _discountService;
        public DiscountController(IDiscountService discountService)
        {
            _discountService = discountService;
        }


        [HttpPost]
        public async Task<IActionResult> Add([FromBody] AddDiscountDto addDiscountDto)
        {
            return ActionResultInstance(await _discountService.AddAsync(addDiscountDto));
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] GetDiscountFilter? filter)
        {
            return ActionResultInstance(await _discountService.GetAsync(filter));
        }
        [HttpGet]
        public async Task<IActionResult> GetList([FromQuery] GetDiscountFilter? filter)
        {
            return ActionResultInstance(await _discountService.GetListAsync(filter));
        }




    }
}
