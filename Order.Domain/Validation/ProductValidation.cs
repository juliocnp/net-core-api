using FluentValidation;
using Order.Domain.Models;

namespace Order.Domain.Validation
{
    public class ProductValidation : AbstractValidator<ProductModel>
    {
        public ProductValidation()
        {
            RuleFor(x => x.SellValue)
                .NotNull()
                .NotEmpty()
                .GreaterThanOrEqualTo(0)
                .WithMessage("Inavalid or null SellValue");

            RuleFor(x => x.Stock)
                .NotNull()
                .NotEmpty()
                .GreaterThanOrEqualTo(0)
                .WithMessage("Inavalid or null Stock");

            RuleFor(x => x.Description)
                .NotNull()
                .NotEmpty()
                .Length(3, 100)
                .WithMessage("Inavalid or null Description");
        }
    }
}
