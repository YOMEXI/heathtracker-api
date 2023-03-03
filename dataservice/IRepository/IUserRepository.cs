using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using entities.DbSet;

namespace dataservice.IRepository
{
    public class IUserRepository : IGenericRepository<User>
    {
        public Task<bool> Add(User entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<User>> All()
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(Guid id, string userId)
        {
            throw new NotImplementedException();
        }

        public Task<User> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Upsert(User entity)
        {
            throw new NotImplementedException();
        }
    }
}