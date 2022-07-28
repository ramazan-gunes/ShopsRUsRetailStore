using System.Text.Json.Serialization;

namespace ShopsRUsRetailStore.Core.DTOs.Result
{
    public class ResponseDto<T>
    {
        public T? Data { get; set; }
        public int StatusCode { get; set; }
        public bool IsSuccessful { get; set; }
        public ErrorDto Error { get; set; }

        public static ResponseDto<T> Success(T data, int statusCode)
        {
            return new ResponseDto<T> { Data = data, StatusCode = statusCode, IsSuccessful = true };
        }

        public static ResponseDto<T> Success(int statusCode)
        {
            return new ResponseDto<T> { Data = default, StatusCode = statusCode, IsSuccessful = true };
        }

        public static ResponseDto<T> Fail(ErrorDto errorDto, int statusCode)
        {
            return new ResponseDto<T> { Error = errorDto, StatusCode = statusCode, IsSuccessful = false };
        }

        public static ResponseDto<T> Fail(string errorMessage, int statusCode, bool isShow)
        {
            var error = new ErrorDto(errorMessage, isShow);
            return new ResponseDto<T> { Error = error, StatusCode = statusCode, IsSuccessful = false };
        }
        public static ResponseDto<T> Fail(string errorMessage, int statusCode)
        {
            var error = new ErrorDto(errorMessage, true);
            return new ResponseDto<T> { Error = error, StatusCode = statusCode, IsSuccessful = false };
        }
    }
}
