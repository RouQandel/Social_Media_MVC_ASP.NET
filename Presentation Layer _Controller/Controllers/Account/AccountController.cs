using Business_Layer_MindOfSolution.DTOs;
using DataAccess_Layer_Database.Entities;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Presentation_Layer__Controller.VMs_viewModel.Account;
using System.Security.Claims;

namespace Presentation_Layer__Controller.Controllers.Account
{
    public class AccountController : Controller
    {
        [HttpGet] // get  Request "attribute"
        public IActionResult Register()
        {
            return View("Register");
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginVM model, string ReturnUrl)
        {
            //httpcontext. user bta5od al user k "value " troh l use Authentacation

            //HttpContext.User;

        //    if (ModelState.IsValid) {
        //        var user = new UserDTO();
   
        //        if(user =! null)
        //        {
        //        //login logic 

        //        //1.Create claims

        //        Claim c1 = new(ClaimTypes.Name, user.UserName);
        //        Claim c2 = new(ClaimTypes.Email, user.Email);
        //        Claim c3 = new(ClaimTypes.Role, user.role);

        //        //2.create Identity

        //        ClaimsIdentity ci = new ClaimsIdentity(CookieAuthenticationDefaults.AuthenticationScheme); //string mktbob fiha cookies 

        //        ci.AddClaim(c1);
        //        ci.AddClaim(c2);
        //        ci.AddClaim(c3);


        //        //3.create principal
        //        ClaimsPrincipal cp = new ClaimsPrincipal(ci);

        //        //4. Sign In

        //        await HttpContext.SignInAsync(cp);

        //        if (ReturnUrl !=null) return LocalRedirect(ReturnUrl);

        //        return RedirectToAction("index", "home");
        //    }
        //}
            return View();
        }
        public async Task<IActionResult> LogOut()
        {
            if (HttpContext.User.Identity.IsAuthenticated)//remove user remeber
            {
                await HttpContext.SignOutAsync();
            }
            return RedirectToAction("Index", "HOME");

        }
    }
    public record UserInfo(string name , string email,string role);
    public static class UserRole
    {
        public const string admin ="admin";
        public const string User ="User";
        
    }  
}
