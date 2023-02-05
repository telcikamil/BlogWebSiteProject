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

		
	}
}
