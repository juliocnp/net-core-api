using FluentValidation;

namespace Order.Domain.Interfaces.Factory
{
    public interface IValidationFactory
    {
        IValidator<T> GetValidator<T>();
    }
}
