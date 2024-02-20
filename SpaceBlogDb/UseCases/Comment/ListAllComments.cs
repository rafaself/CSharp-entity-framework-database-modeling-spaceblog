using SpaceBlogDb.Repositories;

namespace SpaceBlogDb.UseCases.Comment;

public class ListAllComments
{
    public static async Task Execute()
    {
        var dbContext = new CustomDbContext();

        var commentRepository = new CommentRepository(dbContext);

        var comments = await commentRepository.ListAllAsync();

        foreach (var comment in comments)
        {
            Console.WriteLine($"\n-- Comentário #{comment.Id}");
            Console.WriteLine($"Texto: {comment.Text}");
            Console.WriteLine($"ID Post: {comment.PostId}");
            Console.WriteLine($"ID Usuário: {comment.UserId}\n");
        }
    }
}
