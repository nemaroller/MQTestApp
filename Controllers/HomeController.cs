
using Microsoft.AspNetCore.Mvc;


namespace MQTestApp.Controllers
{
    public class HomeController : Controller {
        public IActionResult Index() {
            return View();
        }
    }
}