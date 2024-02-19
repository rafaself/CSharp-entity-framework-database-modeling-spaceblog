namespace SpaceBlogDb.UseCases.PostCategory;

public class CallPostCategoryUseCases
{
    public static async Task Execute()
    {
        int option;
        do
        {
            Console.WriteLine("1 - Criar categoria de post");
            Console.WriteLine("0 - Voltar ao menu anterior");
            Console.Write("\nDigite uma opção: ");

            var optionTemp = Console.ReadLine() ?? throw new ArgumentNullException("Can't be null!");
            option = int.Parse(optionTemp);

            switch(option)
            {
                case 1:
                    await CreatePostCategory.Execute();
                    break;
                case 0:
                    Console.Clear();
                    break;
            }

        } while (option > 0);
    }
}
