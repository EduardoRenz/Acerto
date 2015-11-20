using System;
using System.Windows.Forms;

namespace Acerto
{
    partial class Produto : Form
    {

        private string serie { get; set; }
        private string material { get; set; }
        private int filial { get; set; }
        //private MysqlConexao conecta;
        private OracleConexao conecta;

        public Produto(string material, string serie,int filial,MysqlConexao conecta)  {
            Initialize(material, serie,filial);
            //this.conecta = conecta;
            Show();
        }  // Construtor Mysql
        public Produto(string material, string serie, int filial, OracleConexao conecta)
        {
            Initialize(material, serie, filial);
            this.conecta = conecta;
            Show();
        }  // Construtor Oracle
        private void Produto_Load(object sender, EventArgs e)
        {
            MostraHistorico(conecta); // lentro pra pesquisa
            MostraSaldo(conecta);
        }
        private void Initialize(string material, string serie, int filial)
        {
            InitializeComponent();
            this.serie = serie;
            this.material = material;
            this.filial = filial;
            lblProdMaterial.Text = material;
            lblProdSerie.Text = serie;
            ProdLblFilial.Text = "Filial:" + filial;
            Text = filial + " | " + material + " | " + serie;
        } // Inicio padrão para o construtor desta classe
        // HISTORICOS
        private void MostraHistorico(MysqlConexao conecta)
        {
            string query = "select * from produto";
            ProdGridHist.DataSource = conecta.Consulta(query);
        } // tabela de historico do produto mysql
        private void MostraHistorico(OracleConexao conecta)
        {
            string query = "select mov_dat Data, mov_seo Origem, mov_sed Destino, mov_tip tipo, mov_doc nf from movimento where mov_ref = '"+material+"' and mov_ser = '"+serie+"' order by mov_dat";
            ProdGridHist.DataSource = conecta.Consulta(query);
        } // tabela de historico do produto oracle
        //SALDOS
        private void MostraSaldo(MysqlConexao conecta) {
            string query = "SELECT  DATE_FORMAT(dataHora,'%d/%m/%Y %h:%i') as Data,descricao FROM produto,historico WHERE produto_idProduto = produto.idProduto and material =" + material;
            prodGridSaldos.DataSource = conecta.Consulta(query);
        }
        private void MostraSaldo(OracleConexao conecta) {
            string query = "select est_set Filial, est_sal saldo, est_tam tamanho from estoques where est_ref = '"+material+"' and est_ser = '"+ (serie).Trim()+"'";
            prodGridSaldos.DataSource = conecta.Consulta(query);
        }
        // Eventos do FORM
        private void Produto_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dispose();
        } // ao fechar a janela

      
    }
}
