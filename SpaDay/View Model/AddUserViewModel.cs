using System.ComponentModel.DataAnnotations;

namespace SpaDay.View_Model
{
    public class AddUserViewModel
    {
        [Required]

        [StringLength(15, MinimumLength = 5, ErrorMessage = "Username must be 5 to 15 characters.")]
        public string Username { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "Password must be 6 to 20 characters.")]
        public string Password { get; set; }
        [Required]
        public string VerifyPassword { get; set; }
    }

    
}
