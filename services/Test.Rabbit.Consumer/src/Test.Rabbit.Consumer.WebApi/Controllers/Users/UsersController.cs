using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Test.Rabbit.Consumer.WebApi.Controllers.Users.Contracts.Search;

namespace Test.Rabbit.Consumer.WebApi.Controllers.Users;

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
    public IEnumerable<UserDto> Search(SearchUserFiltersDto filters)
    {
        throw new NotImplementedException();
    }
}