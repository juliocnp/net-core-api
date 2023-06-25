using Order.Domain.Interfaces.Factory;
using Order.Domain.Interfaces.Repositories;
using Order.Domain.Interfaces.Services;
using Order.Domain.Validation.Base;

namespace Order.Domain.Services
{
    public class BaseService<T> : IBaseService<T> where T : class
    {
        protected readonly IValidationFactory _validationFactory;
        private readonly IBaseRepository<T> _repository;
        public BaseService(IBaseRepository<T> repository, IValidationFactory validationFactory)
        {
            _repository = repository;
            _validationFactory = validationFactory;
        }
        public async Task<Response> CreateAsync(T obj)
        {
            var validator = _validationFactory.GetValidator<T>();
            var errors = validator.Validate(obj).GetErrors();

            if (errors.Report?.Any() ?? false)
                return errors;

            try
            {
                await _repository.CreateAsync(obj);
            }
            catch (Exception ex)
            {
                return Response.NotOk(new Report
                {
                    Code = 500,
                    Message = ex.Message
                });
            }
            return Response.Ok();
        }

        public async Task<Response> DeleteAsync(Guid id)
        {
            if (await _repository.ExistsById(id) is false)
                return Response.NotOk(new Report
                {
                    Code = 404,
                    Message = $"{typeof(T)} not found."
                });

            try
            {
                await _repository.DeleteAsync(id);
            }
            catch(Exception ex)
            {
                return Response.NotOk(new Report
                {
                    Code = 500,
                    Message = ex.Message
                });
            }

            return Response.Ok();
        }

        public async Task<Response<T>> GetByIdAsync(Guid id)
        {
            try
            {
                var response = await _repository.GetByIdAsync(id);
                return Response.Ok(response);
            } 
            catch (Exception ex)
            {
                return Response.NotOk<T>(new Report
                {
                    Code = 500,
                    Message = ex.Message
                });
            }
        }

        public async Task<Response> UpdateAsync(T obj)
        {
            var validator = _validationFactory.GetValidator<T>();
            var errors = validator.Validate(obj).GetErrors();

            if (errors.Report?.Any() ?? false)
                return errors;

            try
            {
                await _repository.UpdateAsync(obj);
            }
            catch (Exception ex)
            {
                return Response.NotOk(new Report
                {
                    Code = 500,
                    Message = ex.Message
                });
            }
            return Response.Ok();
        }
    }
}
