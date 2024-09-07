using Business_Layer_MindOfSolution;
using Business_Layer_MindOfSolution.DTOs;
using DataAccess_Layer_Database.Context;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            //builder bybny al setting bt3 al applacation

            var connectionString = builder.Configuration.GetConnectionString("SocialMediaMVC");//package

            builder.Services.AddScoped<IUserService, UserService>();

            builder.Services.AddDbContext<ApplicationDbContext>(option => 
            { 
                option.UseSqlServer(connectionString);
            }
            );

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
