using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopsRUsRetailStore.Entities.DTOs.User;
using ShopsRUsRetailStore.Entities.Filter.User;
using ShopsRUsRetailStore.Services.Abstract;

namespace ShopsRUsRetailStore.API.Controllers.V1
{
    [Route("api/v{version:apiVersion}/[controller]/[action]")]
    [ApiController]
    [ApiVersion("1.0")]
    public class UserController : BaseController
    {

        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] AddUserDto addUserDto)
        {
            return ActionResultInstance(await _userService.AddAsync(addUserDto));
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] string userId)
        {
            return ActionResultInstance(await _userService.GetByIdAsync(userId));
        }
        [HttpGet]
        public async Task<IActionResult> GetList([FromQuery]GetUserFilter filter)
        {
            return ActionResultInstance(await _userService.GetListAsync(filter));
        }

    }
}
