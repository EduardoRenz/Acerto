﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OracleClient;
using System.Data;
using System.Windows.Forms;

namespace Acerto
{
    class OracleConexao : IConexao
    {

        OracleConnection conexao;
        private string server, user, senha;
        public bool conectado;
        public OracleConexao(string user, string senha, string server)
        {
            this.user = user;
            this.senha = senha;
            this.server = server;
            string ConnectionString = "Data Source=" + server + ";Persist Security Info=True;" + "User ID=" + user + ";Password=" + senha + ";Unicode=True";
            Conectar(ConnectionString);
        } // Construtor da classe
        public DataTable Consulta(string query)
        {
            DataTable dt = new DataTable();
            if(conexao.State == ConnectionState.Open)
            {
                OracleCommand command = conexao.CreateCommand();
                command.CommandText = query;
                OracleDataReader reader = command.ExecuteReader();
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
            conexao = new OracleConnection();
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
        public void Close()
        {
            conexao.Close();
            conexao.Dispose();
        } // fecha a conexão
    }
}
