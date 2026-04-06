using System.Threading.Tasks;
using FluentAssertions;
using Moq;
using Xunit;
using AutoMapper;
using Passenger.Core.Repositories;
using Passenger.Core.Domain;
using Passenger.Infrastructure.Services;

namespace Passenger.Tests.ServicemapperMock
{
    public class UserServiceTests
    {
        [Fact]
        public async Task register_async_should_invoke_add_async_on_repository()
        {
            var userRepositoryMock = new Mock<IUserRepository>();
            var mapperMock = new Mock<IMapper>();

            var userService = new UserService(userRepositoryMock.Object, mapperMock.Object);
            await userService.RegisterAsync("user@email.com", "user", "secret");

            userRepositoryMock.Verify(x => x.AddAsync(It.IsAny<User>()), Times.Once);
        }
    }
}
