using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess_Layer_Database.Entities
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [ForeignKey(nameof(User))]
        public int Id { get; set; }
        public string UserName { get; set; }

        //Navigation Property
        public ICollection<PostCategory> PostCategories { get; set; }
    }
}
