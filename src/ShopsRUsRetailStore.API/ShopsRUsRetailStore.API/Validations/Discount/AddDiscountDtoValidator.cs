using FluentValidation;
using ShopsRUsRetailStore.Entities.DTOs.Discount;
using ShopsRUsRetailStore.Entities.Enums;

namespace ShopsRUsRetailStore.API.Validations.Discount
{
    public class AddDiscountDtoValidator : AbstractValidator<AddDiscountDto>
    {

        public AddDiscountDtoValidator()
        {
            RuleFor(x => x.Rate).NotEmpty().WithMessage("Rate is required").GreaterThanOrEqualTo(0).WithMessage("Rate must be greater than 0");
            RuleFor(x => x.IsPercentage).NotEmpty().WithMessage("IsPercentage is required");
            RuleFor(x => x.UserType).NotEmpty().IsInEnum().WithMessage("UserType is required");


        }

    }
}
