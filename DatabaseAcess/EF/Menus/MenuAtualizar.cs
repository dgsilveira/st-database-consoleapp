using EF.Banco;
using EF.Model;

namespace EF.Menus
{
    internal class MenuAtualizar : Menu
    {
        public override void Executar(Contexto contexto)
        {
            base.Executar(contexto);
            ExibirTituloDaOpcao("Atualizar");

            Console.Write("Digite o id: ");
            int id = int.Parse(Console.ReadLine()!);
            
            Pessoa? pessoa = contexto.Pessoas.First(p => p.Id == id);

            Console.WriteLine("Deseja alterar o nome? S para sim N para não");
            var resposta = Console.ReadLine()!.ToUpper()!;
            if (resposta == "S")
            {
                Console.Write("Digite o novo nome: ");
                pessoa.Nome = Console.ReadLine()!;
            }

            Console.WriteLine("Deseja alterar o gênero? S para sim N para não");
            resposta = Console.ReadLine()!.ToUpper();
            if (resposta == "S")
            {
                Console.Write("Digite o gênero: ");
                pessoa.Genero = Console.ReadLine()!.ToUpper()!;
            }


            Console.WriteLine("Deseja alterar a data de nascimento? S para sim S para não");
            resposta = Console.ReadLine()!.ToUpper();
            if (resposta == "S")
            {
                Console.WriteLine("Digite a data de nascimento no formato dd/MM/yyyy");
                string stringDataNascimento = Console.ReadLine()!;
                pessoa.DataNascimento = DateTime.ParseExact(stringDataNascimento, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
            }

            Console.WriteLine("Deseja alterar se o cadastro está ativo? S para sim N para não");
            resposta = Console.ReadLine()!.ToUpper()!;
            if (resposta == "S")
            {
                Console.Write("Digite A para ativo D para desativado: ");
                string stringAtivo = Console.ReadLine()!.ToUpper()!;
                if (stringAtivo == "A")
                    pessoa.Ativo = true;
                else if (stringAtivo == "D")
                    pessoa.Ativo = false;
            }

            contexto.Pessoas.Update(pessoa);
            contexto.SaveChanges();
            Console.WriteLine($"Registrado com sucesso!");
            Console.WriteLine($"Aguarde, vamos retornar ao menu principal automaticamente!");
            Thread.Sleep(2000);
            Console.Clear();
        }
    }
}
