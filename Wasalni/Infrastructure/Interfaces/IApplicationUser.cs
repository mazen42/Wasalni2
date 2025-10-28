using Microsoft.AspNetCore.Identity;
using Newtonsoft.Json.Bson;
using Wasalni_Models;

namespace Wasalni.Infrastructure.Interfaces
{
    public interface IApplicationUser
    {
        Task<IdentityResult> Create(ApplicationUser obj,string Password);
    }
}
