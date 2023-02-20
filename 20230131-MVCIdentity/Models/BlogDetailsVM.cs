using _20230131_MVCIdentity.Areas.Identity.Data;

namespace _20230131_MVCIdentity.Models
{
    public class BlogDetailsVM
    {
        public IEnumerable<Article> articles { get; set; }
        public int? viewcount { get; set; } = 0;
        public string userId { get; set; }
        public string title { get; set; }
        public string content { get; set; }
        public string userFirstName { get; set; }
        public string userLastName { get; set; }

        public DateTime? creationDate { get; set; }

    }
}
