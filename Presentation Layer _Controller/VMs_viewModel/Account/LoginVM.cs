using System.ComponentModel.DataAnnotations;

namespace Presentation_Layer__Controller.VMs_viewModel.Account
{
    public class LoginVM
    {
        [Required(ErrorMessage = " Username is required.")]
        [Display(Name = " Username")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Email  is required.")]
        [Display(Name = "Email ")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Remember Me")]
        public bool RememberMe { get; set; }

        public string ReturnUrl { get; set; }

    }
}
