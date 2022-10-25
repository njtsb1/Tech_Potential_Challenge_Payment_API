using Microsoft.EntityFrameworkCore;
using Tech_Potential_Challenge_Payment_API.Contexts;
using Tech_Potential_Challenge_Payment_API.Repositories.Interfaces;

namespace Tech_Potential_Challenge_Payment_API.Repositories
{
    public abstract class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        protected readonly DataContext _context;
        private bool disposed = false;

        public BaseRepository(DataContext context)
            => _context = context;

        public async Task<IEnumerable<TEntity>> GetAll()
            => await _context.Set<TEntity>().ToListAsync();

        public async Task<TEntity> GetById(Guid id)
            => await _context.Set<TEntity>().FindAsync(id);

        public async Task Create(TEntity model) 
            => await _context.AddAsync(model);             

        public void Update(TEntity model)
            => _context.Entry(model).State = EntityState.Modified;                

        public void Delete(TEntity model)
            => _context.Remove(model);

        ~BaseRepository()
            => Dispose();
        
        public void Dispose()  
        {
            if (!disposed)
                _context.Dispose();

            GC.SuppressFinalize(this);
        }
    }
}