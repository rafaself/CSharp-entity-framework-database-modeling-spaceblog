using SpaceBlogDb.Repositories;

namespace SpaceBlogDb.UseCases.Comment;

public class DeleteComment
{
    public static async Task Execute()
    {
        var dbContext = new CustomDbContext();

        var commentRepository = new CommentRepository(dbContext);

        Console.Write("Digite o ID do comentário a ser deletado: ");
        string? commentIdTemp = Console.ReadLine();
        int commentId = int.Parse(commentIdTemp!);

        await commentRepository.Delete(commentId);

        await dbContext.SaveChangesAsync();

    }
}
