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
    public class CommentConfiguration : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
           
            builder.HasOne(p =>p.Posts)
                 .WithMany(c => c.Comments)
                 .HasForeignKey(i => i.PostId);

            builder.HasOne(c => c.user)
               .WithMany(u => u.Comments)
               .HasForeignKey(c => c.UserId)
               .HasPrincipalKey(u => u.Id);

            builder.Property(i => i.Message).IsRequired();
            builder.Property(i => i.Date).IsRequired();
        }
    }
}
