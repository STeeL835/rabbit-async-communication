using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Test.Rabbit.Consumer.App.Users.SearchUsers.Contracts;
using Test.Rabbit.Consumer.Database;

namespace Test.Rabbit.Consumer.App.Users.SearchUsers;

public class SearchUsersHandler : IRequestHandler<SearchUsersQuery, SearchUsersResponse>
{
    private readonly DataContext _dataContext;
    private readonly IMapper _mapper;

    public SearchUsersHandler(DataContext dataContext, IMapper mapper)
    {
        _dataContext = dataContext;
        _mapper = mapper;
    }
    
    public async Task<SearchUsersResponse> Handle(SearchUsersQuery request, CancellationToken cancellationToken)
    {
        var users = await _dataContext.Users
            .Where(u => request.OrganizationIds.Count == 0 || request.OrganizationIds.Contains(u.OrganizationId!.Value)) // TODO: move it to library method?
            .Skip(request.Pagination.Skip)
            .Take(request.Pagination.Take)
            .ToListAsync(cancellationToken);
        
        return new SearchUsersResponse(users);
    }
}