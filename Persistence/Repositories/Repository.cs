using Application.Interface.IRepository;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Persistence.DatabaseConfig;

namespace Persistence.Repositories
{
    public class Repository<T> : IRepository<T> where T : class 
    {
        protected readonly AskiverseContext _context;
        private readonly DbSet<T> _dbSet;
        private IDbContextTransaction _transaction;

        public Repository(AskiverseContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public async Task AddAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
        }

        public async Task BeginTransactionAsync()
        {
            _transaction ??= await _context.Database.BeginTransactionAsync();
        }

        public async Task CommitTransactionAsync()
        {
            if (_transaction != null)
            {
                await _transaction.CommitAsync();
            }
        }

        public async Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> expression)
        {
            return await _dbSet.Where(expression).ToListAsync();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public IQueryable<T> GetPaginatedList(Expression<Func<T, bool>> condition, Expression<Func<T, object>> orderBy, bool ascending)
        {
            var data = _dbSet.Where(condition).AsNoTracking();
            data = ascending ? data.OrderBy(orderBy) : data.OrderByDescending(orderBy);
            return data;
        }

        public async Task<T?> GetSingle(Expression<Func<T, bool>> expression)
        {
            return await _dbSet.SingleOrDefaultAsync(expression);
        }

        public async Task<bool> HasAnyAsync(Expression<Func<T, bool>> expression)
        {
            return await _dbSet.AnyAsync(expression);
        }

        public void RemoveAsync(T entity)
        {
            _dbSet.Remove(entity);
        }

        public async Task RollbackTransactionAsync()
        {
            if (_transaction != null)
            {
                await _transaction.RollbackAsync();
            }
        }

        public void UpdateAsync(T entity)
        {
            _dbSet.Update(entity);
        }
    }
}
