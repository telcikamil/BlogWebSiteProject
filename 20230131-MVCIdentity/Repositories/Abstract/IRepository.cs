﻿using System.Linq.Expressions;

namespace _20230131_MVCIdentity.Repositories.Abstract
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        //T GetById(int id);
        bool Add(T entity);
        bool Update(T entity);
        bool Delete(T entity);
        IEnumerable<T> GetWhere(Expression<Func<T, bool>> predicate);
        T SingleOrDefault(Expression<Func<T, bool>> predicate);
        List<T> ListAll();
        List<T> ListAll(Expression<Func<T, bool>> filter);
    }
}
