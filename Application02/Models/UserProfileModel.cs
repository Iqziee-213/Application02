using System.ComponentModel.DataAnnotations;

namespace Application02.Models
{
    public class UserProfileModel
    {
        [Required(ErrorMessage = "First name is strictly required.")]
        [StringLength(50, ErrorMessage = "First name cannot exceed 50 characters.")]
        public string FirstName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Last name is strictly required.")]
        [StringLength(50, ErrorMessage = "Last name cannot exceed 50 characters.")]
        public string LastName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Email address is required.")]
        [EmailAddress(ErrorMessage = "Please input a valid email address structure (e.g., user@domain.com).")]
        public string Email { get; set; } = string.Empty;
    }
}