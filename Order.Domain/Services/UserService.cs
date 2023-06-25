using Order.Domain.Interfaces.Factory;
using Order.Domain.Interfaces.Repositories;
using Order.Domain.Interfaces.Services;
using Order.Domain.Models;
using Order.Domain.Validation.Base;

namespace Order.Domain.Services
{
    public class UserService : BaseService<UserModel>, IUserService
    {
        public UserService(IBaseRepository<UserModel> repository, IValidationFactory validationFactory) : base(repository, validationFactory)
        {
        }

        public Task<Response<bool>> AuthAsync(UserModel user)
        {
            throw new NotImplementedException();
        }

        public Task<Response<List<UserModel>>> ListByFilterAsync(Guid? id = null, string? name = null)
        {
            throw new NotImplementedException();
        }
    }
}
