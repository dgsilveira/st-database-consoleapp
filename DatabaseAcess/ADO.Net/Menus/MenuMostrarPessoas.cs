using ADO.Net.Banco;

namespace ADO.Net.Menus
{
    internal class MenuMostrarPessoas : Menu
    {
        public override void Executar(PessoaRepository repository)
        {
            base.Executar(repository);
            ExibirTituloDaOpcao("Listar todos objetos da nossa aplicação");

            foreach (var pessoa in repository.Listar())
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
