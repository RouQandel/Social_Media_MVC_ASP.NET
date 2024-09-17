using DataAccess_Layer_Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess_Layer_Database
{
    public interface ICommentRepository :IGenericRepository<Comment>
    {
        public Task<List<Comment>> CommentsListAsync();
        public Task<Comment> CommentByIdIncludeUserAsync(int id);
    }
}
