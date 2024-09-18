using Business_Layer_MindOfSolution.DTOs;
using Business_Layer_MindOfSolution.Serivces_Manager.UserService;
using DataAccess_Layer_Database.context;
using Microsoft.AspNetCore.Authentication.Cookies;
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
                option
                .UseSqlServer(connectionString)
                .LogTo(Console.WriteLine, LogLevel.Information);
                    ;
            }
            );

            builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)//cookies
            .AddCookie(options =>
            {
                options.ExpireTimeSpan = TimeSpan.FromDays(30);//allow to time of log in 
                options.LoginPath="/Account/Login";
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication(); // who are you 
            app.UseAuthorization();  //allow to do samething 

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
