﻿using DataAccess_Layer_Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess_Layer_Database
{
    public interface IPostCategoryRepository :IGenericRepository<PostCategory>
    {
        PostCategory GetByPostCategoryId (int postid ,int categoryId);
        Task RemoveAsync(PostCategory postCategory); 
    }
}