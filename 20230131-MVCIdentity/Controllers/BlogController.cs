using _20230131_MVCIdentity.Areas.Identity.Data;
using _20230131_MVCIdentity.Repositories.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Security.Claims;

namespace _20230131_MVCIdentity.Controllers
{
    public class BlogController : Controller
    {
        private readonly IBlogRepository blogRepository;
        private readonly ICategoryRepository categoryRepository;
        public BlogController(IBlogRepository blogRepository, ICategoryRepository categoryRepository)
        {
            this.blogRepository = blogRepository;
            this.categoryRepository = categoryRepository;
        }
        public IActionResult Index()
        {
            var values = blogRepository.ListAll();
            return View(values);
        }
        public IActionResult BlogDetails(int id)
        {
            var values = blogRepository.GetBlogById(id);
            return View(values);
        }
        public IActionResult Create() 
        {
            var userID = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var category = categoryRepository.GetAll();
            if(userID == null)
            {
                return LocalRedirect("~/Identity/Account/Register");
            }
            //User user = 
            return View();
        }

        //[HttpPost]
        //public ActionResult Create(Article article, int[]ids)
        //{
        //    article.Title = 
        //    blogRepository.Add(article);
        //    return RedirectToAction(nameof(Index));
        //}

    }
}
