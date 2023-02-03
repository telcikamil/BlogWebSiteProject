using _20230131_MVCIdentity.Areas.Identity.Data;
using _20230131_MVCIdentity.Repositories.Abstract;
using System.Linq.Expressions;

namespace _20230131_MVCIdentity.Repositories.Concrete
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        private readonly ApplicationDbContext db;
        public GenericRepository(ApplicationDbContext db)
        {
            this.db = db;
        }

        bool IRepository<T>.Add(T entity)
        {
            throw new NotImplementedException();
        }

        bool IRepository<T>.Delete(T entity)
        {
            throw new NotImplementedException();
        }

        IEnumerable<T> IRepository<T>.GetAll()
        {
            throw new NotImplementedException();
        }

        T IRepository<T>.GetById(int id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<T> IRepository<T>.GetWhere(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        T IRepository<T>.SingleOrDefault(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        bool IRepository<T>.Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
