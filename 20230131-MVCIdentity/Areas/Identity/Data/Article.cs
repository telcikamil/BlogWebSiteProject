namespace _20230131_MVCIdentity.Areas.Identity.Data
{
    public class Article
    {
        public Article()
        {
            Categories = new HashSet<Category>();
        }
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int ViewCount { get; set; }
        public int ViewTime { get; set; }
        public DateTime CreationDate { get; set; }
        public ApplicationUser User { get; set; }
        public ICollection<Category> Categories { get; set; }
    }
}
