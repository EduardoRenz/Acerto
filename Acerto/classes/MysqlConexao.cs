﻿using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Threading;

namespace Acerto
{
  public  class MysqlConexao : IConexao
    {
        MySqlConnection conexao;
        MySqlDataReader reader;
        MySqlCommand consulta;
        private string server, user, senha, database,sqlconecta;
        public bool conectado;
        public MysqlConexao(string user, string senha, string server, string database) {
            this.user = user;
            this.senha = senha;
            this.server = server;
            this.database = database;
            sqlconecta = " Persist Security Info = False; server =" + server + " ; database =" + database + "; uid =" + user + "; pwd =" + senha + "";
            conexao = new MySqlConnection(sqlconecta);
            Conectar(); // Conecta-se ao server Mysql
        }  // Construtor da classe
        public bool Conectar()
        {
            conexao = new MySqlConnection(sqlconecta);
            try
            {
                conexao.Open();  //abre a conexao
                conectado = true;
                return conectado;
            }

            catch (Exception e)
            {
                if (MessageBox.Show("Erro ao se conectar no banco de dados "+e.Message+" , retentar?", "Erro", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    Conectar();
                }
                else
                {
                    Application.Exit();
                }
                conectado = false;
                return conectado;
            }
        }  // Conecta-se ao Banco
        public DataTable Consulta(string query)
        {      
            DataTable dt = new DataTable();
            if (conexao.State == ConnectionState.Open) {
                consulta = new MySqlCommand(query, conexao);
                reader = consulta.ExecuteReader();
                dt.Load(reader);
                reader.Close();
                return dt;
            }
            MessageBox.Show("Erro ao conectar-se");
            return null;
        } // Faz uma consulta e retorna o resultado 
        public void CancelQuery()
        {
            consulta.Cancel();
            Console.WriteLine("Query Cancelada");
        }
        public void Close()
        {
            conexao.Close();
        } // fecha a conexão
    }
}
