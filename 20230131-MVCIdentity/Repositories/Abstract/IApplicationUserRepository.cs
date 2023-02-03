using _20230131_MVCIdentity.Areas.Identity.Data;

namespace _20230131_MVCIdentity.Repositories.Abstract
{
    public interface IApplicationUserRepository: IRepository<ApplicationUser>
    {
        //IEnumerable<ApplicationUser> GetAllIncludeArticles();

        //ApplicationUser GetByIdIncludeArticle(Guid id);
    }
}
