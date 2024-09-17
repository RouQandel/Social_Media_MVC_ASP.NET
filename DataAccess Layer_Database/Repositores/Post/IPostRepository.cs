using DataAccess_Layer_Database.Entities;
using DataAccess_Layer_Database.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataAccess_Layer_Database
{
    public interface IPostRepository :IGenericRepository<Posts>
    {
        List<Posts> GetPostsIcludeCatgoriesAnsTagsAsync(Types types);
        Posts GetPostByIdWithCategoriesAndTags (Types types, int id);
        IQueryable<Posts> SearchPost(string text);
        Task<Posts> AddCategoryForPost(Posts posts , List<int> CategoryIds);
        Task<Posts> AddTagForPost(Posts posts ,List<int> TagIds);  
        public Posts GetPostByIdWithEverything (int id);

    }
}
