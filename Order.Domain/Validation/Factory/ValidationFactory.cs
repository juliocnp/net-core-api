using FluentValidation;
using Order.Domain.Interfaces.Factory;

namespace Order.Domain.Validation.Factory
{
    public class ValidationFactory : IValidationFactory
    {
        public IValidator<T> GetValidator<T>()
        {
            var validatorType = typeof(AbstractValidator<>).MakeGenericType(typeof(T));

            var validator = (IValidator<T>?)Activator.CreateInstance(validatorType);

            if (validator is null)
                throw new Exception($"Error to create Validator for {typeof(T)}");

            return validator;
        }
    }
}
