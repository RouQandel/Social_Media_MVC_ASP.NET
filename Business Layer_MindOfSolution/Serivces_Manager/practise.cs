using Business_Layer_MindOfSolution.DTOs;
using Business_Layer_MindOfSolution.Serivces_Manager;
using Business_Layer_MindOfSolution.Serivces_Manager.UserService;
using DataAccess_Layer_Database.Entities;
using DataAccess_Layer_Database.Repositores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer_MindOfSolution.DTOs
{
    public class practise : Ipractise
    {
       
        //private readonly IUserRepository _userRepository; // relation to dataaccess
        //public practise(IUserRepository userRepository)
        //{
        //    _userRepository = userRepository;
        //}
        //public List<UserDTO> GetAllUser()
        //{
        //    var userEntities = _userRepository.GetAllUsers();
        //    var users = new List<UserDTO>();
        //    foreach (var user in userEntities)
        //    {
        //        users.Add(new UserDTO()
        //        {
        //            UserID = user.UserID, 
        //            UserName = user.UserName,
        //            Password = user.Password,
        //            Email = user.Email,
        //            ProfilePicture = user.ProfilePicture

        //        });
        //    }
        //    return users; //❌❌➡️ userdto
        //}
        //public UserDTO CreateUser(UserDTO userDto)
        //{
           
        //    var userEntity = new User()
        //    {
        //        UserName = userDto.UserName,
        //        Email = userDto.Email,
        //        Password = HashPassword(userDto.Password), 
        //        bio = userDto.bio,
        //        DateOfBirth = userDto.DateOfBirth
        //    };

        //    _userRepository.AddUser(userEntity);

           
        //    userDto.UserID = userEntity.UserID;
        //    return userDto;
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



        //public bool DeleteUser(int userId)
        //{
        //    _userRepository.RemoveUser(userId);
        //    return true;
        //}



        //public UserDTO? GetUserById(int userId)
        //{
        //    var userEntity = _userRepository.GetUserById(userId);

        //    if (userEntity == null) return null;

        //    var userDto = new UserDTO()
        //    {
        //        UserID = userEntity.UserID,
        //        UserName = userEntity.UserName,
        //        Password = userEntity.Password
        //    };

        //    return userDto;
        //}
        //public UserDTO Login(string email, string password)
        //{
        //    throw new NotImplementedException();
        //}

        //public UserDTO Register(UserDTO userDTO)
        //{
        //    throw new NotImplementedException();
        //}

        //public List<UserDTO> SearchUsers(string searchTerm)
        //{
        //    throw new NotImplementedException();
        //}

        //public UserDTO UpdatedUser(UserDTO userDTO)
        //{
        //    throw new NotImplementedException();
        //}

    }
}
