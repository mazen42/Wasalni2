using Microsoft.AspNetCore.Identity;
using Wasalni.Infrastructure.Interfaces;
using Wasalni_DataAccess.Data;
using Wasalni_Models;

namespace Wasalni.Infrastructure.Repositories
{
    public class ApplicationUserRepository : IApplicationUser
    {
        private readonly UserManager<ApplicationUser> _userManager;
        public ApplicationUserRepository(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }
        public async Task<IdentityResult> Create(ApplicationUser obj,string Password)
        {
            IdentityResult userCreate = await _userManager.CreateAsync(obj,Password);
            return userCreate;
                
        }
    }
}