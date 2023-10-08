using MediatR;
using Test.Rabbit.Consumer.App.Users.SearchUsers.Contracts;

namespace Test.Rabbit.Consumer.App.Users.SearchUsers;

public class SearchUsersHandler : IRequestHandler<SearchUsersQuery, SearchUsersResponse>
{
    public Task<SearchUsersResponse> Handle(SearchUsersQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}