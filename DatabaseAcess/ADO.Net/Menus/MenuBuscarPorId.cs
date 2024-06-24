using ADO.Net.Banco;

namespace ADO.Net.Menus
{
    internal class MenuBuscarPorId : Menu
    {
        public override void Executar(PessoaRepository repository)
        {
            base.Executar(repository);
            ExibirTituloDaOpcao("Buscar por id na nossa aplicação");

            Console.Write("Digite o id: ");
            int id = int.Parse(Console.ReadLine()!);

            var pessoa = repository.BuscarPorId(id);

            Console.WriteLine(pessoa);

            Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
