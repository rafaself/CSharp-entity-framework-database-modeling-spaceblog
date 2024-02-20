using SpaceBlogDb.UseCases.PostCategory;

namespace SpaceBlogDb.UseCases.Post;

public class CallPostUseCases
{
    public static async Task Execute()
    {
        int option;
        do
        {
            Console.WriteLine("-- Gerenciamento dos Posts --\n");
            Console.WriteLine("1 - Criar Post");
            Console.WriteLine("2 - Listar Posts");
            Console.WriteLine("3 - Buscar Post pelo ID");
            Console.WriteLine("4 - Atualizar Post");
            Console.WriteLine("0 - Voltar ao menu anterior");
            Console.Write("\nDigite uma opção: ");

            var optionTemp = Console.ReadLine() ?? throw new ArgumentNullException("Can't be null!");
            option = int.Parse(optionTemp);

            switch (option)
            {
                case 1:
                    await CreatePost.Execute();
                    break;
                case 2:
                    await ListAllPosts.Execute();
                    break;
                case 3:
                    await GetPostById.Execute();
                    break;
                case 4:
                    await UpdatePost.Execute();
                    break;
                case 0:
                    Console.Clear();
                    break;
            }

        } while (option > 0);
    }
}
