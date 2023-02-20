using _20230131_MVCIdentity.Areas.Identity.Data;

namespace _20230131_MVCIdentity.Models
{
    public class ArticleCreateVM
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string UserId { get; set; }


        public IEnumerable<Article> Articles { get; set; }
        public IEnumerable<Category> Categories { get; set; }

    }
}
