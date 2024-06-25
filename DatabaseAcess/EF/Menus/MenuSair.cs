using EF.Banco;

namespace EF.Menus;

internal class MenuSair : Menu
{
    public override void Executar(Contexto contexto)
    {
        Console.WriteLine("Tchau tchau :)");
    }
}