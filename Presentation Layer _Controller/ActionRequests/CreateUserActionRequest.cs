using System.ComponentModel.DataAnnotations;

namespace Presentation_Layer__Controller.ActionRequests
{
    public class CreateUserActionRequest
    {
        [Required(ErrorMessage = "There is an issue with either the Username or Email.")]
        // 34an at2akd an kol haga atb3at 
        [StringLength(100 , ErrorMessage ="name cannot exceed 100 characters")]

        public int UserID { get; set; }

        [Required(ErrorMessage = "There is an issue with either the Username or Email.")]
        public string UserName { get; set; }


        [Required(ErrorMessage = "FirstName is required")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "LastName is required")]
        public string LastName { get; set; }
        
        public string FullName { get { return $"{FirstName} {LastName}"; } }

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }

        [Required(ErrorMessage = "There is an issue with either the Username or Email.")]
        public string Email { get; set; }
        public string ProfilePicture { get; set; } // byte[]??
        public string bio { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
    }
}
