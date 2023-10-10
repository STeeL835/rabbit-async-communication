using AutoMapper;
using Test.Rabbit.Consumer.App.Users.AddUser.Contracts;

namespace Test.Rabbit.Consumer.WebApi.Consumers.CreateUser.Contracts;

public sealed class CreateUserCommandDtoMappingProfile : AutoMapper.Profile
{
    public CreateUserCommandDtoMappingProfile()
    {
        CreateMap<CreateUserCommandDto, AddUserCommand>();
    }
}

public static class UserDtoMappingProfileExtensions
{
    public static AddUserCommand ToCommand(this CreateUserCommandDto command, IMapper mapper) => mapper.Map<AddUserCommand>(command);
}