using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess_Layer_Database.Entities
{
    [Table("post")]
    public class Post
    {
        [Key]
        public int Id { get; set; }
        public int PostID { get; set; }
        public int CommentID { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int LikeCount { get; set; }
        public bool IsEdited { get; set; }
        public bool IsDeleted { get; set; }
        public string AttachmentPath { get; set; }
        public string PostType { get; set; }

        //Navigation Property
        public Likes like {  get; set; }
        public List<Contents> Contents { get; set; }
        List<Comment> comments { get; set; }
    }
}
