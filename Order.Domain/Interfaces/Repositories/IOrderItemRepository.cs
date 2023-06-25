using Order.Domain.Models;

namespace Order.Domain.Interfaces.Repositories
{
    public interface IOrderItemRepository : IBaseRepository<OrderItemModel>
    {
        Task<List<OrderItemModel>> ListByFilterAsync(Guid? id = null, Guid? orderId = null);
    }
}
