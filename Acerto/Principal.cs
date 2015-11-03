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
       OracleConexao conecta = new OracleConexao("deposito", "tec3passos", "bdsac");
      //  MysqlConexao conecta = new MysqlConexao("root", " ", "localhost", "bdsac"); // Classe de conexão (mysql)
        public string listaME;
        public DataTable prodErros;
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
            listaME = "select material as Material, serie as 'Serie(letras)' from produto";
            // listaME = "select movestdat Data, movestseo Origem, movestsed Destino, movesttip Tipo, movestref Material, movestser Serie, movestncf Nf, me_log Processamento from me where movestseo =" + pesquisar.Value + " and me_est is null and movestdat> '01/07/2015' and movestdat< '01/08/2015' order by movestref, movestser, movestdat";
            // prodErros =  new List<Produto>();
           // tabelaNProc.DataSource = conecta.select(listaME, tabelaNProc);
            Console.WriteLine("Pesquisando filial:{0} ",pesquisar.Value);
            prodErros = conecta.Consulta(listaME);
            tabelaNProc.DataSource = prodErros;
            conecta.Close();
        }

        private void Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            conecta.Close();
        }
    }
    
}
