namespace Tech_Potential_Challenge_Payment_API.Repositories.Interfaces
{
    public interface IBaseRepository<TEntity> : IDisposable where TEntity : class
    {
        Task<IEnumerable<TEntity>> GetAll();
        Task<TEntity> GetById(Guid id);
        Task Create(TEntity model);
        void Update(TEntity model);
        void Delete(TEntity model);
    }
}