using EF.Banco;

namespace EF.Menus
{
    internal class MenuDeletar : Menu
    {
        public override void Executar(Contexto contexto)
        {
            base.Executar(contexto);
            ExibirTituloDaOpcao("Deletar");

            Console.Write("Digite o id: ");
            int id = int.Parse(Console.ReadLine()!);

            var pessoa = contexto.Pessoas.First(p => p.Id == id);

            contexto.Pessoas.Remove(pessoa);
            contexto.SaveChanges();

            Console.WriteLine($"Deletado com sucesso!");
            Console.WriteLine($"Aguarde, vamos retornar ao menu principal automaticamente!");
            Thread.Sleep(2000);
            Console.Clear();
        }
    }
}
