using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Test.Rabbit.Consumer.WebApi.Controllers.Organizations.Contracts.AttachUsers;

namespace Test.Rabbit.Consumer.WebApi.Controllers.Organizations;

[ApiController, Route("[controller]")]
public class OrganizationsController : ControllerBase
{
    private readonly IMediator _mediator;
    private readonly IMapper _mapper;

    public OrganizationsController(IMediator mediator, IMapper mapper)
    {
        _mediator = mediator;
        _mapper = mapper;
    }

    [HttpPost("{id}/attach-users")]
    public async Task AttachUsers(Guid id, [FromBody] AttachUsersCommandDto attachUsersCommandDto)
    {
        throw new NotImplementedException();
    }
}