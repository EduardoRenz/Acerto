using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Acerto
{
    class MysqlConexao : IConexao
    {
        MySqlConnection conexao;
        private string server, user, senha, database;
        public bool conectado;
        public MysqlConexao(string user, string senha, string server, string database) {
            this.user = user;
            this.senha = senha;
            this.server = server;
            this.database = database;
            string sqlconecta = " Persist Security Info = False; server =" + server + " ; database =" + database + "; uid =" + user + "; pwd =" + senha + "";
            conexao = new MySqlConnection(sqlconecta);

            Conectar(sqlconecta); // Conecta-se ao server Mysql
        }  // Construtor da classe
        public bool Conectar(string sqlconecta)
        {
            conexao = new MySqlConnection(sqlconecta);
            try
            {
                conexao.Open();  //abre a conexao
                conectado = true;
                return conectado;
            }

            catch (System.Exception e)
            {
                MessageBox.Show("Erro de conexão: " + e.Message.ToString());
                conectado = false;
                return conectado;
            }
        }  // Conecta-se ao Banco
        public DataTable Consulta(string query)
        {      
            DataTable dt = new DataTable();
            if (conexao.State == ConnectionState.Open) {
                MySqlCommand consulta = new MySqlCommand(query, conexao);
                MySqlDataReader reader = consulta.ExecuteReader();
                dt.Load(reader);
                reader.Close();
                return dt;
            }
            MessageBox.Show("Erro ao conectar-se");
            return null;
        } // Faz uma consulta e retorna o resultado 
        public void Close()
        {
            conexao.Close();
        } // fecha a conexão
    }
}
