using System.ComponentModel.DataAnnotations;

namespace PierreTreat.Models
{
  public class RegisterViewModel
  {
    [Required]
    [EmailAddress]
    [Display(Name = "Email")]
    public string Email { get; set; }

    [Required]
    [EmailAddress]
    [Display(Name= "Password")]
    public string Password { get; set; }

    [DataType(DataType.Password)]
    [Display(Name = "Confirm Your Password")]
    [Compare("Password", ErrorMessage = "ERROR The password and confirmation password do not match")]
    public string ConfirmPassword { get; set; }
  }
}