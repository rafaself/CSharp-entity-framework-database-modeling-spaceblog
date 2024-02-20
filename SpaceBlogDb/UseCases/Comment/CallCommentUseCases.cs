namespace SpaceBlogDb.UseCases.Comment;

public class CallCommentUseCases
{
    public static async Task Execute()
    {
        int option;
        do
        {
            Console.WriteLine("-- Gerenciamento dos Comentários --");
            Console.WriteLine("1 - Criar comentário");
            Console.WriteLine("2 - Buscar comentário pelo ID");
            Console.WriteLine("0 - Voltar ao menu principal");
            Console.Write("Digite uma opção: ");
            string? optionTemp = Console.ReadLine();
            option = int.Parse(optionTemp!);

            switch (option)
            {
                case 1:
                    await CreateComment.Execute();
                    break;
                case 2:
                    await GetCommentById.Execute();
                    break;
                case 0:
                    Console.Clear();
                    break;
            }

        } while (option > 0);
    }
}
