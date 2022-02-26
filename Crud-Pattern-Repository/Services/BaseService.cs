using Abp.Domain.Uow;
using Crud_Pattern_Repository.Data;
using Crud_Pattern_Repository.Interfaces;
using Crud_Pattern_Repository.Models;
using Crud_Pattern_Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crud_Pattern_Repository.Services
{
    public class BaseService<T> : IBaseService<T> where T : class
    {
        private readonly IBaseRepository<T> _repository;
        
        public BaseService(IBaseRepository<T> repository) 
        {

            _repository = repository;
        }

        public async Task<List<T>> FindAllAsync()
        {
           return await _repository.FindAllAsync();
        }

        public async Task<T> FindByIdAsync(int id)
        {
            return await _repository.FindByIdAsync(id);
        }

        public async Task InsertAsync(T Object)
        {
            await _repository.InsertAsync(Object);
        }

        public async Task UpdateAsync(T Object)
        {
            await _repository.UpdateAsync(Object);
        }

        public async Task DeleteAsync(int id)
        {
           await _repository.DeleteAsync(id);
        }
    }
}
