using SpaceBlogDb.Repositories;

namespace SpaceBlogDb.UseCases.Comment;

public class GetCommentById
{
    public static async Task Execute()
    {
        var dbContext = new CustomDbContext();

        var commentRepository = new CommentRepository(dbContext);

        Console.Write("Digite o ID do comentário: ");
        string? commentIdTemp = Console.ReadLine();
        int commentId = int.Parse(commentIdTemp);

        var comment = await commentRepository.GetByIdAsync(commentId);

        Console.WriteLine($"\n-- Comentário #{commentId}");
        Console.WriteLine($"Texto: {comment.Text}");
        Console.WriteLine($"ID Post: {comment.PostId}");
        Console.WriteLine($"ID Usuário: {comment.UserId}\n");


    }
}
