using Microsoft.AspNetCore.Mvc;

namespace _20230131_MVCIdentity.Controllers
{
    public class AboutUsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
