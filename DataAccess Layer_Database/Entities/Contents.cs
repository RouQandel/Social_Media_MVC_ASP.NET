using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess_Layer_Database.Entities
{
    public class Contents 
    {
        [ForeignKey(nameof(User))]
        public int Id { get; set; }
        public string Text { get; set; }
        public string Image { get; set; }

        [ForeignKey(nameof(Post))]
        public int PostId { get; set; }

        //Navigation Property
        public Posts Post { get; set; }
    }
}
