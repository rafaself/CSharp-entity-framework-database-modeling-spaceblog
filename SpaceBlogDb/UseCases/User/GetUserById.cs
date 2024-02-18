using AutoMapper;
using SpaceBlogDb.Models.DTOs;
using SpaceBlogDb.Repositories;

namespace SpaceBlogDb.UseCases.User;

public class GetUserById
{


    public static async Task Execute(IMapper mapper)
    {
        await using var dbContext = new CustomDbContext();

        var userRepository = new UserRepository(dbContext);

        Console.Write("\nDigite o ID do usuário: ");
        string idTemp = Console.ReadLine() ?? throw new ArgumentNullException("Can't be null!");
        int id = int.Parse(idTemp);
        Console.WriteLine("Buscando usuário...");

        try
        {
            var user = await userRepository.GetByIdAsync(id);
            var userMapped = mapper.Map<UserDto>(user);
            Console.WriteLine($"Nome: {user.Name}");
            Console.WriteLine($"Email: {user.Email}\n");
        }
        catch (InvalidOperationException)
        {
            Console.WriteLine("Usuárion não encontrado!\n");
        }

    }
}
