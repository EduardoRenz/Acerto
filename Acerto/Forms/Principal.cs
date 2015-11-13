using System;
using System.Data;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Acerto
{
    public partial class Principal : Form
    {
      //OracleConexao conecta = new OracleConexao("deposito", "tec3passos", "bdsac"); // conexão oracle
      MysqlConexao conecta = new MysqlConexao("root", " ", "localhost", "bdsac"); // conexão mysql
        Corretor corretor  = new Corretor();
        public string listaME; // String que lista os erros
        public DataTable prodErros; // Tabela de dados dos erros
        //----------------------------------------------------------------------------------------------
        public Principal() { InitializeComponent(); }
        private void Form1_Load(object sender, EventArgs e) //  AO CARREGAR O FORM 
        {
            Text = "Acertos  v: 1.0.1.1";
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
                panelPesquisa.Visible = false;
                grpCondi.Visible = false;
                splitterErros.Visible = false;
                menuConsulta.Visible = true;
            }
            else
            {
                panelPesquisa.Visible = true;
                grpCondi.Visible = true;
                splitterErros.Visible = true;
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
        public static string SqlScape(string str)
        {
            return Regex.Replace(str, @"[\x00'""\b\n\r\t\cZ\\%_]",
                delegate (Match match)
                {
                    string v = match.Value;
                    switch (v)
                    {
                        case "\x00":            // ASCII NUL (0x00) character
                    return "\\0";
                        case "\b":              // BACKSPACE character
                    return "\\b";
                        case "\n":              // NEWLINE (linefeed) character
                    return "\\n";
                        case "\r":              // CARRIAGE RETURN character
                    return "\\r";
                        case "\t":              // TAB
                    return "\\t";
                        case "\u001A":          // Ctrl-Z
                    return "\\Z";
                        default:
                            return "\\" + v;
                    }
                });
        } // escape variaves sql
        private void Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            conecta.Close();
        } // Ao fechar o Form

       
    }
}

