using System.ComponentModel.DataAnnotations;

namespace MovieStore.Models.Domain.DTO
{
    public class Login
    {
        [Required]
        public string? Username { get; set; }

        [Required]
        public string? Password { get; set; }
        [Required]
    }
}
