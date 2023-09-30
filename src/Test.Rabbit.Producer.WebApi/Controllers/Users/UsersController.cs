using Microsoft.AspNetCore.Mvc;
using Test.Rabbit.Producer.WebApi.Controllers.Users.Contracts;

namespace Test.Rabbit.Producer.WebApi.Controllers.Users; 

[ApiController, Route("[controller]")]
public class UsersController : ControllerBase
{
    public UsersController()
    {
    }

    [HttpPost]
    public async Task Post(CreateUserDto createUser)
    {
        throw new NotImplementedException();
    }
}
