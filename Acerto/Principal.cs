﻿using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Acerto
{
    public partial class Principal : Form
    {
      // OracleConexao conecta = new OracleConexao("deposito", "tec3passos", "bdsac"); // conexão oracle
        MysqlConexao conecta = new MysqlConexao("root", " ", "localhost", "bdsac"); // conexão mysql
        Corretor corretor;
        public string listaME; // String que lista os erros
        public DataTable prodErros; // Tabela de dados dos erros
        //----------------------------------------------------------------------------------------------
        public Principal() { InitializeComponent(); }
        private void Form1_Load(object sender, EventArgs e) //  AO CARREGAR O FORM 
        {
            if (conecta.conectado){    // se conectou 
                lblConexao.Text = "Conectado";
                lblConexao.ForeColor = Color.Green;
            }
            else{ // erro ao conectar
                lblConexao.Text = "Desconectado";
                lblConexao.ForeColor = Color.Red;
            }
        }
        private void Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            conecta.Close();
        } // Ao fechar o Form
        public void Appender(string text,Color cor,RichTextBox campo)
        {
            campo.SelectionStart = campo.TextLength;
            campo.SelectionLength = 0;
            campo.SelectionColor =cor;
            campo.AppendText(text);
            campo.SelectionColor = campo.ForeColor;
        } // Adiciona texto ao richtextbox
        private void btPesquisa_Click(object sender, EventArgs e)
        {
            listaME = "select * from produto";
            // listaME = "select movestdat Data, movestseo Origem, movestsed Destino, movesttip Tipo, movestref Material, movestser Serie, movestncf Nf, me_log Processamento from me where movestseo =" + pesquisar.Value + " and me_est is null and movestdat> '"+ dataInicio.Value.ToString("dd/MM/yyyy")+ "' and movestdat< '" + dataFim.Value.ToString("dd/MM/yyyy") + "' order by movestref, movestser, movestdat";
            Console.WriteLine("Pesquisando filial:{0} de {1} a {2} ", pesquisar.Value, dataInicio.Value.ToString("dd/MM/yyyy"), dataFim.Value.ToString("dd/MM/yyyy"));
            Appender("Pesquisando filial: " + pesquisar.Value + ". ", Color.Black, txtProcessos);
            prodErros = conecta.Consulta(listaME);
            Appender(prodErros.Rows.Count + " Linhas encontradas \n", Color.Black, txtProcessos);
            tabelaNProc.DataSource = prodErros;
        } // Ao clicar na pesquisa
        private void btCorrigir_Click(object sender, EventArgs e)
        {
            foreach(Control contr in grpCondi.Controls){
               if((contr is CheckBox) && ((CheckBox)contr).Checked)
                {
                    Console.WriteLine("Ira Corrigir: " +contr.Text+"\n");
                    Appender("Ira Corrigir: " + contr.Text + "\n", Color.Black,txtProcessos);
                    corretor = new Corretor(prodErros, contr.Text);  
                }
            }
        }
    }  
}

