using DataAccess_Layer_Database.Configuration;
using DataAccess_Layer_Database.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess_Layer_Database.Context
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            //OptionsBuilder.UseSqlServer(@"Servker=ROU\\MSSQLSERVER01;Database=SocialMediaMVC;integrated security=SSPI;");
        }
        public DbSet<Posts> Posts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<PostCategory> PostCategories { get; set; }
        public DbSet<PostTag> PostTags { get; set; }
        public DbSet<Contents> Contents { get; set; }
        public DbSet<Comment> Comments { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfiguration(new PostCategory());
            //modelBuilder.ApplyConfiguration(new PostTagMap());
            modelBuilder.ApplyConfiguration(new PostConfiguration());
            //modelBuilder.ApplyConfiguration(new CategoryMap());
            //modelBuilder.ApplyConfiguration(new TagMap());
            //modelBuilder.ApplyConfiguration(new ContentsMap());
            //modelBuilder.ApplyConfiguration(new CommentMap());
            modelBuilder.ApplyConfigurationsFromAssembly
            (
                typeof(ApplicationDbContext).Assembly
            );
            base.OnModelCreating(modelBuilder);
        }
    }
}
