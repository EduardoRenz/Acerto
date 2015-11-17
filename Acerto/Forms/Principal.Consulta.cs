using Consulta.utilitarios;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Acerto
{
    partial  class Principal
    {
        private bool isPesquiando = false;
        Produto produto;
        BackgroundWorker worker;
        string query;

        private void btConsultaPesquisar_Click(object sender, EventArgs e) // Ao apertar o botão da consulta de produto
        {
            // ==================================WORKER=========================================
            worker = new BackgroundWorker();
            worker.DoWork +=  new DoWorkEventHandler(PesquisaAsync);
            worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(PesquisaAsyncCompleta);
            worker.WorkerReportsProgress = true;
            worker.WorkerSupportsCancellation = true;
            // ==================================================================================
            query = "select filial.filial, material , serie, saldo from produto,estoque,filial where  material like '%" + Eduardo.SqlScape(txtConsultaMaterial.Text) +
                     "%' and serie like '%" + Eduardo.SqlScape(txtConsultaSerie.Text) + "%' ";
            if(intFilial.Value != 0) {
                query += "and filial.filial = " + intFilial.Value + " ";
            }
             query +=   "and produto.idProduto = estoque.produto_idProduto AND filial.idfilial = estoque.filial_idfilial" ;

            // ============================================== QUERY DO ORACLE =================================================================================
            //query = "select est_set Filial, est_ref material, est_ser serie, est_sal saldo, est_tam tamanho from estoques where "+
            //        "est_ref LIKE '%"+ Eduardo.SqlScape(txtConsultaMaterial.Text)+ "%' and est_ser LIKE '%" + Eduardo.SqlScape(txtConsultaSerie.Text) + "%'";
            //if (consFilial.Value != 0){
            //    query += "and est_set = " + Eduardo.SqlScape(consFilial.Value.ToString());
            //} 
            //    query += " and ROWNUM <= 2000";
            // ==================================================================================================================================================
            if (!isPesquiando && !worker.IsBusy) {
                btConsultaPesquisar.Text = "pesquisando...";
                btConsultaPesquisar.Enabled = false;
                isPesquiando = true;
                worker.RunWorkerAsync();     
            }
            else {
                conecta.CancelQuery();
            }
        }
        private void PesquisaAsync(object sender, DoWorkEventArgs e)
        {
            e.Result = conecta.Consulta(query);
        } // Roda pesquisa async
        private void PesquisaAsyncCompleta(object sender, RunWorkerCompletedEventArgs e)
        {
            gridConsulta.DataSource = e.Result;
            ConsultaNumLinhas.Text = gridConsulta.RowCount + " mercadorias encontradas (max por consulta:2000)";
            isPesquiando = false;
            btConsultaPesquisar.Text = "Pesquisar";
            btConsultaPesquisar.Enabled = true;
        }   
        private void gridConsulta_CellDoubleClick(object sender, DataGridViewCellEventArgs e) // Ao dar click duplo em uma celula | Abre nova janela com a pesquisa do produto
        {
            if(e.RowIndex != -1){
               produto = new Produto(gridConsulta.Rows[e.RowIndex].Cells["material"].Value.ToString(), gridConsulta.Rows[e.RowIndex].Cells["serie"].Value.ToString(),Convert.ToInt32(gridConsulta.Rows[e.RowIndex].Cells["Filial"].Value),conecta);
                // produto = new Produto(gridConsulta.Rows[e.RowIndex].Cells["material"].Value.ToString(), gridConsulta.Rows[e.RowIndex].Cells["serie"].Value.ToString(), Convert.ToInt32(gridConsulta.Rows[e.RowIndex].Cells["idproduto"].Value), conecta);
                // no oracle mudar idproduto para filial
            }
        }
    }
}
