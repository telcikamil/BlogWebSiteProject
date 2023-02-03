using _20230131_MVCIdentity.Areas.Identity.Data;

namespace _20230131_MVCIdentity.Repositories.Abstract
{
    public interface ICategoryRepository :IRepository<Category>
    {
        IEnumerable<Category> GetAllIncludeCategories();
    }
}
