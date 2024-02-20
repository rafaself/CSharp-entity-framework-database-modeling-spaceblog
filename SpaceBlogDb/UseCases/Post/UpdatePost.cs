using SpaceBlogDb.Repositories;

namespace SpaceBlogDb.UseCases.Post;

public class UpdatePost
{
    public static async Task Execute()
    {
        var dbContext = new CustomDbContext();

        var postRepository = new PostRepository(dbContext);

        Console.Write("\nDigite o ID do post a ser atualizado: ");
        string? postIdTemp = Console.ReadLine();
        int postId = int.Parse(postIdTemp!);

        Console.Write("\nDigite o novo título: ");
        string? title = Console.ReadLine();

        Console.Write("\nDigite a nova descrição: ");
        string? description = Console.ReadLine();

        await postRepository.UpdatePostAsync(postId, title!, description!);

        await dbContext.SaveChangesAsync();

    }
}
