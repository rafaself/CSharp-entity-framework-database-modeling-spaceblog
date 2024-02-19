using SpaceBlogDb.Repositories;

namespace SpaceBlogDb.UseCases.User;

public class ListAllUsers
{
    public static async Task Execute()
    {
        var dbContext = new CustomDbContext();

        var userRepository = new UserRepository(dbContext);

        var users = await userRepository.ListAllAsync();

        Console.WriteLine("\nListando usuários...\n");

        foreach (var user in users ) {
            Console.WriteLine($"#{user.Id} - Nome: {user.Name} - Email: {user.Email}");
        }
    }
}
