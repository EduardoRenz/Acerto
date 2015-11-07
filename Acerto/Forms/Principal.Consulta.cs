using System;
using System.Windows.Forms;

namespace Acerto
{
    partial  class Principal
    {
        private bool isPesquiando = false;
        Produto produto;

        private void btConsultaPesquisar_Click(object sender, EventArgs e) // Ao apertar o botão da consulta de produto
        {
           // string query = "select * from produto where material like '%"+ SqlScape(txtConsultaMaterial.Text) + "%' and serie like '%" +SqlScape(txtConsultaSerie.Text) + "%'";
            string query = "select est_set Filial, est_ref material, est_ser serie, est_sal saldo, est_tam tamanho from estoques where est_set = "+ SqlScape(consFilial.Value.ToString())+
               " and est_ref LIKE '%"+ SqlScape(txtConsultaMaterial.Text)+ "%' and est_ser LIKE '%" + SqlScape(txtConsultaSerie.Text) + "%'";
            if (!isPesquiando)
            {
                btConsultaPesquisar.Text = "Cancelar";
                isPesquiando = true;
                gridConsulta.DataSource = conecta.Consulta(query);
                isPesquiando = false;
                btConsultaPesquisar.Text = "Pesquisar";
            }
            else
            {
                conecta.CancelQuery();
            }
        }
        private void gridConsulta_CellDoubleClick(object sender, DataGridViewCellEventArgs e) // Ao dar click duplo em uma celula | Abre nova janela com a pesquisa do produto
        {
            produto = new Produto(gridConsulta.Rows[e.RowIndex].Cells["material"].Value.ToString(), gridConsulta.Rows[e.RowIndex].Cells["serie"].Value.ToString(),Convert.ToInt32(gridConsulta.Rows[e.RowIndex].Cells["Filial"].Value),conecta);
            // no oracle mudar idproduto para filial
        }
    }
}
