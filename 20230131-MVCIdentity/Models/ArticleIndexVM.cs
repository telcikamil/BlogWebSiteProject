using _20230131_MVCIdentity.Areas.Identity.Data;

namespace _20230131_MVCIdentity.Models
{
	public class ArticleIndexVM
	{
        public int Id { get; set; }
        public string Title { get; set; }
        public IEnumerable<Article> Articles { get; set; }
        public IEnumerable<Category> Categories { get; set; }
    }
}
