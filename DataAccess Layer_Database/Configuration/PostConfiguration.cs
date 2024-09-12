using DataAccess_Layer_Database.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess_Layer_Database.Configuration
{
    public class PostConfiguration : IEntityTypeConfiguration<Posts>
    {
        public void Configure(EntityTypeBuilder<Posts> builder)
        {
            builder.Property(p => p.Title).IsRequired().HasMaxLength(120);
            builder.Property(p => p.thumbnail).IsRequired();
            builder.Property(p => p.CreatedAt).IsRequired();

            builder.HasOne(u => u.user)
                 .WithMany(p => p.Posts)
                 .HasForeignKey(i => i.Id);
        }
    }
}
