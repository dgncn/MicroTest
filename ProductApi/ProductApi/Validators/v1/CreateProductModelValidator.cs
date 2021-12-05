using FluentValidation;
using ProductApi.Models.v1;

namespace ProductApi.Validators.v1
{
    public class CreateProductModelValidator : AbstractValidator<CreateProductModel>
    {
        public CreateProductModelValidator()
        {
            RuleFor(product => product.Name).NotEmpty()
                .WithMessage("Ürün adı boş bırakılamaz");
        }
    }
}
