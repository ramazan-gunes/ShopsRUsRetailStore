using FluentValidation;
using ShopsRUsRetailStore.Entities.DTOs.Discount;
using ShopsRUsRetailStore.Entities.DTOs.User;

namespace ShopsRUsRetailStore.API.Validations.User
{
    public class AddUserDtoValidator : AbstractValidator<AddUserDto>
    {

        public AddUserDtoValidator()
        {
            RuleFor(x => x.UserName).NotEmpty().WithMessage("UserName is required");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email is required").EmailAddress().WithMessage("Please check your e-mail address."); ;
            RuleFor(x => x.Password).NotEmpty().WithMessage("Password is required");
            RuleFor(x => x.Type).IsInEnum().WithMessage("Type is required");


        }

    }
}
