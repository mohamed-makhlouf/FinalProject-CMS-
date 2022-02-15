using Microsoft.AspNetCore.Mvc;

namespace CMS.PL.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
