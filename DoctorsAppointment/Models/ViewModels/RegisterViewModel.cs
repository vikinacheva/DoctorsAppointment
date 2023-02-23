using System.ComponentModel.DataAnnotations;

namespace DoctorsAppointment.Models.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        public string? Name { get; set; }
        [Required]
        [EmailAddress]
        public string? Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long!", MinimumLength = 8)]
        public string? Password { get; set; }
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [Compare("Password", ErrorMessage = "The password and the confirmation password do not match!")]
        public string? ConfirmPassword { get; set; }
        [Required(ErrorMessage = "Please select a role!")]
        [Display(Name = "Role Name")]
        public string? RoleName { get; set; }
    }
}
