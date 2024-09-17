using DataAccess_Layer_Database.Context;
using DataAccess_Layer_Database.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess_Layer_Database.Repositores.User
{
    public class UserRepository 
    {
        //private readonly ApplicationDbContext _DbContext; //save 34an ast5dmah gwa al class da 

        ////referance bt3ai ali contenar bb3tholo 34an y3amli object
        ////contrustor injection

        //public UserRepository(ApplicationDbContext dbContext)
        //{
        //    _DbContext = dbContext;
        //}

        //public void RemoveUser(int userId)
        //{
        //    var user = _DbContext.Users.FirstOrDefault( u =>u.UserID == userId);
        //    if(user != null)
        //    {
        //        _DbContext.Users.Remove(user);
        //    }
        //}

        //public int GetMaxById(int userId)
        //{
        //    return _DbContext.Users.Max(user => user.UserID);
        //}
        //void IUserRepository.AddUser(User user)
        //{
        //    user.UserID = GetMaxById(user.UserID) + 1; //❌❌❌❌
        //    _DbContext.Users.Add(user);// plus user 
        //}
        //void IUserRepository.DeleteUser(User user)
        //{
        //   _DbContext.Users.Remove(user);
        //}

        //IEnumerable<User> IUserRepository.GetAllUsers()
        //{
        //    return _DbContext.Users.ToList(); //Convert  dbset to list
        //}

        //User? IUserRepository.GetUserById(int userId)
        //{
        //    return _DbContext.Users.FirstOrDefault(User => User.UserID == userId);

        //}

        //void IUserRepository.UpdateUser(User user)
        //{
        //     _DbContext.Users.Update(user);
        //}
        //public void SaveChanges()
        //{
        //    _DbContext.SaveChanges();
        //}
        //public static string HashPassword(string password)
        //{
        //    using (SHA256 sha256 = SHA256.Create())
        //    {
        //        byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
        //        StringBuilder builder = new StringBuilder();
        //        foreach (byte b in bytes)
        //        {
        //            builder.Append(b.ToString("x2"));
        //        }
        //        return builder.ToString();
        //    }
        //}


    }
}
