using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace dataservice.IRepository
{
    public interface IGenericRepository<T> where T : class
    {
        Task<IEnumerable<T>> All();

        //get entity based on id
        Task<T> GetById(Guid id);

        Task<bool> Add(T entity);

        Task<bool> Delete(Guid id, string userId);

        //update entity or add if it does not exist
        Task<bool> Upsert(T entity);

    }
}