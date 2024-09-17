using DataAccess_Layer_Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess_Layer_Database
{
    public interface IContentsRepository :IGenericRepository<Contents>
    {
        Task<List<Contents>> GetContentsIncludePost();
        Task<List<Contents>> GetContentsByPostId(int postId);
    }
}
