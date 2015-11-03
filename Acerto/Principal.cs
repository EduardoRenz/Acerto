using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acerto
{
    public partial class Principal : Form
    {
      // OracleConexao conecta = new OracleConexao("deposito", "tec3passos", "bdsac");
        MysqlConexao conecta = new MysqlConexao("root", " ", "localhost", "bdsac"); // Classe de conexão (mysql)
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
        private void btPesquisa_Click(object sender, EventArgs e)
        {
            listaME = "select * from produto";
            // listaME = "select movestdat Data, movestseo Origem, movestsed Destino, movesttip Tipo, movestref Material, movestser Serie, movestncf Nf, me_log Processamento from me where movestseo =" + pesquisar.Value + " and me_est is null and movestdat> '"+ dataInicio.Value.ToString("dd/MM/yyyy")+ "' and movestdat< '" + dataFim.Value.ToString("dd/MM/yyyy") + "' order by movestref, movestser, movestdat";
            Console.WriteLine("Pesquisando filial:{0} de {1} a {2} ",pesquisar.Value,dataInicio.Value.ToString("dd/MM/yyyy"), dataFim.Value.ToString("dd/MM/yyyy"));
            Appender("Pesquisando filial: " + pesquisar.Value + ". ", Color.Black, txtProcessos);
            prodErros = conecta.Consulta(listaME);
            Appender(prodErros.Rows.Count + " Linhas encontradas \n", Color.Black, txtProcessos);
            tabelaNProc.DataSource = prodErros;
        } // Ao clicar na pesquisa
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
    }  
}

