using System.Security.Claims;
using University.Core.DTOs;
using University.Core.Forms;

namespace University.Core.Services.Interfaces
{
    public interface IAuthService
    {
        Task<UserDto> Login(LoginForm request);
        Task<UserDto> Register(RegisterForm form);
        UserDto Me(ClaimsPrincipal user);
    }
}