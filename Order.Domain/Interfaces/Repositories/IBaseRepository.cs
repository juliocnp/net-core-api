namespace Order.Domain.Interfaces.Repositories
{
    public interface IBaseRepository<T> where T : class
    {
        Task CreateAsync(T obj);
        Task UpdateAsync(T obj);
        Task DeleteAsync(Guid id);
        Task<T> GetByIdAsync(Guid id);
        Task<bool> ExistsById(Guid id); 
    }
}
