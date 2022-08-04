using Microsoft.AspNetCore.Mvc;

namespace MyWebSite.Controllers
{
    public class FeatureController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
