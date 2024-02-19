using SpaceBlogDb.Repositories;

namespace SpaceBlogDb.UseCases.PostCategory;

public class GetPostCategoryById
{
    public static async Task Execute()
    {
        var dbContext = new CustomDbContext();

        var postCategoryRepository = new PostCategoryRepository(dbContext);

        Console.Write("Digite o ID da categoria: ");
        string idTemp = Console.ReadLine() ?? throw new ArgumentNullException("Can't be null!");
        int id = int.Parse(idTemp);

        var category = await postCategoryRepository.GetByIdAsync(id);

        Console.WriteLine($"#{id} - Categoria: {category.Title}\n");

    }
}
