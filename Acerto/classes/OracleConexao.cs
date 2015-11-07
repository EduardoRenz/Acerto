using System;
using System.Data.OracleClient;
//using Oracle.DataAccess.Client;
using System.Data;
using System.Windows.Forms;

namespace Acerto
{
   public class OracleConexao : IConexao
    {
        OracleConnection conexao;
        OracleDataReader reader;
        OracleCommand command;
        private string server, user, senha;
        public bool conectado;
        public OracleConexao(string user, string senha, string server)
        {
            this.user = user;
            this.senha = senha;
            this.server = server;
         string  sqlconect = "Data Source=" + server + ";Persist Security Info=True;" + "User ID=" + user + ";Password=" + senha + ";Unicode=True";
            Conectar(sqlconect);
        } // Construtor da classe
        public DataTable Consulta(string query)
        {
            DataTable dt = new DataTable();
            if(conexao.State == ConnectionState.Open)
            {
                command = conexao.CreateCommand();
                command.CommandText = query;
                 reader = command.ExecuteReader();
                dt.Load(reader);
                reader.Close();
                return dt;
            }
            else
            {
                MessageBox.Show("Erro ao conectar-se");
                return null;
            }
          
        } //  Retorna uma consulta de uma query
        public bool Conectar(string sqlConexao)
        {
            conexao = new OracleConnection(sqlConexao);
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
            return conectado;
        } // Conecta-se ao banco
        public void CancelQuery()
        {
            command.Cancel();
            Console.WriteLine("Query Cancelada");
        }
        public void Close()
        {
            conexao.Close();
            conexao.Dispose();
        } // fecha a conexão
    }
}
