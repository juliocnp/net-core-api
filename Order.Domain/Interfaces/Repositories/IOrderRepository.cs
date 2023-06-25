using Order.Domain.Models;

namespace Order.Domain.Interfaces.Repositories
{
    public interface IOrderRepository: IBaseRepository<OrderModel>
    {
        Task<List<OrderModel>> ListByFilterAsync(Guid? id = null, Guid? clientId = null, Guid? userId = null);
    }
}
