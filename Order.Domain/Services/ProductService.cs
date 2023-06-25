using Order.Domain.Interfaces.Factory;
using Order.Domain.Interfaces.Repositories;
using Order.Domain.Interfaces.Services;
using Order.Domain.Models;
using Order.Domain.Validation.Base;

namespace Order.Domain.Services
{
    public class ProductService : BaseService<ProductModel>, IProductService
    {
        public ProductService(IBaseRepository<ProductModel> repository, IValidationFactory validationFactory) : base(repository, validationFactory)
        {
        }

        public Task<Response<List<ProductModel>>> ListByFilterAsync(Guid? id = null, string? description = null)
        {
            throw new NotImplementedException();
        }
    }
}
