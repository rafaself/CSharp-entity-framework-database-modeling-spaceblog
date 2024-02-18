using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using SpaceBlogDb.UseCases.User;
using System.Reflection;


var config = new MapperConfiguration(cfg => cfg.AddMaps(AppDomain.CurrentDomain.GetAssemblies()));
var mapper = config.CreateMapper();

int option;


Console.WriteLine("Menu");
do
{
    Console.WriteLine("Opções:");
    Console.WriteLine("1 - Criar usuário");
    Console.WriteLine("2 - Buscar usuário");
    Console.WriteLine("3 - Deletar usuário");
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
            await GetUserById.Execute(mapper);
            break;        
        case 3:
            await DeleteUser.Execute();
            break;
    }

} while (option > 0);

