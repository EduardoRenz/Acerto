using System;
using System.ComponentModel;
using System.Data;
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
            query = "select * from produto where material like '%"+ SqlScape(txtConsultaMaterial.Text) + "%' and serie like '%" +SqlScape(txtConsultaSerie.Text) + "%'";
          //   query = "select est_set Filial, est_ref material, est_ser serie, est_sal saldo, est_tam tamanho from estoques where est_set = "+ SqlScape(consFilial.Value.ToString())+
         //   " and est_ref LIKE '%"+ SqlScape(txtConsultaMaterial.Text)+ "%' and est_ser LIKE '%" + SqlScape(txtConsultaSerie.Text) + "%'";
            if (!isPesquiando && !worker.IsBusy)
            {
                btConsultaPesquisar.Text = "pesquisando...";
                btConsultaPesquisar.Enabled = false;
                isPesquiando = true;
                worker.RunWorkerAsync();
              //  gridConsulta.DataSource = conecta.Consulta(query);      
            }
            else
            {
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
            ConsultaNumLinhas.Text = gridConsulta.RowCount + " mercadorias encontradas";
            isPesquiando = false;
            btConsultaPesquisar.Text = "Pesquisar";
            btConsultaPesquisar.Enabled = true;
        }   
        private void gridConsulta_CellDoubleClick(object sender, DataGridViewCellEventArgs e) // Ao dar click duplo em uma celula | Abre nova janela com a pesquisa do produto
        {
            if(e.RowIndex != -1){
               // produto = new Produto(gridConsulta.Rows[e.RowIndex].Cells["material"].Value.ToString(), gridConsulta.Rows[e.RowIndex].Cells["serie"].Value.ToString(),Convert.ToInt32(gridConsulta.Rows[e.RowIndex].Cells["Filial"].Value),conecta);
                 produto = new Produto(gridConsulta.Rows[e.RowIndex].Cells["material"].Value.ToString(), gridConsulta.Rows[e.RowIndex].Cells["serie"].Value.ToString(), Convert.ToInt32(gridConsulta.Rows[e.RowIndex].Cells["idproduto"].Value), conecta);
                // no oracle mudar idproduto para filial
            }
        }
    }
}
