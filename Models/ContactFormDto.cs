using System.ComponentModel.DataAnnotations;

namespace personal_portfolio_v2.Models
{
    public class ContactFormDto
    {
        [Required(ErrorMessage = "Name is required.")]
        [StringLength(100, ErrorMessage = "Name must be at most 100 characters.")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid email address.")]
        [StringLength(254, ErrorMessage = "Email must be at most 254 characters.")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Message is required.")]
        [StringLength(5000, MinimumLength = 10, ErrorMessage = "Message must be between 10 and 5000 characters.")]
        public string Message { get; set; } = string.Empty;
    }
}
