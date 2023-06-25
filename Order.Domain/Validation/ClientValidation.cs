using FluentValidation;
using Order.Domain.Models;

namespace Order.Domain.Validation
{
    public class ClientValidation : AbstractValidator<ClientModel>
    {
        public ClientValidation()
        {
            RuleFor(x => x.Name)
                .NotNull()
                .NotEmpty()
                .Length(3, 100)
                .WithMessage("Inavalid or null Name");

            RuleFor(x => x.Address)
                .NotNull()
                .NotEmpty()
                .MinimumLength(10)
                .WithMessage("Inavalid or null Address");

            RuleFor(x => x.Email)
                .NotNull()
                .NotEmpty()
                .Length(3, 100)
                .EmailAddress(FluentValidation.Validators.EmailValidationMode.AspNetCoreCompatible)
                .WithMessage("Inavalid or null Email");

            RuleFor(x => x.PhoneNumber)
                .NotNull()
                .NotEmpty()
                .Length(11,17)
                .WithMessage("Inavalid or null PhoneNumber");
        }
    }
}
