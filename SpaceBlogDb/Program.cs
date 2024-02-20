using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using SpaceBlogDb.UseCases.Comment;
using SpaceBlogDb.UseCases.Post;
using SpaceBlogDb.UseCases.PostCategory;
using SpaceBlogDb.UseCases.User;
using System.Reflection;


var config = new MapperConfiguration(cfg => cfg.AddMaps(AppDomain.CurrentDomain.GetAssemblies()));
var mapper = config.CreateMapper();

int option;


do
{
    Console.WriteLine("-- Menu Principal --\n");
    Console.WriteLine("Opções:");
    Console.WriteLine("1 - Seção de Usuários");
    Console.WriteLine("2 - Seção de Categorias de Posts");
    Console.WriteLine("3 - Seção de Posts");
    Console.WriteLine("4 - Seção de Comentários");
    Console.WriteLine("0 - Sair do programa");

    Console.Write("\nDigite uma opção: ");
    string optionTemp = Console.ReadLine() ?? throw new ArgumentNullException("Can't be null");
    option = int.Parse(optionTemp);

    switch (option)
    {
        case 1:
            Console.Clear();
            await CallUserUseCases.Execute(mapper);
            break;
        case 2:
            Console.Clear();
            await CallPostCategoryUseCases.Execute();
            break;
        case 3:
            Console.Clear();
            await CallPostUseCases.Execute();
            break;
        case 4:
            Console.Clear();
            await CallCommentUseCases.Execute();
            break;
    }

} while (option > 0);

