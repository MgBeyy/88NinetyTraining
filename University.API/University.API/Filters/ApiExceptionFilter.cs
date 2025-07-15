using AutoWrapper.Wrappers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using University.API.Controllers;
using University.Core.Exceptions;

namespace University.API.Filters
{
    public class ApiExceptionFilter : IExceptionFilter

    {
        private readonly ILogger<ApiExceptionFilter> _logger;

        public ApiExceptionFilter(ILogger<ApiExceptionFilter> logger)
        {
            _logger = logger;
        }



        public void OnException(ExceptionContext context)
        {
            if (context.Exception is NotFoundException)
            {
                _logger.LogError("There is an item didn't found");
                context.Result = Response(context.Exception.Message, "item not found", StatusCodes.Status404NotFound);
                return;
            }


            if (context.Exception is BusinessException businessException)
            {
                _logger.LogError("One or more business error occurred");
                if (businessException.Errors.Any())
                    context.Result = Response(businessException.Errors, "One or more business error occurred", StatusCodes.Status400BadRequest);
                else
                    context.Result = Response(businessException.Message, "One or more business error occurred", StatusCodes.Status400BadRequest);
                return;
            }


            if (context.Exception is ArgumentNullException)
            {
                _logger.LogError("There is missing data");
                context.Result = Response(context.Exception.Message, "Missing data", StatusCodes.Status400BadRequest);
                return;
            }


            if (context.Exception is UnauthorizedAccessException)
            {
                _logger.LogError("An unauthorized access attempt has been intercepted.");
                context.Result = Response(context.Exception.Message, "Unauthorized", StatusCodes.Status401Unauthorized);
                return;
            }

            _logger.LogError(" !!! Unhandled exception !!!");
            context.Result = Response(context.Exception.Message, "Internal Server Error", StatusCodes.Status500InternalServerError);
            return;
        }




public ObjectResult Response(string message, string title, int status, string? stackTrace = null)
        {
            var result = new ApiResponse
            {
                StatusCode = status,
                Message = message,
                ResponseException = title,
                IsError = true,
                Version = "1.0",
                Result = stackTrace
            };
            return new ObjectResult(result)
            {
                StatusCode = status,
            };
        }

        public ObjectResult Response(Dictionary<string, List<string>> errors, string title, int status)
        {
            var result = new ApiResponse
            {
                StatusCode = status,
                Message = title,
                ResponseException = title,
                IsError = true,
                Version = "1.0",
                Result = errors
            };
            return new ObjectResult(result)
            {
                StatusCode = status,
            };
        }



    }
}