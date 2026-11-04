using Microsoft.AspNetCore.Identity;
using Qecomvers.Business.DTOs.User;
using Qecomvers.Business.Services.Interfaces;
using Qecomvers.Core.Entities;
using Qecomvers.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qecomvers.Business.Services.Implements
{
    public class UserService : IUserService
    {
        private readonly IUserRepository<AppUser> _repository;

        public UserService(IUserRepository<AppUser> repository)
        {
            _repository = repository;
        }

        public async Task<SignInResult> LoginAsync(LoginDTO loginDTO)
        {
            var user = await _repository.FindByEmailAsync(loginDTO.EmailOrUsername)
                       ?? await _repository.FindByNameAsync(loginDTO.EmailOrUsername);

            if (user is null)
            {
                return SignInResult.Failed;
            }

            return await _repository.UserSignInAsync(user, loginDTO.Password, false);
        }

        public async Task<AppUser> RegisterAsync(RegisterDTO registerDTO)
        {
            var user = new AppUser
            {
                UserName = registerDTO.Email,
                Email = registerDTO.Email,
                Name = registerDTO.Name,
                Surname = registerDTO.Surname ?? string.Empty,
                BirthDate = registerDTO.BirthDate ?? default
            };

            var result = await _repository.RegisterAsync(user, registerDTO.Password);
            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    throw new InvalidOperationException(error.Description);
                }
            }

            return user;
        }
    }
}
