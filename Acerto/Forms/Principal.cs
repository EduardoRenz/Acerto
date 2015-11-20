using System;
using System.Data;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Acerto
{
    public partial class Principal : Form
    {
     OracleConexao conecta = new OracleConexao("deposito", "tec3passos", "bdsac"); // conexão oracle
    //  MysqlConexao conecta = new MysqlConexao("root", " ", "localhost", "bdsac"); // conexão mysql
        Corretor corretor  = new Corretor();
        public string listaME; // String que lista os erros
        public DataTable prodErros; // Tabela de dados dos erros
        //----------------------------------------------------------------------------------------------
        public Principal() { InitializeComponent(); }
        private void Form1_Load(object sender, EventArgs e) //  AO CARREGAR O FORM 
        {
            Text = "Acertos  v:1.0.4.1";
            VerificaAbas();
            VerificaConexao();
        }
        private void AbasChanged(object sender, TabControlEventArgs e)
        {
            VerificaAbas();
        } // Quando a aba é trocada
        private void VerificaAbas()
        {
            if (abas.SelectedTab.Name != "pagErros")
            {
                flowLayoutPanel1.Visible = false;
                grpCondi.Visible = false;

                menuConsulta.Visible = true;
            }
            else
            {
                flowLayoutPanel1.Visible = true;
                grpCondi.Visible = true;
 
                menuConsulta.Visible = false;
            }
        }
        private void VerificaConexao()
        {
            if (conecta.conectado)
            {    // se conectou 
                lblConexao.Text = "Conectado";
                lblConexao.ForeColor = Color.GreenYellow;
            }
            else
            { // erro ao conectar
                lblConexao.Text = "Desconectado";
                lblConexao.ForeColor = Color.Red;
            }
        }
        private void Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            conecta.Close();
        } // Ao fechar o Form      

      
    }
}

