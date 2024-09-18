
using DataAccess_Layer_Database.context;
using DataAccess_Layer_Database.Entities;
using DataAccess_Layer_Database.Enums;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess_Layer_Database
{
    public class PostRepository : GenericRepository<Posts>, IPostRepository
    {
        private readonly ICategoryRepository categoryRepository;
        private readonly ITagRepository tagRepository;
        private readonly UserManager<User> userManager;

        public PostRepository(ApplicationDbContext context, ICategoryRepository _categoryRepository, ITagRepository _tagRepository, UserManager<User> _userManager) : base(context)
        {
            categoryRepository = _categoryRepository;
            tagRepository = _tagRepository;
            userManager = _userManager;
        }
        private List<Posts> IncludeTypes (Types types) //enum
        {
            if (types.HasFlag(Types.PostCategories))// hasflag ➡️➡️ PostCategories mwgoda wla la ?true zwdhali 3la content ...
            {
                context.Posts.Include(i => i.Contents).Include(i => i.Comments).Include(i => i.postCategories).ThenInclude(p => p.Category).Load();
                // load ➡️ loading data to memory
            }
            if(types.HasFlag(Types.PostTags))
            {
                context.Posts.Include(i => i.Contents).Include(i => i.Comments).Include(i => i.PostTags).ThenInclude(i => i.Tag).Load();
            }
            return context.Posts.ToList();
        }
        public List<Posts> GetPostsIcludeCatgoriesAnsTagsAsync(Types types)
        {
            var Lists = IncludeTypes(types).ToList();
            return Lists;
        }

        public Posts GetPostByIdWithCategoriesAndTags(Types types, int id)
        {
            var Post = IncludeTypes(types).ToList();
            var result = Post.FirstOrDefault(i => i.Id == id);
            if (result == null)
            {
                return null;
            }
            else
            {
                return result;
            }
        }

        public IQueryable<Posts> SearchPost(string text)
            //Iqueryable call l data  we bttnfz hnak x data base
        {
            //Linq   bwsl l data mn class context call "dbcontext" entity framework 
            var post = context.Posts
                .Where(i =>
                i.Title.ToLower().Contains(text.ToLower()) ||
                i.Summary.ToLower().Contains(text.ToLower())
                );
            return post;
        }

        public async Task<Posts> AddCategoryForPost(Posts posts, List<int> CategoryIds)
        {
            if ( CategoryIds != null)
            {
                foreach( var category in CategoryIds)
                {
                    var postCategory = new PostCategory()
                    {
                        CategoryId =category,
                        Post =posts,
                        PostId =posts.Id,
                        Category = await categoryRepository.GetByIdAsync(category)
                    };
                    posts.postCategories.Add(postCategory);
                }
            }
            return posts;
        }

        public Task<Posts> AddTagForPost(Posts posts, List<int> TagIds)
        {
            throw new NotImplementedException();
        }

        public Posts GetPostByIdWithEverything(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<Posts>> GetPostsOrderByDate()
        {
            throw new NotImplementedException();
        }

        public async Task<List<Posts>> PostsWithUsers()
        {
            var posts = await context.Posts.ToListAsync();
            foreach (var post in posts)
            {
                if (post.Id != null)
                {
                    var finduser = await userManager.FindByIdAsync(post.user.Id);
                    if (finduser != null)
                    post.user = finduser;
                }
            }
            return posts;
        }

        public Posts GetPostByIdWithContents(int id)
        {
            throw new NotImplementedException();
        }
    }
   


  
     
}

