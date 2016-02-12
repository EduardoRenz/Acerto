using Consulta.utilitarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace Acerto
{
    partial class Principal
    {
        private void btVolume_Click(object sender, EventArgs e)
        {

            worker = new BackgroundWorker();
            worker.DoWork += new DoWorkEventHandler(PesquisaVolAsync);
            worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(PesquisaVolAsyncCompleta);
            worker.WorkerReportsProgress = true;
            worker.WorkerSupportsCancellation = true;
            btVolume.Text = "Pesquisando...";
            btVolume.Enabled = false;
            worker.RunWorkerAsync();
          //  ConsultaNumLinhas.Text = gridVolumeMatriz.RowCount + " mercadorias encontradas no volume";
        }

        private void PesquisaVolAsyncCompleta(object sender, RunWorkerCompletedEventArgs e)
        {
            btVolume.Text = "Pesquisar";
            btVolume.Enabled = true;
            gridVolume.DataSource = e.Result;
            ConsultaNumLinhas.Text = gridVolume.Rows.Count + " Mercadorias encontradas no volume.";
        }
        private void PesquisaVolAsync(object sender, DoWorkEventArgs e)
        {
            if (radioVolFil.Checked)
            {
                if(intFilial.Value != 0)
                {
                    e.Result = volFilial();
                }
                else
                {
                    MessageBox.Show("Necessário selecionar filial");
                    worker.CancelAsync();
                }
                
            }
            else if (radioVolMat.Checked)
            {
                e.Result = volMatriz();
            }    
        }

        private DataTable volFilial()
        {
            query = "SELECT mov_ser as serie from movimento where mov_doc = '" +intVolumes.Value+"'";

            if (intFilial.Value != 0)
            {
                query += " and mov_sed ='" + intFilial.Value+ "' and ROWNUM <= 500";
            }
            return conecta.Consulta(query);
        }
        private DataTable volMatriz()
        {
          return  conecta.Consulta("SELECT  trf_ser as serie from transferido where trf_vol  = '" +intVolumes.Value + "'  and trf_dtc is null order by trf_ser");
        }

    }
}
