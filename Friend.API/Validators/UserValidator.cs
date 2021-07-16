using FluentValidation;
using Friend.Domain.Entities;
using System.Text.RegularExpressions;

namespace Friend.API.Validators
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(x => x.Email)
                .NotNull().WithMessage("Email is required")
                .EmailAddress().WithMessage("Invalid Email Format");

            RuleFor(x => x.Password)
                .NotNull().WithMessage("Password is required")
                .Must(pass =>
                    Regex.IsMatch(pass,
                    @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,15}$"))
                .WithMessage("'Password' does not correspond to a strong pattern");
        }
    }
}
