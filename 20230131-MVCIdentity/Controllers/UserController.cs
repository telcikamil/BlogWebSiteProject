using _20230131_MVCIdentity.Areas.Identity.Data;
using _20230131_MVCIdentity.Models;
using _20230131_MVCIdentity.Repositories.Abstract;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace _20230131_MVCIdentity.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserRepository userRepository;
        private readonly IBlogRepository blogRepository;
        private readonly ICategoryRepository categoryRepository;
        public UserController(IUserRepository userRepository, ICategoryRepository categoryRepository,IBlogRepository blogRepository)
        {
            this.userRepository = userRepository;
            this.blogRepository = blogRepository;
            this.categoryRepository = categoryRepository;
        }
        public IActionResult Index(string id)
        {
            var userid = id;
            var currentid = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (id == null)
            {
                userid = currentid;
            }

            
            var user = userRepository.GetById(userid);

            var firstname = user.FirstName;
            var userName = User.FindFirstValue(ClaimTypes.Name);
            var articles = blogRepository.GetArticleByCurrentUser(userid);

            UserIndexVM userIndexVM = new UserIndexVM();

            userIndexVM.Articles = articles;
            userIndexVM.UserId = userid;
            userIndexVM.userName = userName;
            userIndexVM.FirstName = firstname;
            userIndexVM.LastName =user.LastName;
            userIndexVM.currentId = currentid;
            userIndexVM.imagePath = user.FilePath;
            userIndexVM.email = user.UserName;
            userIndexVM.job = user.Job;
            userIndexVM.Phone = user.PhoneNumber;
            
            

            return View(userIndexVM);
        }

        public IActionResult Delete(int id)
        {
            var article = blogRepository.GetBlogById(id);
            bool returner = blogRepository.Delete(article);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Update(int id)
        {
            var userID = User.FindFirstValue(ClaimTypes.NameIdentifier);
            ViewBag.ArticleCategories = blogRepository.GetByIdIncludeCategory(id);
            var article = blogRepository.GetBlogById(id);
            var category = categoryRepository.GetAll();
            var selectedCategory = article.Categories;
            if (userID == null)
            {
                return LocalRedirect("~/Identity/Account/Register");
            }
            User user = userRepository.GetById(userID);
            ArticleCreateVM articleCreateVM = new ArticleCreateVM();
            articleCreateVM.Categories = category;
            articleCreateVM.Title = article.Title;
            articleCreateVM.Content = article.Content;
            articleCreateVM.Id = id;
            articleCreateVM.UserId = userID;
            return View(articleCreateVM);
        }

        [HttpPost]
        public IActionResult Update(ArticleCreateVM articleCreateVM, int[] ids, int id)
        {
            var userID = User.FindFirstValue(ClaimTypes.NameIdentifier);
            Article article = new Article();
            article = blogRepository.GetByIdIncludeCategory(articleCreateVM.Id);
            article.Id = articleCreateVM.Id;
            article.Title = articleCreateVM.Title;
            article.Content = articleCreateVM.Content;
            article.UserId = userID;
            HashSet<Category> categories = new HashSet<Category>();
            foreach (var item in ids)
            {
                var category = categoryRepository.GetById(item);
                categories.Add(category);
            }
            article.Categories = categories;
            blogRepository.Update(article);
            return RedirectToAction(nameof(Index));
        }
    }
}
