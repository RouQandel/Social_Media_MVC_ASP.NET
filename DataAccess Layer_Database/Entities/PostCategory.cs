using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess_Layer_Database.Entities
{
    public class PostCategory
    {
        public int CategoryId { get; set; }

        [ForeignKey(nameof(Post))]
        public int PostId { get; set; }

        //Navigation Property
        public Category Category { get; set; }
        public Post Post { get; set; }
        
    }
}
