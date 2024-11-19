using Csharp_Learnings.Class;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Csharp_Learnings.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExtensionMethodsController : ControllerBase
    {
        [HttpGet]
        public IActionResult ExtensionMethodCheckNullOrEmpty(string? valueToCheck =null)
        {
            bool result =  valueToCheck.checkNullOrEmpty();
            return Ok(result);

        }
    }
}
