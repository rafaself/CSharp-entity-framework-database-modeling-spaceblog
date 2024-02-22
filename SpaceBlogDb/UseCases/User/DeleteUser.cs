using Microsoft.EntityFrameworkCore;
using SpaceBlogDb.Repositories;

namespace SpaceBlogDb.UseCases.User;

public class DeleteUser
{
    public static async Task Execute()
    {
        await using var dbContext = new CustomDbContext();

        var userRepository = new UserRepository(dbContext);

        Console.Write("Digite o ID do usuário: ");
        string idTemp = Console.ReadLine() ?? throw new ArgumentNullException("Can't be null!");
        int id = int.Parse(idTemp);

        await userRepository.Delete(id);

        await dbContext.SaveChangesAsync();

    }
}
