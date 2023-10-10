using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Test.Rabbit.Consumer.App.Users.SearchUsers.Contracts;
using Test.Rabbit.Consumer.WebApi.Controllers.Contracts.Entities.Users;
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
    public async Task<IEnumerable<UserDto>> Search(SearchUserFiltersDto filters)
    {
        var query = _mapper.Map<SearchUsersQuery>(filters);

        var response = await _mediator.Send(query);

        var users = _mapper.Map<List<UserDto>>(response.Users);

        return users;
    }
}