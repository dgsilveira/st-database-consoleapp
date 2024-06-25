
using EF.Banco;
using EF.Menus;

var contexto = new Contexto();

Dictionary<int, Menu> opcoes = new();

opcoes.Add(0, new MenuSair());
opcoes.Add(1, new MenuMostrarPessoas());
opcoes.Add(2, new MenuBuscarPorId());
opcoes.Add(3, new MenuRegistrar());
opcoes.Add(4, new MenuAtualizar());
opcoes.Add(5, new MenuDeletar());

void ExibirLogo()
{
    Console.WriteLine(@"
███╗░░░░░╔███░███████╗███╗░░██╗██╗░░░██╗
████╗░░░╔████░██╔════╝████╗░██║██║░░░██║
██╔██╗░╔██╗██░█████╗░░██╔██╗██║██║░░░██║
██║╚█████╝║██░██╔══╝░░██║╚████║██║░░░██║
██║░╚███║░║██░███████╗██║░╚███║╚██████╔╝
╚═╝░░╚═╝░░╚═╝░╚══════╝╚═╝░░╚══╝░╚═════╝░
    ");
    Console.WriteLine("Boas vindas a Prática de Acesso a Banco de Dados com: ADO.Net\n");
}

void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("Digite 0 para sair");
    Console.WriteLine("Digite 1 para listar");
    Console.WriteLine("Digite 2 para buscar por id");
    Console.WriteLine("Digite 3 para registrar");
    Console.WriteLine("Digite 4 para atualizar");
    Console.WriteLine("Digite 5 para deletar");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    if (opcoes.ContainsKey(opcaoEscolhidaNumerica))
    {
        Menu menuASerExibido = opcoes[opcaoEscolhidaNumerica];
        menuASerExibido.Executar(contexto);
        if (opcaoEscolhidaNumerica > 0) ExibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine("Opção inválida");
    }
}

ExibirOpcoesDoMenu();