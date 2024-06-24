using ADO.Net.Banco;

namespace ADO.Net.Menus
{
    internal class MenuAtualizar : Menu
    {
        public override void Executar(PessoaRepository repository)
        {
            base.Executar(repository);
            ExibirTituloDaOpcao("Atualizar");

            Console.Write("Digite o id: ");
            int id = int.Parse(Console.ReadLine()!);

            string? nome = null;

            Console.WriteLine("Deseja alterar o nome? S para sim N para não");
            var resposta = Console.ReadLine()!.ToUpper()!;
            if (resposta == "S")
            {
                Console.Write("Digite o novo nome: ");
                nome = Console.ReadLine()!;
            }

            string? genero = null;

            Console.WriteLine("Deseja alterar o gênero? S para sim N para não");
            resposta = Console.ReadLine()!.ToUpper();
            if (resposta == "S")
            {
                Console.Write("Digite o gênero: ");
                genero = Console.ReadLine()!.ToUpper()!;
            }

            DateTime? dataNascimento = null;

            Console.WriteLine("Deseja alterar a data de nascimento? S para sim S para não");
            resposta = Console.ReadLine()!.ToUpper();
            if (resposta == "S")
            {
                Console.WriteLine("Digite a data de nascimento no formato dd/MM/yyyy");
                string stringDataNascimento = Console.ReadLine()!;
                dataNascimento = DateTime.ParseExact(stringDataNascimento, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
            }

            bool? ativo = null;

            Console.WriteLine("Deseja alterar se o cadastro está ativo? S para sim N para não");
            resposta = Console.ReadLine()!.ToUpper()!;
            if (resposta == "S")
            {
                Console.Write("Digite A para ativo D para desativado: ");
                string stringAtivo = Console.ReadLine()!.ToUpper()!;
                if (stringAtivo == "A")
                    ativo = true;
                else if (stringAtivo == "D")
                    ativo = false;
            }

            repository.Atualizar(id, nome, genero, dataNascimento, ativo);

            Console.WriteLine($"Registrado com sucesso!");
            Console.WriteLine($"Aguarde, vamos retornar ao menu principal automaticamente!");
            Thread.Sleep(2000);
            Console.Clear();
        }
    }
}
