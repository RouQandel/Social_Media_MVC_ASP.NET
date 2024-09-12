using Azure;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess_Layer_Database.Entities
{
    public class PostTag
    {
        [Key]
        public int TagId { get; set; }

        [ForeignKey(nameof(Post))]
        public int PostId { get; set; }


        //Navigation Property
        public Tag Tag { get; set; }
        public Posts Post { get; set; }

    }
}
