using FluentValidation;
using Recipe.Communication.Requests;
using Recipe.Exceptions;

namespace Recipe.Application.UseCases.User.Register;

public class RegisterUserValidation : AbstractValidator<RequestRegisterUserJson>
{
    public RegisterUserValidation()
    {
        RuleFor(user => user.Name).NotEmpty().WithMessage(ResourceMessagesException.NAME_EMPTY);
        RuleFor(user => user.Email).NotEmpty().WithMessage(ResourceMessagesException.EMAIL_EMPTY);
        RuleFor(user => user.Password)
            .NotEmpty()
            .MinimumLength(6);
        When(user => !string.IsNullOrEmpty(user.Email), () =>
        {
            RuleFor(user => user.Email).EmailAddress().WithMessage(ResourceMessagesException.EMAIL_INVALID);
        });
    }
}
