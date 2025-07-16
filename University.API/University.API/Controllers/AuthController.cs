using AutoWrapper.Wrappers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using University.API.Filters;
using University.API.Helpers;
using University.Core.DTOs;
using University.Core.Forms;
using University.Core.Services.Interfaces;

namespace University.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [TypeFilter(typeof(ApiExceptionFilter))]
    public class AuthController : ControllerBase
    {
        public readonly IAuthService _authService;
        public readonly IJwtTokenHelper _jwtTokenHelper;
        public AuthController(IAuthService authService, IJwtTokenHelper jwtTokenHelper) 
        { 
            _authService = authService;
            _jwtTokenHelper = jwtTokenHelper;
        }



        [HttpPost("login")]
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ApiResponse> Login([FromBody]LoginForm form)
        {
            var user = await _authService.Login(form);
            var token = _jwtTokenHelper.GenerateToken(user);

            return new ApiResponse(token, StatusCodes.Status200OK);
        }


        [HttpPost("register")]
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ApiResponse> Register([FromBody] RegisterForm form)
        {
            var user = await _authService.Register(form);
            var token = _jwtTokenHelper.GenerateToken(user);

            return new ApiResponse(token, StatusCodes.Status200OK);
        }



        [Authorize]
        [HttpGet("me")]
        [ProducesResponseType(typeof(UserDto), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ApiResponse Me()
        {
            var userDto = _authService.Me(User);
            return new ApiResponse(userDto);
        }


    }
}
