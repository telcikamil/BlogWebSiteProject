using _20230131_MVCIdentity.Repositories.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace _20230131_MVCIdentity.Controllers
{
    public class BlogController : Controller
    {
        private readonly IBlogRepository blogRepository;
        public BlogController(IBlogRepository blogRepository)
        {
            this.blogRepository = blogRepository;
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
    }
}
