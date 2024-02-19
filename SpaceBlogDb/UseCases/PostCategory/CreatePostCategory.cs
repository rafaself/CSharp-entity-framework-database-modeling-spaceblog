using SpaceBlogDb.Models;
using SpaceBlogDb.Repositories;

namespace SpaceBlogDb.UseCases.PostCategory;

public class CreatePostCategory
{

    public static async Task Execute()
    {
        Console.Write("Digite o nome da categoria: ");
        var categoryTitle = Console.ReadLine() ?? throw new ArgumentNullException("Can't be null!");

        var dbContext = new CustomDbContext();

        var postCategoryRepository = new PostCategoryRepository(dbContext);

        var postCategory = new PostsCategory
        {
            Title = categoryTitle,
        };

        postCategoryRepository.Create(postCategory);

        await dbContext.SaveChangesAsync();

        Console.WriteLine($"Categoria {postCategory} criada com sucesso!");
    }

}
