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
    Console.WriteLine("1 - Seção de usuários");
    Console.WriteLine("0 - Sair do programa");

    Console.Write("\nDigite uma opção: ");
    string optionTemp = Console.ReadLine() ?? throw new ArgumentNullException("Can't be null");
    option = int.Parse(optionTemp);

    switch (option)
    {
        case 1:
            await CallUserUseCases.Execute(mapper);
            break;
    }

} while (option > 0);

