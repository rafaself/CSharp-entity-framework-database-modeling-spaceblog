using SpaceBlogDb.Repositories;

namespace SpaceBlogDb.UseCases.Post;

public class GetPostById
{
    public static async Task Execute()
    {
        var dbContext = new CustomDbContext();

        var postRepository = new PostRepository(dbContext);

        Console.Write("Digite o ID do post: ");
        string? idTemp = Console.ReadLine();
        int id = int.Parse(idTemp!);

        var post = await postRepository.GetByIdAsync(id);

        Console.WriteLine($"\n-- Post #{post.Id}");
        Console.WriteLine($"Título: {post.Title}");
        Console.WriteLine($"Descrição: {post.Description}");
        Console.WriteLine($"Criador: {post.User!.Name}\n");

    }
}
