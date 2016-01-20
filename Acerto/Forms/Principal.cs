using System;
using System.Data;
using System.Windows.Forms;

namespace Acerto
{
    public partial class Principal : Form
    {
        OracleConexao conecta = new OracleConexao("deposito", "tec3passos", "bdsac"); // conexão oracle
        Corretor corretor  = new Corretor();
        public string listaME; // String que lista os erros
        public DataTable prodErros; // Tabela de dados dos erros
        //----------------------------------------------------------------------------------------------
        public Principal() { InitializeComponent(); }
        private void Form1_Load(object sender, EventArgs e) //  AO CARREGAR O FORM 
        {
            Text = "Consulta  v:1.1.0.0";
            VerificaAbas();
            VerificaConexao();
            listarGrupo(conecta);
            //conecta.GetTabelas(); // DESENVOLVEDOR  pega as tabelas do db
            // conecta.GetColunas("OC");
            //conecta.GetBD();
           // conecta.Getschemas();
        }
        private void AbasChanged(object sender, TabControlEventArgs e)
        {
            VerificaAbas();
        } // Quando a aba é trocada
        private void VerificaAbas()
        {
            grpCondi.Visible = false;
            panelDatas.Visible = false;
            menuConsulta.Visible = false;
            tabConsultar.Visible = false;
            mercadoriaPanel.Visible = false;
            switch (abas.SelectedTab.Name)
            {
                case "pagErros":
                    panelDatas.Visible = true;
                    break;
                case "tabConsultar":
                    menuConsulta.Visible = true;
                    break;
                case "tabMercadorias":
                    mercadoriaPanel.Visible = true;
                    break;
                default:
                    break;
            }
        } // executa ação de aba trocada
        private void VerificaConexao()
        {
            if (conecta.conectado)
            {    // se conectou 
              
            }
            else
            { // erro ao conectar

            }
        }
        private void Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            conecta.Close();
        } // Ao fechar o Form      

      
    }
}

