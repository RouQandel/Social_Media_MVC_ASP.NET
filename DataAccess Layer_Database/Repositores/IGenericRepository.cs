using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess_Layer_Database.Repositores;

namespace DataAccess_Layer_Database
{
    public interface IGenericRepository<T> where T : class
    {
        Task<List<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task<T> AddAsync(T t);
        Task<T> UpdateAsync(T t);
        Task<T> DeleteAsync(int id);
        Task<int> SaveAsync();
    }
}
