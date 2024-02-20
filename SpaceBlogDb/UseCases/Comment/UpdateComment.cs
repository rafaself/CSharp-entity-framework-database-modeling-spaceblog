using SpaceBlogDb.Repositories;

namespace SpaceBlogDb.UseCases.Comment;

public class UpdateComment
{
    public static async Task Execute()
    {
        var dbContext = new CustomDbContext();

        var commentRepository = new CommentRepository(dbContext);

        Console.Write("Digite o ID do comentário a ser editado: ");
        string? commentIdTemp = Console.ReadLine();
        int commentId = int.Parse(commentIdTemp!);

        Console.Write("Digite o novo texto para o comentário: ");
        string? commentText = Console.ReadLine();

        await commentRepository.UpdateCommentAsync(commentId, commentText!);

        await dbContext.SaveChangesAsync();
    }
}
