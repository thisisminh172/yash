using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace yash.ViewModels.Users
{
    public class RegisterRequestValidator : AbstractValidator<RegisterRequest>
    {
        public RegisterRequestValidator()
        {
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email is required!")
                .Matches(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$")
                .WithMessage("Email format not match");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Password is required!")
                .MinimumLength(6).WithMessage("Password is at least 6 characters");
            RuleFor(x => x.FirstName).NotEmpty().WithMessage("FirstName is required!")
                .MaximumLength(200).WithMessage("First name can not over 200 characters"); ;
            RuleFor(x => x.LastName).NotEmpty().WithMessage("LastName is required!")
                .MaximumLength(200).WithMessage("Last name can not over 200 characters"); ;
            RuleFor(x => x.Address).NotEmpty().WithMessage("Address is required!");
            RuleFor(x => x.City).NotEmpty().WithMessage("City is required!");
            RuleFor(x => x.State).NotEmpty().WithMessage("State is required!");
            RuleFor(x => x.PhoneNumber).NotEmpty().WithMessage("PhoneNumber is required!");
            RuleFor(x => x.DOB).NotEmpty().WithMessage("Date of Birth is required!")
                .GreaterThan(DateTime.Now.AddYears(-100)).WithMessage("Date of Birth cannot greater than 100 years");
            RuleFor(x => x).Custom((model, context) =>
            {
                if (model.Password.Equals(model.ConfirmPassword)==false)
                {
                    context.AddFailure("Confirm password is not match");
                }
            });
        }
    }
}
