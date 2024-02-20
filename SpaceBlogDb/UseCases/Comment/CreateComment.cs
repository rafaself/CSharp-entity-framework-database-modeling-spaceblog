using SpaceBlogDb.Repositories;

namespace SpaceBlogDb.UseCases.Comment;

public class CreateComment
{
    public static async Task Execute()
    {
        var dbContext = new CustomDbContext();

        var commentRepository = new CommentRepository(dbContext);

        Console.Write("Digite o ID do post para receber o comentário: ");
        string? postIdTemp = Console.ReadLine();
        int postId = int.Parse(postIdTemp!);

        Console.Write("Digite o ID do usuário criador do comentário: ");
        string? userIdTemp = Console.ReadLine();
        int userId = int.Parse(userIdTemp!);

        Console.Write("Digite o comentário: ");
        string? commentText = Console.ReadLine();

        var comment = new Models.Comment
        {
            PostId = postId,
            UserId = userId,
            Text = commentText!
        };

        commentRepository.Create(comment);

        await dbContext.SaveChangesAsync();
    }
}
