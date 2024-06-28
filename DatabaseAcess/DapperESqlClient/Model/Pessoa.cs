using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperESqlClient.Model
{
    internal class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Genero { get; set; }
        public DateTime DataNascimento { get; set; }
        public bool Ativo { get; set; }
        public DateTime DataModificacao { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}\nNome: {Nome}\nGenero: {Genero}\nData Nascimento: {DataNascimento}\nAtivo: {Ativo}\nData Modificação: {DataModificacao}";
        }
    }
}
