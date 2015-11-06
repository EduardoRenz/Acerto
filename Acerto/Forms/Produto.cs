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
            InitializeComponent();
            lblProdMaterial.Text = material;
            lblProdSerie.Text = serie;
            ProdLblFilial.Text = "Filial:" + filial;
            Text = filial + " | " + material +" | "+ serie;
            string query = "SELECT  dataHora,material,serie,descricao FROM produto,historico WHERE produto_idProduto = produto.idProduto and material =" + material;
            ProdGridHist.DataSource = conecta.Consulta(query);
            Show();
        }  // Construtor


        private void Produto_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dispose();
        } // ao fechar a janela
    }
}
