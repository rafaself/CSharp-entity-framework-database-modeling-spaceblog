namespace SpaceBlogDb.UseCases.PostCategory;

public class CallPostCategoryUseCases
{
    public static async Task Execute()
    {
        int option;
        do
        {
            Console.WriteLine("-- Gerenciamento das Categorias de Posts --\n");
            Console.WriteLine("1 - Criar Categoria de Post");
            Console.WriteLine("2 - Buscar Categoria de Post pelo ID");
            Console.WriteLine("3 - Deletar Categoria de Post");
            Console.WriteLine("0 - Voltar ao menu anterior");
            Console.Write("\nDigite uma opção: ");

            var optionTemp = Console.ReadLine() ?? throw new ArgumentNullException("Can't be null!");
            option = int.Parse(optionTemp);

            switch (option)
            {
                case 1:
                    await CreatePostCategory.Execute();
                    break;
                case 2:
                    await GetPostCategoryById.Execute();
                    break;
                case 3:
                    await DeletePostCategory.Execute();
                    break;
                case 0:
                    Console.Clear();
                    break;
            }

        } while (option > 0);
    }
}
