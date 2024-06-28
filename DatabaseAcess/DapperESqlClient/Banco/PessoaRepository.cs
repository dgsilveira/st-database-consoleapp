using Dapper;
using DapperESqlClient.Model;
using Microsoft.Data.SqlClient;

namespace DapperESqlClient.Banco
{
    internal class PessoaRepository
    {
        private string connectionString = "Data Source=DELL_DOUG;Initial Catalog=EstudyDB;User ID=sa;Password=sa1234;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";

        public async Task<IEnumerable<Pessoa>> Listar()
        {
            List<Pessoa> pessoas = new List<Pessoa>();

            await using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (var command = new SqlCommand("SELECT * FROM PESSOAS", connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        var pessoa = new Pessoa
                        {
                            Ativo = reader.GetBoolean(reader.GetOrdinal("IDC_ATIVO")),
                            DataModificacao = reader.GetDateTime(reader.GetOrdinal("DATA_MODIFICACAO")),
                            DataNascimento = reader.GetDateTime(reader.GetOrdinal("DATA_NASCIMENTO")),
                            Genero = reader.GetString(reader.GetOrdinal("GENERO")),
                            Id = reader.GetInt32(reader.GetOrdinal("id")),
                            Nome = reader.GetString(reader.GetOrdinal("NOME")).Trim()
                        };
                        pessoas.Add(pessoa);
                    }
                }
            }
            return pessoas;
        }

        //public Pessoa BuscarPorId(int idBusca)
        //{
        //    using var conexao = Obterconexao();
        //    conexao.Open();

        //    string sql = "SELECT * FROM PESSOAS WHERE ID = @id";

        //    SqlCommand command = new SqlCommand(sql, conexao);

        //    command.Parameters.AddWithValue("@id", idBusca);

        //    using SqlDataReader reader = command.ExecuteReader();

        //    reader.Read();

        //    bool ativo = Convert.ToBoolean(reader["IDC_ATIVO"]);
        //    DateTime dataNascimento = Convert.ToDateTime(reader["DATA_NASCIMENTO"]);
        //    DateTime dataModificacao = Convert.ToDateTime(reader["DATA_MODIFICACAO"]);
        //    string genero = Convert.ToString(reader["GENERO"]).Trim();
        //    int id = Convert.ToInt32(reader["ID"]);
        //    string nome = Convert.ToString(reader["NOME"]).Trim();


        //    var pessoa = new Pessoa
        //    {
        //        Ativo = ativo,
        //        DataNascimento = dataNascimento,
        //        DataModificacao = dataModificacao,
        //        Genero = genero,
        //        Id = id,
        //        Nome = nome
        //    };

        //    return pessoa;
        //}

        //public void Adicionar(Pessoa pessoaModel)
        //{
        //    using var conexao = Obterconexao();
        //    conexao.Open();

        //    string sql = "INSERT INTO PESSOAS (" +
        //                    "NOME, " +
        //                    "GENERO, " +
        //                    "DATA_NASCIMENTO, " +
        //                    "IDC_ATIVO, " +
        //                    "DATA_MODIFICACAO" +

        //                    ") VALUES (" +
        //                    "@nome, " +
        //                    "@genero, " +
        //                    "@dataNascimento, " +
        //                    "@ativo, " +
        //                    "@dataModificacao" +
        //                    ")";

        //    SqlCommand command = new SqlCommand(sql, conexao);


        //    command.Parameters.AddWithValue("@nome", pessoaModel.Nome);
        //    command.Parameters.AddWithValue("@genero", pessoaModel.Genero);
        //    command.Parameters.AddWithValue("@dataNascimento", pessoaModel.DataNascimento);
        //    command.Parameters.AddWithValue("@dataModificacao", DateTime.Now);
        //    command.Parameters.AddWithValue("@ativo", true);

        //    command.ExecuteNonQuery();
        //}

        //public void Delete(int id)
        //{
        //    using var conexao = Obterconexao();
        //    conexao.Open();

        //    string sql = "DELETE FROM PESSOAS WHERE ID = @id";

        //    SqlCommand command = new SqlCommand(sql, conexao);

        //    command.Parameters.AddWithValue("@id", id);

        //    command.ExecuteNonQuery();
        //}

        //public void Atualizar(int id, string? nome, string? genero, DateTime? dataNascimento, bool? ativo)
        //{
        //    using var conexao = Obterconexao();
        //    conexao.Open();

        //    string sql = "UPDATE PESSOAS SET ";
        //    SqlCommand command = new SqlCommand(sql, conexao);

        //    List<string> parametros = new List<string>();

        //    if (nome != default)
        //    {
        //        parametros.Add("NOME = @nome");
        //        command.Parameters.AddWithValue("@nome", nome);
        //    }

        //    if (genero != default)
        //    {
        //        parametros.Add("GENERO = @genero");
        //        command.Parameters.AddWithValue("@genero", genero);
        //    }

        //    if (dataNascimento != null)
        //    {
        //        parametros.Add("DATA_NASCIMENTO = @dataNascimento");
        //        command.Parameters.AddWithValue("@dataNascimento", dataNascimento);
        //    }

        //    parametros.Add("DATA_MODIFICACAO = @dataModificacao");
        //    command.Parameters.AddWithValue("@dataModificacao", DateTime.Now);

        //    sql = $"{sql}{string.Join(", ", parametros)} WHERE ID = @id";

        //    command.CommandText = sql;
        //    command.Parameters.AddWithValue("@id", id);

        //    command.ExecuteNonQuery();
        //}


    }
}
