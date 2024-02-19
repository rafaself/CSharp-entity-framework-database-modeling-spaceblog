using SpaceBlogDb;
using SpaceBlogDb.Models;
using SpaceBlogDb.Repositories;

namespace TestSpaceBlogDb;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public async Task GetByIdAsync_ReturnsInstanceOfUser()
    {
        await using var dbContext = new CustomDbContext();
        var userRepository = new UserRepository(dbContext);

        var user = await userRepository.GetByIdAsync(2);
        Assert.That(user, Is.InstanceOf<User>());
    }
}