using SpaceBlogDb.UseCases.User;

Console.WriteLine("Menu");

int option = 0;

do
{
    Console.WriteLine("Opções:");
    Console.WriteLine("1 - Criar usuário");
    Console.WriteLine("2 - Buscar usuário");
    Console.WriteLine("0 - Sair");

    Console.Write("\nDigite uma opção: ");
    string optionTemp = Console.ReadLine() ?? throw new ArgumentNullException("Can't be null");
    option = int.Parse(optionTemp);

    switch (option)
    {
        case 1:
            await CreateUser.Execute();
            break;
        case 2:
            await GetUserById.Execute();
            break;
    }

} while (option > 0);

