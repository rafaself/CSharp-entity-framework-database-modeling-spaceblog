using SpaceBlogDb.Repositories;

namespace SpaceBlogDb.UseCases.PostCategory;

public class DeletePostCategory
{
    public static async Task Execute()
    {
        var dbContext = new CustomDbContext();

        var postCategoryRepository = new PostCategoryRepository(dbContext);

        Console.Write("Digite o ID da categoria que deseja deletar: ");
        string idTemp = Console.ReadLine() ?? throw new ArgumentNullException("Can't be null!");
        int id = int.Parse(idTemp);

        await postCategoryRepository.Delete(id);

        await dbContext.SaveChangesAsync();

        Console.WriteLine($"Categoria {id} deletada com sucesso!");

    }
}
