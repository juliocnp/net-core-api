using Order.Domain.Models;

namespace Order.Domain.Interfaces.Repositories
{
    public interface IProductRepository: IBaseRepository<ProductModel>
    {
        Task<List<ProductModel>> ListByFilterAsync(Guid? id = null, string? description = null);
    }
}
