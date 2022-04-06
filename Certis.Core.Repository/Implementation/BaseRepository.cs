using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

using Certis.Core.Repository.Interface;
using Certis.Core.Entities.Model;
using Microsoft.EntityFrameworkCore;

namespace Certis.Core.Repository.Implementation
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private readonly PCSBNRContext _context;

        public BaseRepository(PCSBNRContext context)
        {
            _context = context;
        }

        public async Task CreateAsync(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
        }

        public async Task DeleteAsync(T entity)
        {
            _context.Set<T>().Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<List<T>> SelectAll()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<T> SelectById(long id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task UpdateAsync(T entity)
        {
            _context.Set<T>().Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
