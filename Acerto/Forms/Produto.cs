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
    partial class Produto : Form
    {

        private string serie { get; set; }
        private string material { get; set; }
        private int filial { get; set; }

        public Produto(string material, string serie,int filial,MysqlConexao conecta)  {
            Initialize(material, serie,filial);
            string query = "SELECT  dataHora as Data,descricao FROM produto,historico WHERE produto_idProduto = produto.idProduto and material =" + material;
            MostraHistorico(conecta);
            Show();
        }  // Construtor Mysql
        public Produto(string material, string serie, int filial, OracleConexao conecta)
        {
            Initialize(material, serie, filial);
            MostraHistorico(conecta);
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
        private void MostraHistorico(MysqlConexao conecta)
        {
            string query = "historico mysql";
            Console.WriteLine(query);
            ProdGridHist.DataSource = conecta.Consulta(query);
        } // tabela de historico do produto mysql
        private void MostraHistorico(OracleConexao conecta)
        {
            string query = "select mov_dat Data, mov_seo Origem, mov_sed Destino, mov_tip tipo, mov_doc nf from movimento where mov_ref = " + material + " and mov_ser = '" + serie + "' order by mov_dat";
            Console.WriteLine(query);
            ProdGridHist.DataSource = conecta.Consulta(query);
        } // tabela de historico do produto oracle
        private void Produto_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dispose();
        } // ao fechar a janela
    }
}
