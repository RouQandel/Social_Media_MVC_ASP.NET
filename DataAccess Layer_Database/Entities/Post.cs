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
    public class Posts
    {
        [Key]
        public int PostID { get; set; }

        [ForeignKey(nameof(User))]
        public int Id { get; set; }
        public int CommentID { get; set; }
        public string Title { get; set; }
        public string thumbnail { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int LikeCount { get; set; }
        public bool IsEdited { get; set; }
        public bool IsDeleted { get; set; }
        public string AttachmentPath { get; set; }
        public string PostType { get; set; }
        public bool IsPublished { get; set; } = false;

        //Navigation Property
        public User user { get; set; }
        public Likes like {  get; set; }
        public List<Contents> Contents { get; set; }
        public ICollection<Comment> Comments { get; set; }
        ICollection<PostTag> postTags { get; set; }
        ICollection<PostCategory> postCategories{ get; set; }
    }
}
