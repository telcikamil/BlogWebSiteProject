using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace _20230131_MVCIdentity.Areas.Identity.Data
{
	public class User : IdentityUser
	{
        public User()
        {
            Articles = new HashSet<Article>();
            Categories = new HashSet<Category>();
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? Job { get; set; }
        public string? FilePath { get; set; }
        [NotMapped]
        public IFormFile formFile { get; set; }
        public ICollection<Article> Articles { get; set; }
        public ICollection<Category> Categories { get; set; }
    }
}
