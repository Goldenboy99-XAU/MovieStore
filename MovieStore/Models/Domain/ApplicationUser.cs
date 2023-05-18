using Microsoft.AspNetCore.Identity;

namespace MovieStore.Models.Domain
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
    }
}
