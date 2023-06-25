using FluentValidation;
using Order.Domain.Models;

namespace Order.Domain.Validation
{
    public class OrderValidation : AbstractValidator<OrderModel>
    {
        public OrderValidation()
        {
            RuleFor(x => x.User)
                .NotNull()
                .NotEmpty()
                .WithMessage("Inavalid or null User");

            RuleFor(x => x.Items)
                .NotNull()
                .NotEmpty()
                .WithMessage("Inavalid or null Items");
        }
    }
}
