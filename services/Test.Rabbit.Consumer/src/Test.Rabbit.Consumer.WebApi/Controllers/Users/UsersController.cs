using Microsoft.AspNetCore.Mvc;
using Test.Rabbit.Consumer.WebApi.Controllers.Users.Contracts.Search;

namespace Test.Rabbit.Consumer.WebApi.Controllers.Users;

[ApiController, Route("[controller]")]
public class UsersController : ControllerBase
{
    [HttpPost]
    public IEnumerable<UserDto> Search(SearchUserFiltersDto filters)
    {
        throw new NotImplementedException();
    }
}