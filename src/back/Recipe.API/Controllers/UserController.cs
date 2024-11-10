using Microsoft.AspNetCore.Mvc;
using Recipe.Communication.Responses;
using Recipe.Communication.Requests;
using Recipe.Application.UseCases.User.Register;


namespace Recipe.API.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    private readonly ILogger<UserController> _logger;

    public UserController(ILogger<UserController> logger)
    {
        _logger = logger;
    }

    [HttpPost]
    [ProducesResponseType( typeof(ResponseRegisterUserJson), StatusCodes.Status201Created)]
    public IActionResult Register(RequestRegisterUserJson user)
    {
        var useCase = new RegisterUserUseCase();
        var result = useCase.Execute(user);

        return Created(string.Empty,result);
    }   
}
