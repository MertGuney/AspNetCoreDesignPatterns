using Microsoft.AspNetCore.Identity;

namespace WebApp.TemplatePattern.Models
{
    public class AppUser : IdentityUser
    {
        public string PictureUrl { get; set; }
        public string Description { get; set; }
    }
}
