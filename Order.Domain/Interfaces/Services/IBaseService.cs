using Order.Domain.Validation.Base;

namespace Order.Domain.Interfaces.Services
{
    public interface IBaseService<T> where T : class
    {
        Task<Response> CreateAsync(T obj);
        Task<Response> UpdateAsync(T obj);
        Task<Response> DeleteAsync(Guid id);
        Task<Response<T>> GetByIdAsync(Guid id);
    }
}
