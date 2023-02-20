using _20230131_MVCIdentity.Areas.Identity.Data;
using _20230131_MVCIdentity.Models;
using _20230131_MVCIdentity.Repositories.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using NuGet.Packaging.Signing;
using System.Security.Claims;

namespace _20230131_MVCIdentity.Controllers
{
    public class BlogController : Controller
    {
        private readonly IBlogRepository blogRepository;
        private readonly ICategoryRepository categoryRepository;
        private readonly IUserRepository userRepository;
        public BlogController(IBlogRepository blogRepository, ICategoryRepository categoryRepository,IUserRepository userRepository)
        {
            this.blogRepository = blogRepository;
            this.categoryRepository = categoryRepository;
            this.userRepository = userRepository;
            
        }
        public IActionResult Index()
        {
            var articles = blogRepository.TopReadBlog();
            var categories = categoryRepository.GetAll();
            ArticleIndexVM articleIndexVM = new ArticleIndexVM();
            articleIndexVM.Categories = categories;
            articleIndexVM.Articles = articles;
            return View(articleIndexVM);
        }
        public IActionResult BlogDetails(int id)
        {
            var values = blogRepository.GetBlogById(id);
            var user = userRepository.GetById(values.UserId);


            BlogDetailsVM blogDetailsVM = new BlogDetailsVM();
            values.ViewCount++;
            blogDetailsVM.viewcount = values.ViewCount;
            blogDetailsVM.userId = values.UserId;
            blogDetailsVM.creationDate = values.CreationDate;
            blogDetailsVM.title = values.Title;
            blogDetailsVM.content = values.Content;
            blogDetailsVM.userFirstName = user.FirstName;
            blogDetailsVM.userLastName = user.LastName;
            blogRepository.Update(values);
            return View(blogDetailsVM);
        }
        public IActionResult Create() 
        {
            var userID = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var category = categoryRepository.GetAll();
            if(userID == null)
            {
                return LocalRedirect("~/Identity/Account/Register");
            }
            User user = userRepository.GetById(userID);
            ArticleCreateVM articleCreateVM = new ArticleCreateVM();
            articleCreateVM.Categories = category;
            articleCreateVM.UserId = userID;
            return View(articleCreateVM);
        }

        [HttpPost]
        public ActionResult Create(ArticleCreateVM articleCreateVM, int[] ids)
        {
            Article article = new Article();
            article.Title = articleCreateVM.Title;
            article.Content = articleCreateVM.Content;
            article.UserId = articleCreateVM.UserId;
            List<Category> categories = new List<Category>();
            foreach (var item in ids)
            {
                var category = categoryRepository.GetById(item);
                categories.Add(category);
            }
            article.Categories = categories;
            blogRepository.Add(article);
            return RedirectToAction(nameof(Index));
        }

        public ActionResult FavoriteBlogs()
        {
            var Id = User.FindFirstValue(ClaimTypes.NameIdentifier);
            ViewBag.UserCategories = userRepository.GetByIdIncludeCategory(Id);
            var categories = categoryRepository.GetAll();
            FavoriteBlogsByCategoryVM favoriteBlogs = new FavoriteBlogsByCategoryVM();
            favoriteBlogs.Id = Id;
            favoriteBlogs.Categories = categories;
            HashSet<Article> articleList = new HashSet<Article>();
            
            var user = userRepository.GetByIdIncludeCategory(Id);
            var selectedCategories = user.Categories;
            foreach (var item in selectedCategories)
            {

                var articles = blogRepository.getSelectedArticleByCategory(item.Id);
                foreach (var item2 in articles)
                {
                    articleList.Add(item2);
                }
                
            }
            favoriteBlogs.articles = articleList;


            return View(favoriteBlogs);
        }




        [HttpPost]
        public ActionResult GetCheckBoxes(string Id, int[] ids)
        {

            User user = new User();
            user = userRepository.GetByIdIncludeCategory(Id);
            HashSet<Category> categories = new HashSet<Category>();
            foreach (var item in ids)
            {
                var category = categoryRepository.GetById(item);
                categories.Add(category);
            }
            user.Categories = categories;
            var returner = userRepository.Update(user);
            return RedirectToAction(nameof(FavoriteBlogs));

        }


        
    }
}
