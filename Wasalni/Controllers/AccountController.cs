using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Wasalni_Models;

namespace Wasalni.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        [HttpPost]
        public IActionResult Register(ApplicationUser obj)
        {
            if (ModelState.IsValid)
                return BadRequest(ModelState);


        }
    }
}
