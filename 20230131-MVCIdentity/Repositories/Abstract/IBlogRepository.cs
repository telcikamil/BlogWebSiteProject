using _20230131_MVCIdentity.Areas.Identity.Data;

namespace _20230131_MVCIdentity.Repositories.Abstract
{
	public interface IBlogRepository : IRepository<Article>
	{
		IEnumerable<Article> GetAllIncludeCategories();

    }
}
