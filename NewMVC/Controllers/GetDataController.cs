using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace NewMVC.Controllers
{

    [Authorize]
    public class GetDataController : Controller
    {
        public IActionResult Index()
        {
            return Ok("fatma");
        }
    }
}
