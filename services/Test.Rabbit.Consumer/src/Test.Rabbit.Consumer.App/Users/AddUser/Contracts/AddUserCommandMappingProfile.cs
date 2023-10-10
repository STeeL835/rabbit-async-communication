using AutoMapper;
using Test.Rabbit.Consumer.Database.Models.Users;

namespace Test.Rabbit.Consumer.App.Users.AddUser.Contracts;

// TODO: make extension methods 
// TODO: think if we can get rid of external dependency on IMapper in extension methods but still be able to test all mappings
public sealed class AddUserCommandMappingProfile : AutoMapper.Profile 
{
    public AddUserCommandMappingProfile()
    {
        CreateMap<AddUserCommand, User>();
    }
}

public static class AddUserCommandMappingProfileExtensions
{
    public static User ToUser(this AddUserCommand command, Guid id, IMapper mapper)
    {
        return mapper.Map<User>(command, opt =>
        {
            opt.BeforeMap((_, dest) => dest.Id = id);
        });
    }
}