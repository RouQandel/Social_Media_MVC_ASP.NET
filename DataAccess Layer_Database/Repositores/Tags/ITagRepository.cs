using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess_Layer_Database.Entities;
using DataAccess_Layer_Database.Enums;
using DataAccess_Layer_Database.Repositores;


namespace DataAccess_Layer_Database
{
    public interface ITagRepository : IGenericRepository<Tag>
    {
        List<Tag> GetTagsIncludePosts(Types types);
        Tag GetTagByIdWithPost(Types types ,int id);
        IQueryable<Tag> SearchTag(string text);
    }
}
