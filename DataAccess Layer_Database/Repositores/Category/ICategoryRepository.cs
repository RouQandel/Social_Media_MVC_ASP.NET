using DataAccess_Layer_Database.Entities;
using DataAccess_Layer_Database.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess_Layer_Database
{
    public interface ICategoryRepository :IGenericRepository<Category>
    {
        List<Category> GetCategoriesIncludePosts(Types types);
        Category GetCategoryByIdWithPost(Type type , int id );
    }
}
