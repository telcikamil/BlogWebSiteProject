using _20230131_MVCIdentity.Areas.Identity.Data;

namespace _20230131_MVCIdentity.Repositories.Abstract
{
	public interface IBlogRepository : IRepository<Article>
	{
		IEnumerable<Article> GetAllIncludeCategories();
		public Article GetBlogById(int id);

		IEnumerable<Article> TopReadBlog();
		IEnumerable<Article> TopReadBlogByDatetime();

		IEnumerable<Article> GetFavoriteCategory(string UserId);
		Article GetByIdIncludeCategory(int Id);

		IEnumerable<Article> getSelectedArticleByCategory(int id);

		IEnumerable<Article> GetArticleByCurrentUser(string UserId);

	

	}
}
