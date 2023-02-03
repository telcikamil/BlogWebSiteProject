using _20230131_MVCIdentity.Areas.Identity.Data;
using _20230131_MVCIdentity.Repositories.Abstract;

namespace _20230131_MVCIdentity.Repositories.Concrete
{
    public class ApplicationUserRepository : GenericRepository<ApplicationUser>,IApplicationUserRepository
    {
        private readonly ApplicationDbContext db;
        public ApplicationUserRepository(ApplicationDbContext db):base(db)
        {
            this.db = db;
        }

        public IEnumerable<ApplicationUser> GetAllIncludeArticles()
        {
            throw new NotImplementedException();
        }

        public ApplicationUser GetByIdIncludeArticle(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
