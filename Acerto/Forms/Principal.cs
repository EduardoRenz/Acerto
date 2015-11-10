using System;
using System.Data;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Acerto
{
    public partial class Principal : Form
    {
     // OracleConexao conecta = new OracleConexao("deposito", "tec3passos", "bdsac"); // conexão oracle
        MysqlConexao conecta = new MysqlConexao("root", " ", "localhost", "bdsac"); // conexão mysql
        Corretor corretor  = new Corretor();
        public string listaME; // String que lista os erros
        public DataTable prodErros; // Tabela de dados dos erros
        //----------------------------------------------------------------------------------------------
        public Principal() { InitializeComponent(); }
        private void Form1_Load(object sender, EventArgs e) //  AO CARREGAR O FORM 
        {
            Text = "Acertos  v:" + ProductVersion;
            VerificaAbas();
            VerificaConexao();
        }
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
           txtProcessos.Clear();
          listaME = "select * from produto";
         //  listaME = "select movestdat Data, movestseo Origem, movestsed Destino, movesttip Tipo, movestref Material, movestser Serie, movestncf Nf, me_log Processamento from me where movestseo =" + pesquisar.Value + " and me_est is null and movestdat> '"+ dataInicio.Value.ToString("dd/MM/yyyy")+ "' and movestdat< '" + dataFim.Value.ToString("dd/MM/yyyy") + "' order by movestref, movestser, movestdat";
           Appender("Pesquisando filial: " + pesquisar.Value + ". ", Color.Black, txtProcessos);
           prodErros = conecta.Consulta(listaME);
           Appender(prodErros.Rows.Count + " Linhas encontradas \n", Color.Green, txtProcessos);
           tabelaNProc.DataSource = prodErros;
        } // Ao clicar na pesquisa
        private void btCorrigir_Click(object sender, EventArgs e)
        {
            foreach(Control contr in grpCondi.Controls){
               if((contr is CheckBox) && ((CheckBox)contr).Checked)
                {
                    Console.WriteLine(" -------------------- Ira Corrigir: " +contr.Text+" \n");
                    Appender("-------------------------------------------- Ira Corrigir: " + contr.Text + " \n", Color.Black,txtProcessos);
                    for(int i = 0; i< prodErros.Rows.Count; i++)
                    {
                        corretor.Analise(prodErros,i,contr.Text,txtProcessos); 
                    }
                }
            }
        } // click no corrigir
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

