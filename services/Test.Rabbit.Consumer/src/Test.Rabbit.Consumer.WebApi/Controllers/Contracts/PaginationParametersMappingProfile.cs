using Test.Rabbit.Consumer.App.Contracts;

namespace Test.Rabbit.Consumer.WebApi.Controllers.Contracts;

public sealed class PaginationParametersMappingProfile : AutoMapper.Profile
{
    public PaginationParametersMappingProfile()
    {
        CreateMap<PaginationParametersDto, PaginationParameters>();
    }
}
