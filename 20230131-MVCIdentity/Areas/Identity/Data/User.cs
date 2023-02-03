using Microsoft.AspNetCore.Identity;

namespace _20230131_MVCIdentity.Areas.Identity.Data
{
	public class User : IdentityUser
	{
        public User()
        {
            Articles = new HashSet<Article>();
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string? FilePath { get; set; }

        public ICollection<Article> Articles { get; set; }
    }
}
