using _20230131_MVCIdentity.Areas.Identity.Data;

namespace _20230131_MVCIdentity.Models
{
	public class FavoriteBlogsByCategoryVM
	{
		public string Id { get; set; }
		public IEnumerable<Category> Categories { get; set; }
		public IEnumerable<Article> selectedArticles { get; set; }
		public IEnumerable<Article> articles { get; set; }
	}
}
