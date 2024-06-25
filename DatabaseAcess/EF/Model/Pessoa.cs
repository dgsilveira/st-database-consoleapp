using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EF.Model
{
    [Table("pessoas")]
    public class Pessoa
    {
        [Key]
        [Required]
        [Column("id")]
        public int Id { get; set; }
        [Required(ErrorMessage = "O nome é obrigatório")]
        [StringLength(100, ErrorMessage = "O tamanho do nome não pode exceder 100 caracter")]
        [Column("nome")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "O gênero é obrigatório")]
        [StringLength(1, ErrorMessage = "O tamanho do gênero não pode exceder 1 caracter")]
        [Column("genero")]
        public string Genero { get; set; }
        [Required(ErrorMessage = "Data de nascimento é obrigatória")]
        [Column("data_nascimento")]
        public DateTime DataNascimento { get; set; }
        [Column("idc_ativo")]
        public bool Ativo { get; set; }
        [Column("data_modificacao")]
        public DateTime DataModificacao { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}\nNome: {Nome}\nGenero: {Genero}\nData Nascimento: {DataNascimento}\nAtivo: {Ativo}\nData Modificação: {DataModificacao}";
        }
    }
}
