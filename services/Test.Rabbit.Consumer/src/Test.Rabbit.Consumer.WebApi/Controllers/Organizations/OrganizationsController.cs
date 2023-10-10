using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Test.Rabbit.Consumer.App.Organizations.AttachUsers.Contracts;
using Test.Rabbit.Consumer.WebApi.Controllers.Organizations.Contracts.AttachUsers;

namespace Test.Rabbit.Consumer.WebApi.Controllers.Organizations;

[ApiController, Route("[controller]")]
public class OrganizationsController : ControllerBase
{
    private readonly IMediator _mediator;

    public OrganizationsController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost("{id}/attach-users")]
    public async Task AttachUsers(Guid id, [FromBody] AttachUsersCommandDto attachUsersCommandDto)
    {
        var request = new AttachUsersCommand(
            id,
            attachUsersCommandDto.UserIds);

        await _mediator.Send(request);
    }
}