using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crud_Pattern_Repository.Interfaces
{
    public interface IBaseService<T> where T : class
    {
        Task<List<T>> FindAllAsync();
        Task<T> FindByIdAsync(int id);
        Task InsertAsync(T Object);
        Task UpdateAsync(T Object);
        Task DeleteAsync(int id);
    }
}
