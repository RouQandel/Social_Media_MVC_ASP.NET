using Business_Layer_MindOfSolution;
using Business_Layer_MindOfSolution.DTOs;
using DataAccess_Layer_Database.Context;
using DataAccess_Layer_Database.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Presentation_Layer__Controller.ActionRequests;
using Presentation_Layer__Controller.VMs_viewModel;
using SocialMedia;

namespace SocialMedia.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        private readonly ApplicationDbContext _context;


        public UserController(IUserService userService , ApplicationDbContext context)
        {
            _userService = userService;
            _context = context;
        }
        // User/Register
        [HttpGet] // get  Request "attribute"
        public IActionResult Register()
        {
            return View();
        }
        // User/login 
        public IActionResult login()
        {
            return View();
        }
        public IActionResult logout() 
        {
            return RedirectToAction("Login", "User"); ;
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(CreateUserActionRequest user) //❌❌
        {
            
            if (ModelState.IsValid)
            {
               _userService.
                var userUserProfileVM = new UserProfileViewModel()
                {
                    UserName = user.UserName,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Email = user.Email,
                    Password = _userService.HashPassword(user.Password), 
                    ProfilePicture = user.ProfilePicture
                };
                var createdUser = _userService.CreateUser(newUserDto);
                _context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            return View(user);
        }

    }
}
