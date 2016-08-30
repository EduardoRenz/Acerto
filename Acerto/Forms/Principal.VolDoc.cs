using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Acerto
{
   partial class Principal
    {
        private void btVolDoc_Click(object sender, EventArgs e)
        {
            worker = new BackgroundWorker();
            worker.DoWork += new DoWorkEventHandler(VolDocAsync);
            worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(VolDocAsyncCompleta);

            btVolDoc.Text = "Pesquisando";
            btVolDoc.Enabled = false;

            if (radioMatriz.Checked) // Matriz
            {
                query = "SELECT  trim(trf_ref) || trf_ser as serie from transferido where trf_vol  = '"+ numericDoc.Value+ "'  and trf_dtc is null and ROWNUM <= 500 order by trf_ser";
                //Console.WriteLine(query);
                worker.RunWorkerAsync();
            }
            else // Filial
            {
                if(intFilial.Value != 0) // Não é filial 0
                {
                   // query = "SELECT mov_ser as serie from movimento where mov_doc = '" + numericDoc.Value + "' and mov_sed ='" +intFilial.Value + "' and ROWNUM <= 500";
                    query = "SELECT  trim(mov_ref) || mov_ser as mercadoria from movimento where mov_doc = '" + numericDoc.Value + "' and mov_sed ='" + intFilial.Value + "'";
                    worker.RunWorkerAsync();
                }
                else
                {
                    MessageBox.Show("Precisa selecionar uma filial");
                    btVolDoc.Text = "Pesquisar";
                    btVolDoc.Enabled = true;
                }
            }
        }

        private void VolDocAsyncCompleta(object sender, RunWorkerCompletedEventArgs e)
        {
            dataVolDoc.DataSource = e.Result;
            btVolDoc.Text = "Pesquisar";
            btVolDoc.Enabled = true;
        }

        private void VolDocAsync(object sender, DoWorkEventArgs e)
        {
            e.Result = conecta.Consulta(query);
        }
    }
}
