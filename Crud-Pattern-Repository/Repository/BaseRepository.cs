using Abp.Domain.Uow;
using Crud_Pattern_Repository.Data;
using Crud_Pattern_Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crud_Pattern_Repository.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private readonly CrudDbContext _context;

        public BaseRepository(CrudDbContext context)
        {
            _context = context;
        }

        public async Task<List<T>> FindAllAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<T> FindByIdAsync(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task InsertAsync(T Object)
        {
             await _context.Set<T>().AddAsync(Object);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(T Object)
        {
             _context.Set<T>().Update(Object);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteAsync(int id)
        {
            
            var Object = await _context.Set<T>().FindAsync(id);
            if(Object != null)
            {
                _context.Set<T>().Remove(Object);
                await _context.SaveChangesAsync();
            }
           
        }
    }
    
}
