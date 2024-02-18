using SpaceBlogDb.Repositories;

namespace SpaceBlogDb.UseCases.User;

public class CreateUser
{

    public static async Task Execute()
    {
        await using CustomDbContext dbContext = new();

        var userRepository = new UserRepository(dbContext);

        Console.Write("Digite o nome: ");
        string name = Console.ReadLine() ?? throw new ArgumentNullException("Can't be null!");
        Console.Write("Digite o email: ");
        string email = Console.ReadLine() ?? throw new ArgumentNullException("Can't be null!");

        var user = new Models.User
        {
            Name = name,
            Email = email,
        };

        userRepository.Create(user);

        await dbContext.SaveChangesAsync();
    }

}
