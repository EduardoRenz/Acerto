﻿using System;
using System.Data.OracleClient;
//using Oracle.DataAccess.Client;
using System.Data;
using System.Windows.Forms;
using System.Collections.Generic;

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
        public List<string> GetTabelas()
        {
            List<string> lista =  new List<string>();
            command = conexao.CreateCommand();
            command.CommandText = "SELECT DISTINCT OBJECT_NAME FROM USER_OBJECTS WHERE OBJECT_TYPE = 'TABLE'";
            reader = command.ExecuteReader();
            Console.WriteLine(" \n Pegando Tabelas do banco...");
            while (reader.Read())  {
                lista.Add(reader[0].ToString());
                Console.Write(reader[0].ToString()+" | ");
            }
            Console.Write("\n");
            reader.Close();
            return lista;
        } // Pega Tabelas do BD
        public List<string> GetColunas(string tabela)
        {
            //SELECT table_name, column_name, data_type, data_lengthFROM USER_TAB_COLUMNSWHERE table_name = 'MYTABLE'
            List<string> lista = new List<string>();
            command = conexao.CreateCommand();
            command.CommandText = "SELECT column_name FROM USER_TAB_COLUMNS WHERE table_name ='"+tabela+"'";
            reader = command.ExecuteReader();
            Console.WriteLine("Pegando Colunas de " + tabela+"\n");
            while (reader.Read())
            {
                lista.Add(reader[0].ToString());
              //  Console.WriteLine(reader[0].ToString());
            }
            return lista;
        } // Pega Colunas da tabela
        public void GetBD()
        {
            List<string> tabelas = new List<string>();
            List<string> colunas = new List<string>();
            tabelas = GetTabelas();
            foreach (var tabela in tabelas)
            {
                Console.WriteLine(tabela.ToString());
                foreach (var coluna in GetColunas(tabela.ToString()))
                {
                    Console.WriteLine("-- " + coluna.ToString());
                }
            }
        } // Une gettabelas e getcolunas
        public void GetUsuarios() // pega usuarios do bd
        {
            command = conexao.CreateCommand();
           // command.CommandText = "SELECT * FROM all_users"; // Usuarios
            command.CommandText = "SELECT * FROM all_users";
            try
            {
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.Write(reader[0].ToString() + " | ");
                }

                reader.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
           
        }
        public void Teste(string query)
        {
            Console.WriteLine("Iniciar teste...");
            DataTable dt = new DataTable();
            command = conexao.CreateCommand();
            command.CommandText = query;
            reader = command.ExecuteReader();
            dt.Load(reader);
            reader.Close();
            foreach(DataRow row in dt.Rows)
            {
                foreach (DataColumn col in dt.Columns)
                {
                    Console.WriteLine(col.ColumnName + " : " + row[col.ColumnName]);
                }
                Console.WriteLine(" ");
            }

          

        }
        public void Close()
        {
            conexao.Close();
            conexao.Dispose();
        } // fecha a conexão
    }
}
