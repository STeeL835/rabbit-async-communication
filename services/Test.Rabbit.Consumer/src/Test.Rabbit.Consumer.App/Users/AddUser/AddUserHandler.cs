using AutoMapper;
using MediatR;
using Test.Rabbit.Consumer.App.Users.AddUser.Contracts;
using Test.Rabbit.Consumer.Database;
using Test.Rabbit.Consumer.Database.Models.Users;

namespace Test.Rabbit.Consumer.App.Users.AddUser;

public class AddUserHandler : IRequestHandler<AddUserCommand>
{
    private readonly DataContext _dataContext;
    private readonly IMapper _mapper;

    public AddUserHandler(DataContext dataContext, IMapper mapper)
    {
        _dataContext = dataContext;
        _mapper = mapper;
    }

    public async Task Handle(AddUserCommand request, CancellationToken cancellationToken)
    {
        // TODO: extension method to map with additional properties
        var userDb = _mapper.Map<User>(request, opt =>
        {
            opt.BeforeMap((src, dest) => dest.Id = Guid.NewGuid());
        });

        _dataContext.Users.Add(userDb);

        await _dataContext.SaveChangesAsync(cancellationToken);
    }
}