using Microsoft.AspNet.Identity.EntityFramework;
//7th comment
namespace PartsUnlimited.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
    }
}