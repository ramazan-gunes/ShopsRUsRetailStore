using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using ShopsRUsRetailStore.Core.DTOs.Result;

namespace ShopsRUsRetailStore.Core.Extensions.ServiceExtensions
{
    public static class FluentValidationServiceExtension
    {
        public static void UseFluentValidationResponse(this IServiceCollection services)
        {

            services.Configure<ApiBehaviorOptions>(options =>
            {

                options.InvalidModelStateResponseFactory = context =>
                {
                    var errors = context.ModelState.Values.Where(x => x.Errors.Count > 0).SelectMany(x => x.Errors)
                        .Select(x => x.ErrorMessage);
                    ErrorDto errorDto = new ErrorDto(errors.ToList(), true);

                    var response = ResponseDto<NoContentResult>.Fail(errorDto, 400);

                    return new BadRequestObjectResult(response);

                };
            });

        }


    }
}
