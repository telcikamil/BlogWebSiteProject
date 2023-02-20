using _20230131_MVCIdentity.Areas.Identity.Data;
using _20230131_MVCIdentity.Repositories.Abstract;

namespace _20230131_MVCIdentity.Repositories.Concrete
{
    public class CategoryRepository : GenericRepository<Category>,ICategoryRepository
    {
        private readonly ApplicationDbContext db;
        public CategoryRepository(ApplicationDbContext db):base(db)
        {
            this.db = db;
        }

        public IEnumerable<Category> GetAllIncludeCategories()
        {
            throw new NotImplementedException();
        }

        public Category GetById(int id)
        {
            return db.Set<Category>().FirstOrDefault(x => x.Id == id);
        }
    }
}
