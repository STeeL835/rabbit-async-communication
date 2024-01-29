using System.Net;
using FluentAssertions;
using Test.Rabbit.Producer.IntegrationTests.Prerequisites;
using Test.Rabbit.Producer.Publishers.CreateUser.TransitContracts;
using Test.Rabbit.Producer.WebApi.Controllers.Users.Contracts.CreateUser;
using Xunit.Abstractions;

namespace Test.Rabbit.Producer.IntegrationTests.Tests.Users;

public class UsersTests : IClassFixture<TestFixture>
{
    public TestFixture Fixture { get; }

    public UsersTests(TestFixture fixture, ITestOutputHelper outputHelper)
    {
        Fixture = fixture;
        
        Fixture.ResetLogger(outputHelper);
    }
    
    [Fact]
    public async Task CreateUser_ValidUser_ShouldSendUserToQueue()
    {
        var createUserDto = new CreateUserDto
        {
            FirstName = "John",
            LastName = "Doe",
            EmailAddress = "johndoe@example.com",
            PhoneNumber = "+12345678900"
        };

        var response = await Fixture.Controllers.Users.CreateUserRaw(createUserDto);
        response.Should().BeSuccessful();

        var publishedMessages = Fixture.TestHarness.Published.Select<CreateUserCommandDto>().ToList();
        publishedMessages.Should().HaveCount(1);

        publishedMessages[0].MessageObject.Should().BeEquivalentTo(createUserDto); // as long as they are the same structure
    }
    
    [Fact]
    public async Task CreateUser_EmptyMiddleName_ShouldReturnBadRequest()
    {
        var createUserDto = new CreateUserDto
        {
            FirstName = "John",
            LastName = "",
            EmailAddress = "johndoe@example.com",
            PhoneNumber = "+12345678900"
        };

        var response = await Fixture.Controllers.Users.CreateUserRaw(createUserDto);
        response.StatusCode.Should().Be(HttpStatusCode.BadRequest);

        var publishedMessages = Fixture.TestHarness.Published.Select<CreateUserCommandDto>().ToList();
        publishedMessages.Should().BeEmpty();
    }
}