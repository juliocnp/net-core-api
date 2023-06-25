using Order.Domain.Models;
using Order.Domain.Validation.Base;

namespace Order.Domain.Interfaces.Services
{
    public interface IUserService : IBaseService<UserModel>
    {
        Task<Response<List<UserModel>>> ListByFilterAsync(Guid? id = null, string? name = null);
        Task<Response<bool>> AuthAsync(UserModel user);
    }
}
