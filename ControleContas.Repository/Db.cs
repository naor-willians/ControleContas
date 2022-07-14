using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using MySql.Data.MySqlClient;

namespace ControleContas.Repository
{
    public static class Db
    {
        private static string _conexao = "server=localhost;database=contadb;user=root;password=rosa1705";

        private static MySqlConnection ObterConexao()
        {
            var con = new MySqlConnection();
            con.ConnectionString = _conexao;
            return con;
        }

        public static int Execute(string storeProcedure, object parametro)
        {
            int total;
            using (var con = ObterConexao())
            {
                total = con.Execute(storeProcedure, parametro, commandType: CommandType.StoredProcedure);

            }
            return total;
        }

        public static T QueryEntidade<T>(string storeProcedure, object parametro)
        {
            T retorno;
            using(var con = ObterConexao())
            {
                retorno = con.QueryFirstOrDefault<T>(storeProcedure, parametro, commandType: CommandType.StoredProcedure);

            }
            return retorno;
        }
        
        public static IEnumerable<T> QueryColecao<T>(string storeProcedure, object parametro)
        {
            IEnumerable<T> retorno;
            using(var con = ObterConexao())
            {
                retorno = con.Query<T>(storeProcedure, parametro, commandType:CommandType.StoredProcedure);

            }
            return retorno;
        }


    }
}
