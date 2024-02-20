using SpaceBlogDb.Models;
using SpaceBlogDb.Repositories;

namespace SpaceBlogDb.UseCases.Post;

public class CreatePost
{
    public static async Task Execute()
    {

        await using var dbContext = new CustomDbContext();

        var postRepository = new PostRepository(dbContext);

        Console.Write("Digite o ID do usuário criador: ");
        string? userIdTemp = Console.ReadLine();
        int userId = int.Parse(userIdTemp!);

        Console.Write("Digite o ID da categoria: ");
        string? postCategoryIdTemp = Console.ReadLine();
        int postCategoryId = int.Parse(postCategoryIdTemp!);

        Console.Write("Digite o título do Post: ");
        string? title = Console.ReadLine();
        Console.Write("Digite a descrição do Post: ");
        string? description = Console.ReadLine();

        var post = new Models.Post
        {
            Title = title!,
            Description = description!,
            UserId = userId
        };

        var postCategoryPost = new PostsCategoryPost
        {
            Post = post,
            PostsCategoryId = postCategoryId,
        };

        dbContext.Add(postCategoryPost);

        await dbContext.SaveChangesAsync();

    }
}
