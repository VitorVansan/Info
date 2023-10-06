using Dapper;
using MySql.Data.MySqlClient;
using ProcessToCsv.Model;
using ProcessToCsv.Querys;

namespace ProcessToCsv.Repository
{
    public class Repository
    {
        const string connectionString = "server=127.0.0.1;uid=root;pwd=admin;database=infocar";

        public Repository() { }

        public List<Dados> buscarDados(int pagina, int quantidadeBusca)
        {

            using (var conn = new MySqlConnection(connectionString))
            {
                var dados = conn.Query<Dados>(Query.buscaDados, new
                {
                    Pagina = pagina,
                    QuantidadeBusca = quantidadeBusca
                }).ToList();

                return dados;
            }
        }
    }
}
