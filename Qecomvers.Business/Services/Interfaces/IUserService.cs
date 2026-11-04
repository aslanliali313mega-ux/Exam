using Microsoft.AspNetCore.Identity;
using Qecomvers.Business.DTOs.User;
using Qecomvers.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qecomvers.Business.Services.Interfaces
{
    public interface IUserService
    {
        Task<SignInResult> LoginAsync(LoginDTO loginDTO);
        Task<AppUser> RegisterAsync(RegisterDTO registerDTO);
    }
}
