using Microsoft.AspNetCore.Mvc;

namespace _20230131_MVCIdentity.Controllers
{
	public class AboutController : Controller
	{
		public IActionResult AboutUs()
		{
			return View();
		}
	}
}
