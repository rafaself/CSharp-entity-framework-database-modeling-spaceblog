using SpaceBlogDb.Repositories;

namespace SpaceBlogDb.UseCases.PostCategory;

public class UpdatePostCategory
{
    public static async Task Execute()
    {
        var dbContext = new CustomDbContext();  

        var postCategoryRepository = new PostCategoryRepository(dbContext);

        Console.Write("Digite o ID da categoria para atualizar: ");
        var idTemp = Console.ReadLine() ?? throw new ArgumentNullException("Can't be null!");
        int id = int.Parse(idTemp);
        Console.Write("\nDigite o novo título para atualizar: ");
        string title = Console.ReadLine() ?? throw new ArgumentNullException("Can't be null");

        await postCategoryRepository.UpdatePostCategory(id, title);

        await dbContext.SaveChangesAsync();

    }
}
