using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess_Layer_Database.Entities
{
    public class Likes
    {
        [Key]
        public int LikeId { get; set; }

        [ForeignKey("Posts")]
        public int PostId { get; set; }

        [ForeignKey(nameof(User))]
        public int  Id { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;

        //Navigation Property
        public User user {  get; set; }
        public List<Posts> posts { get; set; }
    }
}
