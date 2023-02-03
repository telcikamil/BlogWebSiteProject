using _20230131_MVCIdentity.Repositories.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace _20230131_MVCIdentity.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryRepository categoryRepository;
        public CategoryController(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }
        public IActionResult Index()
        {
            var values = categoryRepository.ListAll();
            return View(values);
        }
    }
}
