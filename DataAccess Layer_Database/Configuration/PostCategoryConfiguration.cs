using DataAccess_Layer_Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess_Layer_Database.Configuration
{
    public class PostCategoryConfiguration : IEntityTypeConfiguration<PostCategory>
    {
        public void Configure(EntityTypeBuilder<PostCategory> builder)
        {
            builder.HasKey(pc => new { pc.PostId, pc.CategoryId });

            builder.HasOne(p => p.Post)
                .WithMany(c => c.postCategories)
                .HasForeignKey(p => p.PostId);

            builder.HasOne(p => p.Category)
                .WithMany(pc => pc.PostCategories)
                .HasForeignKey(c => c.CategoryId);

        }
    }
}
