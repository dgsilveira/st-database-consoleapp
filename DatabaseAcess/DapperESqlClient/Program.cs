using DapperESqlClient.Banco;

var repositorio = new PessoaRepository();

var pessoas = await repositorio.Listar();

foreach (var pessoa in pessoas)
    Console.WriteLine(pessoa);