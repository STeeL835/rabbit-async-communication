using Test.Rabbit.Producer.Publishers.CreateUser.Contracts;

namespace Test.Rabbit.Producer.App.Users.CreateUser.Contracts;

public class CreateUserCommandMappingProfile : AutoMapper.Profile 
{
    public CreateUserCommandMappingProfile()
    {
        CreateMap<CreateUserCommand, CreateUserExternalCommand>();
    }
}