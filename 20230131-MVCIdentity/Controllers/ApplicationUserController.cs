using _20230131_MVCIdentity.Areas.Identity.Data;
using _20230131_MVCIdentity.Repositories.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace _20230131_MVCIdentity.Controllers
{
    public class ApplicationUserController : Controller
    {
        private readonly IApplicationUserRepository userRepository;
        private readonly IRepository<Article> articleRepository;
        public ApplicationUserController(IApplicationUserRepository userRepository, IRepository<Article> articleRepository)
        {
            this.userRepository = userRepository;
            this.articleRepository = articleRepository;
        }

        [Authorize]
        public IActionResult Index()
        {
            var usermail = User.Identity.Name;
            ViewBag.v = usermail;

            return View();
        }

        public IActionResult Create()
        {
            ViewData["UserId"] = new SelectList(articleRepository.GetAll(), "Id", "Title","Content");
            return View();
        }
        [HttpPost]
        public IActionResult Create(ApplicationUser applicationUser)
        {

            userRepository.Add(applicationUser);
            return RedirectToAction(nameof(Index));
        }
    }
}
