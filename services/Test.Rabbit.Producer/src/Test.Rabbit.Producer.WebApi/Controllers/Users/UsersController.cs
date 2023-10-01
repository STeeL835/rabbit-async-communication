using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Test.Rabbit.Producer.App.Users.CreateUser.Parameters;
using Test.Rabbit.Producer.WebApi.Controllers.Users.Contracts.CreateUser;

namespace Test.Rabbit.Producer.WebApi.Controllers.Users; 

[ApiController, Route("[controller]")]
public class UsersController : ControllerBase
{
    private readonly IMediator _mediator;
    private readonly IMapper _mapper;
    
    public UsersController(IMediator mediator, IMapper mapper)
    {
        _mediator = mediator;
        _mapper = mapper;
    }

    [HttpPost]
    public async Task Post(CreateUserDto createUser)
    {
        var command = _mapper.Map<CreateUserCommand>(createUser);

        await _mediator.Send(command);
    }
}
