using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Acerto
{
    class MysqlConexao : IConexao
    {
        List<Produto> lista;  // Lista de produtos associados
        List<string> colunas; // Lista de colunas 
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
        }

        public DataTable select(string query)
        {      
            int i = 0;
            DataTable dt = new DataTable();
            if (conexao.State == ConnectionState.Open) {
                MySqlCommand consulta = new MySqlCommand(query, conexao);
                MySqlDataReader reader = consulta.ExecuteReader();
                
                dt.Load(reader);

                reader.Close();
                return dt;
            }
            return dt;
        }

       public List<string> Consulta(string query)
        {
            colunas = new List<string>();
            int i = 0;
            MySqlCommand consulta = new MySqlCommand(query, conexao);
            if (conexao.State == ConnectionState.Open) {
                MySqlDataReader reader = consulta.ExecuteReader();
                lista = new List<Produto>();
                while (reader.Read())
                {
                    colunas.Add(reader[0].ToString());
                    Console.WriteLine(colunas[i]);
                    i++;
                }
                reader.Close();
                return colunas;
            }
            return colunas;
        }

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
        }
       public void Close()
        {
            conexao.Close();
        }
    }
}
