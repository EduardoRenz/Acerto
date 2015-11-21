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
        private string server, user, senha, sqlconect;
        public bool conectado;
        public OracleConexao(string user, string senha, string server)
        {
            this.user = user;
            this.senha = senha;
            this.server = server;
            sqlconect = "Data Source=" + server + ";Persist Security Info=True;" + "User ID=" + user + ";Password=" + senha + ";Unicode=True";
            Conectar();
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
        public bool Conectar()
        {
            conexao = new OracleConnection(sqlconect);
            try
            {
                conexao.Open();
                conectado = true;
                Console.WriteLine("Conectado! \n");
            }
            catch (Exception e)
            {
                if (MessageBox.Show("Erro ao se conectar no banco de dados " + e.Message + " , retentar?", "Erro", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    Conectar();
                }
                else
                {
                    Application.Exit();
                }
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
