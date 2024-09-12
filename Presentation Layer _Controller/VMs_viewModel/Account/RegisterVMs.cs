using System.ComponentModel.DataAnnotations;

namespace Presentation_Layer__Controller.VMs_viewModel.Account
{
    public class RegisterVMs
    {
        [Required(ErrorMessage = " UserName is required")]
        [StringLength(250, ErrorMessage = "UserName cannot be longer than 250 characters")]
        [Display(Name = " Username")]
        public string UserName { get; set; }


        [Required(ErrorMessage = "First Name is required")]
        [Display(Name = " FirstName")]
        [StringLength(50, ErrorMessage = "First Name cannot be longer than 50 characters")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required")]
        [Display(Name = " LastName")]
        [StringLength(50, ErrorMessage = "Last Name cannot be longer than 50 characters")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [Display(Name = " Email")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Phone Number is required")]
        [Display(Name = " PhoneNumber")]
        [Phone(ErrorMessage = "Invalid Phone Number")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Day is required")]
        public int BirthDay { get; set; }

        [Required(ErrorMessage = "Month is required")]
        public int BirthMonth { get; set; }

        [Required(ErrorMessage = "Year is required")]
        public int BirthYear { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirm Password is required")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }
}
