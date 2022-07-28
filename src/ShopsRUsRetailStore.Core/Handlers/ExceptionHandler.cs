using System.Text.Json;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using ShopsRUsRetailStore.Core.DTOs.Result;

namespace ShopsRUsRetailStore.Core.Handlers
{
    public static class ExceptionHandler
    {
        public static void UseExceptionHandler(this IApplicationBuilder app)
        {

            app.UseExceptionHandler(config =>
            {
                config.Run(async context =>
                {
                    context.Response.StatusCode = 500;
                    context.Response.ContentType = "application/json";

                    var errorFeature = context.Features.Get<IExceptionHandlerFeature>();

                    if (errorFeature != null)
                    {
                        var ex = errorFeature.Error;

                        ErrorDto errorDto = ex is CustomException ? new ErrorDto(ex.Message, true) : new ErrorDto(ex.Message, false);

                        var response = ResponseDto<NoDataDto>.Fail(errorDto, 500);

                        var responseText = JsonSerializer.Serialize(response, new JsonSerializerOptions
                        {
                            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                        });

                        await context.Response.WriteAsync(responseText);
                    }
                });
            });
        }
    }

    public class CustomException : System.Exception
    {
        public CustomException() : base()
        {

        }
        public CustomException(string message) : base(message)
        {
        }
        public CustomException(string message, System.Exception innerException) : base(message, innerException)
        {
        }
    }

}
