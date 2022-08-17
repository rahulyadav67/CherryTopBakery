using Microsoft.AspNetCore.Mvc;

namespace CherryTopBakery.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
