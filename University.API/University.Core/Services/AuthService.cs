using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using University.Core.DTOs;
using University.Core.Exceptions;
using University.Core.Forms;
using University.Core.Services.Interfaces;
using University.Core.Validations;
using University.Data.Entities.Identity;

namespace University.Core.Services
{
    public class AuthService : IAuthService
    {
        private readonly SignInManager<User> _signInManager;
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<Role> _roleManager;
        public AuthService(SignInManager<User> signInManager, UserManager<User> userManager, RoleManager<Role> roleManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _roleManager = roleManager;
        }


        public async Task<UserDto> Login(LoginForm form)
        {
            // Validations
            if (form == null)
                throw new ArgumentNullException(nameof(form));
            var validation = FormValidator.Validate(form);
            if (!validation.IsValid)
                throw new BusinessException(validation.Errors);

            //Logic
            var result = await _signInManager.PasswordSignInAsync(form.Email, form.Password, true, lockoutOnFailure: false);
            if (result.IsLockedOut)
                throw new BusinessException("Account is Locked Out");

            if (result.IsNotAllowed)
                throw new BusinessException("Account is Not Allowed to login");


            if (!result.Succeeded)
                throw new BusinessException("Invalid login attempt");


            var user = await _userManager.FindByEmailAsync(form.Email);
            if (user == null)
                throw new NotFoundException("Unable to account with this email");

            var dto = new UserDto
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                Phone = user.PhoneNumber,
                PhoneConfirmed = user.PhoneNumberConfirmed,
                EmailConfirmed = user.EmailConfirmed,
            };

            // Return
            return dto;
        }


        public async Task<UserDto> Register(RegisterForm form)
        {
            // Validations
            if (form == null)
                throw new ArgumentNullException(nameof(form));
            var validation = FormValidator.Validate(form);
            if (!validation.IsValid)
                throw new BusinessException(validation.Errors);

            var userExists = await _userManager.FindByEmailAsync(form.Email);
            if (userExists != null)
                throw new BusinessException($"User already exists with this email : {form.Email}");


            // Logic
            var user = new User
            {
                Email = form.Email,
                FirstName = form.FirstName,
                LastName = form.LastName,
                UserName = form.Email
            };
            var result = await _userManager.CreateAsync(user, form.Password);
            if (!result.Succeeded)
            {
                throw new BusinessException(result.Errors
                    .GroupBy(x => x.Code)
                    .ToDictionary(x => x.Key, y => y.Select(z =>z.Description).ToList()));
            }

            if (!await _roleManager.RoleExistsAsync(form.Role)) {
                await _roleManager.CreateAsync(new Role { Name = form.Role });
            }
            await _userManager.AddToRoleAsync(user, form.Role);


            return new UserDto
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                Phone = user.PhoneNumber,
                PhoneConfirmed = user.PhoneNumberConfirmed,
                EmailConfirmed = user.EmailConfirmed,
            };
        }


        public UserDto Me(ClaimsPrincipal user)
        {

            var idClaim = user.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (!int.TryParse(idClaim, out int userId))
                throw new BusinessException("Invalid token: User ID not found");

            var userEntity = _userManager.Users.FirstOrDefault(u => u.Id == userId);

            if (userEntity is null)
                throw new NotFoundException("User not found");

            return new UserDto
            {
                Id = userEntity.Id,
                Email = userEntity.Email,
                FirstName = userEntity.FirstName,
                LastName = userEntity.LastName,
                Phone = userEntity.PhoneNumber,
                EmailConfirmed = userEntity.EmailConfirmed,
                PhoneConfirmed = userEntity.PhoneNumberConfirmed

            };
        }


    }
}
