using Microsoft.Build.Framework;

namespace _20230131_MVCIdentity.Areas.Identity.Data
{
    public class Article
    {
        public Article()
        {
            Categories = new HashSet<Category>();
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int? ViewCount { get; set; } = 0;
        public int? ViewTime { get; set; } = 0;
        public string UserId { get; set; }
        public User User { get; set; }
        public DateTime? CreationDate { get; set; } = DateTime.Now;
        public ICollection<Category> Categories { get; set; }
    }
}
