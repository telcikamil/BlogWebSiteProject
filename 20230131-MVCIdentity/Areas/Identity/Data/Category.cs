namespace _20230131_MVCIdentity.Areas.Identity.Data
{
    public class Category
    {
        public Category()
        {
            Articles = new HashSet<Article>();
            Users = new HashSet<User>();
        }
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Article> Articles { get; set; }
        public ICollection<User> Users { get; set; }
    }
}
