using FluentValidation;
using FluentValidationWebApi.Models;

namespace FluentValidationWebApi.Handlers
{
    public class UserModelValidator : AbstractValidator<UserModel>
    {
        public UserModelValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Name is required.")
                .Length(2, 50).WithMessage("Name must be between 2 and 50 characters.");

            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("Email is required.")
                .EmailAddress().WithMessage("Invalid email format.");

            RuleFor(x => x.Age)
                .InclusiveBetween(18, 35).WithMessage("Age must be between 18 and 35.");
        }
    }
}
