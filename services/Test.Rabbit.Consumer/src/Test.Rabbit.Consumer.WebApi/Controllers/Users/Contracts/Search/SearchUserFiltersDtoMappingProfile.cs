using AutoMapper;
using Test.Rabbit.Consumer.App.Users.SearchUsers.Contracts;

namespace Test.Rabbit.Consumer.WebApi.Controllers.Users.Contracts.Search;

public sealed class SearchUserFiltersDtoMappingProfile : AutoMapper.Profile
{
    public SearchUserFiltersDtoMappingProfile()
    {
        CreateMap<SearchUserFiltersDto, SearchUsersQuery>();
    }
}

// TODO: maybe there's a way to source-generate them using attributes?
public static class SearchUserFiltersDtoMappingProfileExtensions
{
    public static SearchUsersQuery ToRequest(this SearchUserFiltersDto filters, IMapper mapper) => mapper.Map<SearchUsersQuery>(filters);
}