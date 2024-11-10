using FluentValidation;
using Recipe.Communication.Requests;

namespace Recipe.Application.UseCases.User.Register;

public class RegisterUserValidation : AbstractValidator<RequestRegisterUserJson>
{
    public RegisterUserValidation()
    {
        RuleFor(user => user.Email)
            .NotEmpty();

        RuleFor(user => user.Email)
            .EmailAddress();

        RuleFor(user => user.Name)
        .NotEmpty()
        .MinimumLength(3);

        RuleFor(user => user.Password)
            .NotEmpty()
            .MinimumLength(6);


    }
}
