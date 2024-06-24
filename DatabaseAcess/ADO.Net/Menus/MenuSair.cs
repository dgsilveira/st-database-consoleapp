using ADO.Net.Banco;

namespace ADO.Net.Menus;

internal class MenuSair : Menu
{
    public override void Executar(PessoaRepository repository)
    {
        Console.WriteLine("Tchau tchau :)");
    }
}
