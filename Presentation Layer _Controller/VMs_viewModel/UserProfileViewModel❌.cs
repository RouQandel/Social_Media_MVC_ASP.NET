namespace Presentation_Layer__Controller.VMs_viewModel 
{
    public class UserProfileViewModel
{
    //classes
    public int UserID { get; set; }
    public string UserName { get; set; }
    public string FullName { get { return $"{FirstName} {LastName}"; } }
    public string Password { get; set; }
    public string Email{ get; set; }
    public string ProfilePicture { get; set; } // byte[]??
    public string bio { get; set; }
    public DateTime DateCreated { get; set; } = DateTime.Now;
    }
}
