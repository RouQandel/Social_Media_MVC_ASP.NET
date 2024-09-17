using DataAccess_Layer_Database.Context;
using DataAccess_Layer_Database.Entities;
using DataAccess_Layer_Database.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess_Layer_Database
{
    public class PostRepository : GenericRepository<Posts>, IPostRepository
    {
        public PostRepository(ApplicationDbContext _context) : base(_context)
        {
        }

        public Task<Posts> AddCategoryForPost(Posts posts, List<int> CategoryIds)
        {
            throw new NotImplementedException();
        }

        public Task<Posts> AddTagForPost(Posts posts, List<int> TagIds)
        {
            throw new NotImplementedException();
        }

        public Posts GetPostByIdWithCategoriesAndTags(Types types, int id)
        {
            throw new NotImplementedException();
        }

        public Posts GetPostByIdWithEverything(int id)
        {
            throw new NotImplementedException();
        }

        public List<Posts> GetPostsIcludeCatgoriesAnsTagsAsync(Types types)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Posts> SearchPost(string text)
        {
            throw new NotImplementedException();
        }
    }
}
