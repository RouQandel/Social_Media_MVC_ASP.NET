using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess_Layer_Database.Entities
{
    [Table ("User")]
    public class User : IdentityUser<int>
    {
        //classes
        [Key]
        public int Id { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string ProfilePicture { get; set; } 
        public string bio { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public int BirthDay { get; set; }
        public int BirthMonth { get; set; }
        public int BirthYear { get; set; }
        public string PhoneNumber { get; set; }
        public string About { get; set; }

        //Navigation Property
        public List<Likes> Likes{ get; set; }
        public List<Posts> Posts { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}
