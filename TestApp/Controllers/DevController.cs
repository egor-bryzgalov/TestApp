using Microsoft.AspNetCore.Mvc;

namespace TestApp.Controllers
{
    public class DevController : Controller
    {
        public IActionResult Test()
        {
            return Ok("Hello World");
        }
    }
}