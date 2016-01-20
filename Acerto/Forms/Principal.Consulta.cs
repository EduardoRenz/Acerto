using Consulta.utilitarios;
using System;
using System.ComponentModel;
using System.Text.RegularExpressions;
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
           string[] matSer = arruma(lblCodProd.Text);
           string material = matSer[0];
           string serie = matSer[1];
            // ==================================WORKER=========================================
            worker = new BackgroundWorker();
            worker.DoWork +=  new DoWorkEventHandler(PesquisaAsync);
            worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(PesquisaAsyncCompleta);
            worker.WorkerReportsProgress = true;
            worker.WorkerSupportsCancellation = true;
 
            // ============================================== QUERY DO ORACLE =================================================================================
            query = "select est_set Filial, est_ref material, est_ser serie, est_sal saldo, est_tam tamanho from estoques where " +
                    "est_ref LIKE '%" + Eduardo.SqlScape(material) + "%' and est_ser LIKE '%" + Eduardo.SqlScape(serie) + "%'";
            if (intFilial.Value != 0)
            {
                query += "and est_set = " + Eduardo.SqlScape(intFilial.Value.ToString());
            }
            query += " and ROWNUM <= 1000";
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
            ConsultaNumLinhas.Text = gridConsulta.RowCount + " mercadorias encontradas (max por consulta:1000)";
            isPesquiando = false;
            btConsultaPesquisar.Text = "Pesquisar";
            btConsultaPesquisar.Enabled = true;
        }   
        private void gridConsulta_CellDoubleClick(object sender, DataGridViewCellEventArgs e) // Ao dar click duplo em uma celula | Abre nova janela com a pesquisa do produto
        {
            if(e.RowIndex != -1){
               produto = new Produto(gridConsulta.Rows[e.RowIndex].Cells["material"].Value.ToString(), gridConsulta.Rows[e.RowIndex].Cells["serie"].Value.ToString(),Convert.ToInt32(gridConsulta.Rows[e.RowIndex].Cells["Filial"].Value),conecta);
            }
        }

        /// TESTES
        /// 
        private string[] arruma(string str)
        {
            char[] toTrim = { '.', '-', ' ', '_','*','"','%' };
            string[] materialSerie  = new string[2];
            // remover todos os especiais
            foreach(char chars in toTrim)
            {
              str =  str.Replace(chars, ' ');
            }
           str =  Regex.Replace(str, @"\s+", "");
            Console.WriteLine("Removido ponto e traços:" + str);

            if (Regex.Matches(str, @"[a-zA-Z]").Count > 0)
            {
                Console.WriteLine("LETRAS");
                materialSerie[0] = Regex.Replace(str, @"[^0-9]", "");
                materialSerie[1] = Regex.Replace(str, @"[0-9]", "");
            }
            else
            {
                Console.WriteLine("Só de numeros");
                if (str.Length < 12 && str.Length >= 8)
                {
                    materialSerie[0] = str.Substring(0, 8);
                    materialSerie[1] = "";
                }
                else if((str.Length >= 12))
                {
                    materialSerie[0] = str.Substring(0, 8);
                    materialSerie[1] = str.Substring(8, 4);
                }
               else if((str == "") || str == null)
                {
                    materialSerie[0] = "";
                    materialSerie[1] = "";
                }
                else
                {
                    materialSerie[0] = str;
                    materialSerie[1] = "";
                }
                
                

            }
            Console.WriteLine("MAterial:{0}  Serie: {1}", materialSerie[0], materialSerie[1]);
            return materialSerie;
        }
    }
}
