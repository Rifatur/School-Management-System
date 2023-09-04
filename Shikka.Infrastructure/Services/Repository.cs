using Shikka.Core.Repository;
using Shikka.Infrastructure.Context;

namespace Shikka.Infrastructure.Services
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly SchoolDbContext _context;

        public Repository(SchoolDbContext context)
        {
            _context = context;
        }

        public Task<T> AddAsync(T entity, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<List<T>> AddRangeAsync(T[] entities, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(T entity, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task DeleteRangeAsync(T[] entities, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<T>> GetAsQueryableAsync(Func<IQueryable<T>, IQueryable<T>> expression = null, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<T> UpdateAsync(T entity, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
