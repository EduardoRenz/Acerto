using System;
using System.Windows.Forms;

namespace Acerto
{
    partial class Produto : Form
    {

        private string serie { get; set; }
        private string material { get; set; }
        private int filial { get; set; }

        public Produto(string material, string serie,int filial,MysqlConexao conecta)  {
            Initialize(material, serie,filial);
            string query = "SELECT  dataHora as Data,descricao FROM produto,historico WHERE produto_idProduto = produto.idProduto and material =" + material;
            MostraHistorico(conecta);
            MostraSaldo(conecta);
            Show();
        }  // Construtor Mysql
        public Produto(string material, string serie, int filial, OracleConexao conecta)
        {
            Initialize(material, serie, filial);
            MostraHistorico(conecta);
            MostraSaldo(conecta);
            Show();
        }  // Construtor Oracle
        private void Initialize(string material, string serie, int filial)
        {
            this.serie = serie;
            this.material = material;
            this.filial = filial;
            InitializeComponent();
            lblProdMaterial.Text = material;
            lblProdSerie.Text = serie;
            ProdLblFilial.Text = "Filial:" + filial;
            Text = filial + " | " + material + " | " + serie;
        } // Inicio padrão para o construtor desta classe

        // HISTORICOS
        private void MostraHistorico(MysqlConexao conecta)
        {
            string query = "historico mysql";
            ProdGridHist.DataSource = conecta.Consulta(query);
        } // tabela de historico do produto mysql
        private void MostraHistorico(OracleConexao conecta)
        {
            string query = "select mov_dat Data, mov_seo Origem, mov_sed Destino, mov_tip tipo, mov_doc nf from movimento where mov_ref = " + material + " and mov_ser = '" + serie + "' order by mov_dat";
            ProdGridHist.DataSource = conecta.Consulta(query);
        } // tabela de historico do produto oracle
        //SALDOS
        private void MostraSaldo(MysqlConexao conecta) {
            string query = "select est_set Filial, est_ref material, est_ser serie, est_sal saldo, est_tam tamanho from estoques where est_ref = '" + material + "' and est_ser = '" + serie + "'";
            prodGridSaldos.DataSource = conecta.Consulta(query);
            Console.WriteLine("aaaaa " + query);
        }
        private void MostraSaldo(OracleConexao conecta) {
            string query = "select est_set Filial, est_sal saldo, est_tam tamanho from estoques where est_ref = '"+material+"' and est_ser = '"+serie+"'";
            prodGridSaldos.DataSource = conecta.Consulta(query);
            Console.WriteLine("aaaaa " +query);
        }
        // Eventos do FORM
        private void Produto_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dispose();
        } // ao fechar a janela
    }
}
