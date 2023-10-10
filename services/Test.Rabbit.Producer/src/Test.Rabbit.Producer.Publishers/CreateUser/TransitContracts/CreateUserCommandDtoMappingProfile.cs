using Test.Rabbit.Producer.Publishers.CreateUser.Contracts;

namespace Test.Rabbit.Producer.Publishers.CreateUser.TransitContracts;

public class CreateUserCommandMappingProfile : AutoMapper.Profile 
{
    public CreateUserCommandMappingProfile()
    {
        CreateMap<CreateUserExternalCommand, CreateUserCommandDto>();
    }
}