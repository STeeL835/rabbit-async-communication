using AutoMapper;
using Test.Rabbit.Consumer.Database.Models.Users;

namespace Test.Rabbit.Consumer.WebApi.Controllers.Contracts.Entities.Users;

public sealed class UserDtoMappingProfile : AutoMapper.Profile
{
    public UserDtoMappingProfile()
    {
        CreateMap<User, UserDto>();
    }
}

public static class UserDtoMappingProfileExtensions
{
    public static UserDto ToDto(this User user, IMapper mapper) => mapper.Map<UserDto>(user);
    public static IEnumerable<UserDto> ToDtos(this IEnumerable<User> user, IMapper mapper) => mapper.Map<IEnumerable<UserDto>>(user);
}