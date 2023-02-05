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

		public List<T> ListAll(Expression<Func<T, bool>> filter)
		{
			return db.Set<T>().Where(filter).ToList();
		}

		public List<T> ListAll()
        {
            return db.Set<T>().ToList();
        }

        bool IRepository<T>.Add(T entity)
        {
            db.Add(entity);
            return db.SaveChanges()>0;
        }

        bool IRepository<T>.Delete(T entity)
        {
            db.Remove(entity);
            return db.SaveChanges() > 0;

        }

        IEnumerable<T> IRepository<T>.GetAll()
        {
            throw new NotImplementedException();
        }

        T IRepository<T>.GetById(int id)
        {
            return db.Set<T>().Find(id);
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
            db.Update(entity);
            return db.SaveChanges() > 0;
        }
    }
}
