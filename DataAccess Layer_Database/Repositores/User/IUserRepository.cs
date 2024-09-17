using DataAccess_Layer_Database.Entities;
using DataAccess_Layer_Database.Repositores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess_Layer_Database
{
    public interface IUserRepository : IGenericRepository<User>
    {
        public Task<List<User>> UserListAsync();
        public Task<User> UserDetailsAsync(User user);
        public Task<User> UserIdWithAsNoTracking(string id);
    }
}
