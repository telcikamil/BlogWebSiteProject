using _20230131_MVCIdentity.Areas.Identity.Data;
using _20230131_MVCIdentity.Repositories.Abstract;

namespace _20230131_MVCIdentity.Repositories.Concrete
{
    public class ArticleRepository : GenericRepository<Article>, IArticleRepository
    {
        private readonly ApplicationDbContext db;
        public ArticleRepository(ApplicationDbContext db): base(db)
        {
            this.db = db;
        }

        public IEnumerable<Article> GetAllIncludeArticles()
        {
            throw new NotImplementedException();
        }
    }
}
