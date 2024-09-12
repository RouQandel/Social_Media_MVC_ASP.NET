using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess_Layer_Database.Entities
{
    public class Tag
    {
        [ForeignKey(nameof(User))]
        public int Id { get; set; }
        public string UserName { get; set; }

        //Navigation Property
        public ICollection<PostTag> PostTags { get; set; }
    }
}
