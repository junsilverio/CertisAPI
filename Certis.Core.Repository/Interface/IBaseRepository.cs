using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Certis.Core.Repository.Interface
{
    public interface IBaseRepository<T> where T : class
    {

        Task<List<T>> SelectAll();

        Task<T> SelectById(long id);

        Task CreateAsync(T entity);

        Task UpdateAsync(T entity);

        Task DeleteAsync(T entity);

    }
}
