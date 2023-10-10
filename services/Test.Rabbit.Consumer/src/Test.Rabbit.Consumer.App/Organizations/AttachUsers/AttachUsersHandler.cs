using MediatR;
using Microsoft.EntityFrameworkCore;
using Test.Rabbit.Consumer.App.Organizations.AttachUsers.Contracts;
using Test.Rabbit.Consumer.Database;

namespace Test.Rabbit.Consumer.App.Organizations.AttachUsers;

public class AttachUsersHandler : IRequestHandler<AttachUsersCommand>
{
    private readonly DataContext _dataContext;

    public AttachUsersHandler(DataContext dataContext)
    {
        _dataContext = dataContext;
    }

    public async Task Handle(AttachUsersCommand request, CancellationToken cancellationToken)
    {
        var organizationToAttachTo = await _dataContext.Organizations
            .Include(o => o.Users)
            .FirstOrDefaultAsync(o => o.Id == request.OrganizationId, cancellationToken);

        if (organizationToAttachTo is null)
            throw new Exception($"Organization {request.OrganizationId} is not found");

        
        var usersToAttach = await _dataContext.Users
            .Where(u => request.UserIds.Contains(u.Id))
            .ToListAsync(cancellationToken);

        if (usersToAttach.Count != request.UserIds.Count)
            throw new Exception($"Not all users are found"); // TODO: make special exception AND even do a proper by-index validation
        
        
        foreach (var userDb in usersToAttach)
        {
            organizationToAttachTo.Users.Add(userDb);
        }

        await _dataContext.SaveChangesAsync(cancellationToken);
    }
}