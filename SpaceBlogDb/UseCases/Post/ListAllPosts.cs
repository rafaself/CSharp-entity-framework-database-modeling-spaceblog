using Microsoft.EntityFrameworkCore;
using SpaceBlogDb.Repositories;

namespace SpaceBlogDb.UseCases.Post;

public class ListAllPosts
{
    public static async Task Execute()
    {
        var dbContext = new CustomDbContext();

        var postRepository = new PostRepository(dbContext);

        var posts = await postRepository.ListAllAsync();

        foreach(var post in posts)
        {
            Console.WriteLine($"\n-- Post #{post.Id}");
            Console.WriteLine($"Título: {post.Title}");
            Console.WriteLine($"Descrição: {post.Description}");
            Console.WriteLine($"Usuário Criador: {post.User!.Name}");
            Console.WriteLine($"ID Usuário Criador: {post.UserId}\n");
        }

    }
}
