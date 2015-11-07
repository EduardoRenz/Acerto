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
        public Produto(string material, string serie,int filial,MysqlConexao conecta)  {
            Initialize(material, serie,filial);
            string query = "SELECT  dataHora as Data,descricao FROM produto,historico WHERE produto_idProduto = produto.idProduto and material =" + material;
            ProdGridHist.DataSource = conecta.Consulta(query);
            Show();
        }  // Construtor Mysql
        public Produto(string material, string serie, int filial, OracleConexao conecta)
        {
            Initialize(material, serie, filial);
            string query = "oracle    query";
            ProdGridHist.DataSource = conecta.Consulta(query);
            Show();
        }  // Construtor Oracle
        private void Initialize(string material, string serie, int filial)
        {
            InitializeComponent();
            lblProdMaterial.Text = material;
            lblProdSerie.Text = serie;
            ProdLblFilial.Text = "Filial:" + filial;
            Text = filial + " | " + material + " | " + serie;
        } // Inicio padrão para o construtor desta classe
        private void Produto_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dispose();
        } // ao fechar a janela
    }
}
