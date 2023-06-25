using Order.Domain.Models;
using Order.Domain.Validation.Base;

namespace Order.Domain.Interfaces.Services
{
    public interface IProductService : IBaseService<ProductModel>
    {
        Task<Response<List<ProductModel>>> ListByFilterAsync(Guid? id = null, string? description = null);
    }
}
