using EF.Banco;

namespace EF.Menus
{
    internal class MenuBuscarPorId : Menu
    {
        public override void Executar(Contexto contexto)
        {
            base.Executar(contexto);
            ExibirTituloDaOpcao("Buscar por id na nossa aplicação");

            Console.Write("Digite o id: ");
            int id = int.Parse(Console.ReadLine()!);

            var pessoa = contexto.Pessoas.First(p => p.Id == id);

            Console.WriteLine(pessoa);

            Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
