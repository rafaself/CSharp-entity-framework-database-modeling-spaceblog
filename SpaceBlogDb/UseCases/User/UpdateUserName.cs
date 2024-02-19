using SpaceBlogDb.Repositories;

namespace SpaceBlogDb.UseCases.User;

public class UpdateUserName
{
    public static async Task Execute()
    {
        Console.Write("Digite o ID do usuário: ");
        var idTemp = Console.ReadLine() ?? throw new ArgumentNullException("Can't be null!");
        int id = int.Parse(idTemp);
        Console.Write("Digite o nome do usuário: ");
        var name = Console.ReadLine() ?? throw new ArgumentNullException("Can't be null!");

        await using var dbContext = new CustomDbContext();

        var repository = new UserRepository(dbContext);

        await repository.UpdateUserName(id, name);

        Console.WriteLine("Nome atualizado com sucesso!");

        await dbContext.SaveChangesAsync();

    }
}
