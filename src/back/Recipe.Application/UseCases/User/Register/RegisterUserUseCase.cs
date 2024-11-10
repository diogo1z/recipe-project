using Recipe.Communication.Responses;
using Recipe.Communication.Requests;
using FluentValidation;

namespace Recipe.Application.UseCases.User.Register;

public class RegisterUserUseCase
{
    public ResponseRegisterUserJson Execute(RequestRegisterUserJson user)
    {
        Validate(user);
        
        return new ResponseRegisterUserJson
        {
            Name = user.Name
        };
    }

    public void Validate(RequestRegisterUserJson user)
    {
        var validation = new RegisterUserValidation();
        validation.ValidateAndThrow(user);
    }
}
