using _20230131_MVCIdentity.Areas.Identity.Data;

namespace _20230131_MVCIdentity.Models
{
    public class ArticleCreateVM
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string UserId { get; set; }
        public IEnumerable<Article> Articles { get; set; }

    }
}
