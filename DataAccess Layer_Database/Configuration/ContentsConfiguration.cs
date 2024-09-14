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
    public class ContentsConfiguration : IEntityTypeConfiguration<Contents>
    {
        public void Configure(EntityTypeBuilder<Contents> builder)
        {
            builder.HasOne(p =>p.Post)
                .WithMany(i =>i.Contents)
                .HasForeignKey(i => i.PostId);

        }
    }
}
