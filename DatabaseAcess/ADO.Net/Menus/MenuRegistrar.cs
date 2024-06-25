using ADO.Net.Banco;
using ADO.Net.Model;

namespace ADO.Net.Menus
{
    internal class MenuRegistrar : Menu
    {
        public override void Executar(PessoaRepository repository)
        {
            base.Executar(repository);
            ExibirTituloDaOpcao("Registrar novo");
            Console.Write("Digite o nome: ");
            string nome = Console.ReadLine()!;
            Console.Write("Digite a letra que representa o gênero: ");
            string genero = Console.ReadLine()!.ToUpper()!;
            Console.WriteLine("Digite a data de nascimento no formato dd/MM/yyyy");
            string stringDataNascimento = Console.ReadLine()!;
            DateTime dataNascimento = DateTime.ParseExact(stringDataNascimento, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);

            var pessoa = new Pessoa()
            {
                Ativo = true,
                DataModificacao = DateTime.Now,
                DataNascimento = dataNascimento,
                Genero = genero,
                Nome = nome
            };

            repository.Adicionar(pessoa);
            Console.WriteLine($"Registrado com sucesso!");
            Console.WriteLine($"Aguarde, vamos retornar ao menu principal automaticamente!");
            Thread.Sleep(2000);
            Console.Clear();
        }
    }
}
