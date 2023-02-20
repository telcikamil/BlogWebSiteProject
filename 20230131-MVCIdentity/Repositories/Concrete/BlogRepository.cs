using _20230131_MVCIdentity.Areas.Identity.Data;
using _20230131_MVCIdentity.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;

namespace _20230131_MVCIdentity.Repositories.Concrete
{
	public class BlogRepository : GenericRepository<Article>,IBlogRepository
	{
		private readonly ApplicationDbContext db;
		public BlogRepository(ApplicationDbContext db):base(db)
		{
			this.db = db;
		}

		public IEnumerable<Article> GetAllIncludeCategories()
		{
			return db.articles.Include(s=>s.Categories);
		}

		public IEnumerable<Article> GetArticleByCurrentUser(string UserId)
		{
			return db.articles.Where(a=>a.UserId == UserId);
        }

		public Article GetBlogById(int id)
		{
            return db.Set<Article>().FirstOrDefault(x => x.Id == id);
        }


		public IEnumerable<Article> GetFavoriteCategory(string UserId)
		{
			var user = db.Set<User>().Include(a => a.Categories).FirstOrDefault(a => a.Id == UserId);
			var categories = user.Categories;
			List<Article> articleList = new List<Article>();

			foreach (var item in categories)
			{
				var articles = db.articles.Include(a => a.Categories).Where(a => a.Categories.Any(b => b.Id == item.Id));
				foreach (var article in articles)
				{
					if (!articleList.Any(a=>a.Id == article.Id))
					{
						articleList.Add(article);
					}
				}
			}
			return articleList;
		}

		public IEnumerable<Article> getSelectedArticleByCategory(int id)
		{
			return db.articles.Include(a => a.Categories).Where(b => b.Categories.Any(b => b.Id == id));

		}

		public IEnumerable<Article> TopReadBlog()
		{

			return db.articles.OrderByDescending(a => a.ViewCount);
		}

		public IEnumerable<Article> TopReadBlogByDatetime()
		{
			return db.articles.OrderByDescending(a => a.CreationDate).Take(3);
		}

		Article IBlogRepository.GetByIdIncludeCategory(int Id)
		{
			return db.articles.Include(s => s.Categories).FirstOrDefault(a => a.Id == Id);
        }


	}
}
