using AutoMapper;

namespace SpaceBlogDb.UseCases.User;

public class CallUserUseCases
{
    public static async Task Execute(IMapper mapper)
    {
        int option;
        do
        {
            Console.WriteLine("\n1 - Criar usuário");
            Console.WriteLine("2 - Buscar usuário");
            Console.WriteLine("3 - Deletar usuário");
            Console.WriteLine("4 - Atualizar nome do usuário");
            Console.WriteLine("0 - Voltar para o menu principal");
            Console.Write("\nDigite uma opção: ");
            string optionTemp = Console.ReadLine() ?? throw new ArgumentNullException("Can't be null");
            option = int.Parse(optionTemp);


            switch (option)
            {
                case 1:
                    await CreateUser.Execute();
                    break;
                case 2:
                    await GetUserById.Execute(mapper);
                    break;
                case 3:
                    await DeleteUser.Execute();
                    break;
                case 4:
                    await UpdateUserName.Execute();
                    break;
            }
        } while (option > 0);
    }
}
