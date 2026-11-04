using Microsoft.AspNetCore.Identity;
using Qecomvers.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qecomvers.Core.Repositories
{
    public class UserRepository : UserGenericRepository<AppUser>
    {
        public UserRepository(UserManager<AppUser> userManager, Microsoft.AspNetCore.Identity.SignInManager<AppUser> signInManager)
            : base(userManager, signInManager)
        {
        }
    }
}
