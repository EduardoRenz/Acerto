using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OracleClient;

namespace Acerto
{
    class OracleConexao
    {
       
        List<Produto> lista;  // Lista de produtos associados
        List<string> colunas; // Lista de coluna
        OracleConnection conexao;
        private string server, user, senha, database;
        public bool conectado;
        public OracleConexao(string user, string password, string server)
        {
            conexao = new OracleConnection();
            conexao.ConnectionString = "Data Source=" + server + ";Persist Security Info=True;" + "User ID=" + user + ";Password=" + password + ";Unicode=True";
            try
            {
                conexao.Open();
                conectado = true;
                Console.WriteLine("Conectado! \n");
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro ao conectar" + e.Message);
                conectado = false;
            }

        }


     
        //  OracleCommand("SELECT * FROM information_schema.tables");

        public List<Produto> select(string query)
        {
            int i = 0;

                OracleCommand command = conexao.CreateCommand();
                command.CommandText = query;
                OracleDataReader reader = command.ExecuteReader();
                lista = new List<Produto>();
            Console.WriteLine("COLUNAS:" + reader.FieldCount + " Tem Linhas:" + reader.HasRows);
            while (reader.Read())
                {

                for (int x = 0; x < reader.FieldCount; x++) 
                {
                    Console.WriteLine(reader[x]);
                }
                //lista.Add(new Produto(0, reader.GetInt32("material").ToString(), reader.GetString("serie"), Convert.ToDateTime(reader.GetDateTime("dataHora")), reader.GetInt32("tamanho"), 0, " "));
                i++;
                }
                reader.Close();
                return lista;

        }
        public void Close()
        {
            conexao.Close();
            conexao.Dispose();
        }


    }
}
