using _20230131_MVCIdentity.Areas.Identity.Data;

namespace _20230131_MVCIdentity.Models
{
    public class UserIndexVM
    {
        public string userName { get; set; }
        public string UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }    
        public string Job { get; set; }
        public string imagePath { get; set; }
        public string currentId { get; set; }
        public string email { get; set; }
        public string job { get; set; }
        public string Phone { get; set; }
        public int articleId { get; set; }
        public IEnumerable<Article> Articles { get; set; }
        public IEnumerable<Category> Categories { get; set; }

        public IEnumerable<User> Users { get; set; }    
    }
}
