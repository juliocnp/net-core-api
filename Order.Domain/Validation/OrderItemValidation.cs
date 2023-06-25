using FluentValidation;
using Order.Domain.Models;

namespace Order.Domain.Validation
{
    public class OrderItemValidation : AbstractValidator<OrderItemModel>
    {
        public OrderItemValidation()
        {
            RuleFor(x => x.Order)
                .NotNull()
                .NotEmpty()
                .WithMessage("Invalid or null Order");

            RuleFor(x => x.SellValue)
                .NotNull()
                .GreaterThanOrEqualTo(0)
                .WithMessage("Invalid or null SellValue");

            RuleFor(x => x.Product)
                .NotNull()
                .NotEmpty()
                .WithMessage("Inavalid or null Product");
        }
    }
}
