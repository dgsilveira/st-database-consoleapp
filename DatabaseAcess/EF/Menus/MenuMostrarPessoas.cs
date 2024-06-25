using EF.Banco;

namespace EF.Menus
{
    internal class MenuMostrarPessoas : Menu
    {
        public override void Executar(Contexto contexto)
        {
            base.Executar(contexto);
            ExibirTituloDaOpcao("Listar todos objetos da nossa aplicação");

            foreach (var pessoa in contexto.Pessoas.ToList())
            {
                Console.WriteLine($"Pessoa: {pessoa}");
                string asteriscos = string.Empty.PadLeft(10, '-');
                Console.WriteLine(asteriscos);
            }

            Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
