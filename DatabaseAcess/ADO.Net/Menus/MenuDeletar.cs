using ADO.Net.Banco;

namespace ADO.Net.Menus
{
    internal class MenuDeletar : Menu
    {
        public override void Executar(PessoaRepository repository)
        {
            base.Executar(repository);
            ExibirTituloDaOpcao("Deletar");

            Console.Write("Digite o id: ");
            int id = int.Parse(Console.ReadLine()!);

            repository.Delete(id);

            Console.WriteLine($"Deletado com sucesso!");
            Console.WriteLine($"Aguarde, vamos retornar ao menu principal automaticamente!");
            Thread.Sleep(2000);
            Console.Clear();
        }
    }
}
