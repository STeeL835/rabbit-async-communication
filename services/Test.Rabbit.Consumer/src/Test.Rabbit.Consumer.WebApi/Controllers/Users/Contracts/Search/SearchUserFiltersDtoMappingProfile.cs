using Test.Rabbit.Consumer.App.Users.SearchUsers.Contracts;

namespace Test.Rabbit.Consumer.WebApi.Controllers.Users.Contracts.Search;

public sealed class SearchUserFiltersDtoMappingProfile : AutoMapper.Profile
{
    public SearchUserFiltersDtoMappingProfile()
    {
        CreateMap<SearchUserFiltersDto, SearchUsersQuery>();
    }
}