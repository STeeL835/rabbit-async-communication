using Test.Rabbit.Consumer.Database.Models.Users;

namespace Test.Rabbit.Consumer.WebApi.Controllers.Contracts.Entities.Users;

public sealed class UserDtoMappingProfile : AutoMapper.Profile
{
    public UserDtoMappingProfile()
    {
        CreateMap<User, UserDto>();
    }
}