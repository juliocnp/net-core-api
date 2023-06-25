using FluentValidation;
using Order.Domain.Models;

namespace Order.Domain.Validation
{
    public class UserValidation : AbstractValidator<UserModel>
    {
        public UserValidation()
        {
            RuleFor(x => x.Name)
                .NotNull()
                .NotEmpty()
                .Length(1, 100)
                .WithMessage("Inavalid or null Name");

            RuleFor(x => x.Login)
                .NotNull()
                .NotEmpty()
                .Length(1, 20)
                .WithMessage("Inavalid or null Address");

            RuleFor(x => x.PasswordHash)
                .NotNull()
                .NotEmpty()
                .WithMessage("Inavalid or null PasswordHash");
        }
    }
}
