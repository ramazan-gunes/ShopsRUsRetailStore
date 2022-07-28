using Microsoft.AspNetCore.Mvc;
using ShopsRUsRetailStore.Core.DTOs.Result;

namespace ShopsRUsRetailStore.API.Controllers
{
    public class BaseController : ControllerBase
    {
        public IActionResult ActionResultInstance<T>(ResponseDto<T> response) where T : class
        {

            return new ObjectResult(response)
            {
                StatusCode = response.StatusCode,
            };
        }

    }
}
