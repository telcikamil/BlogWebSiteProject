﻿using _20230131_MVCIdentity.Areas.Identity.Data;

namespace _20230131_MVCIdentity.Repositories.Abstract
{
    public interface IUserRepository : IRepository<User>
    {
        IEnumerable<User> GetAllIncludeUsers();
        public User GetById(string id);
        public User GetByIdIncludeCategory(string id);
    }
}
