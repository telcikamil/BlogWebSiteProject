using _20230131_MVCIdentity.Areas.Identity.Data;
using _20230131_MVCIdentity.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;

namespace _20230131_MVCIdentity.Repositories.Concrete
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        private readonly ApplicationDbContext db;
        public UserRepository(ApplicationDbContext db):base(db)
        {
            this.db = db;
        }
        public IEnumerable<User> GetAllIncludeUsers()
        {
            throw new NotImplementedException();
        }

        public User GetById(string id)
        {
            return db.Set<User>().FirstOrDefault(x=>x.Id ==id);
        }

        public User GetByIdIncludeCategory(string id)
        {
            return db.Set<User>().Include(a => a.Categories).FirstOrDefault(a => a.Id == id);
        }


    }
}
