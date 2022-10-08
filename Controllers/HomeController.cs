using Microsoft.AspNetCore.Mvc;

namespace HostingExersiceAzure.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}