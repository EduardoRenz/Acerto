using System;
using System.Drawing;
using System.Windows.Forms;

namespace Acerto
{
    partial class Principal
    {
        private void btPesquisa_Click(object sender, EventArgs e)
        {
            // listaME = "select * from produto";
           listaME = "select movestdat Data, movestseo Origem, movestsed Destino, movesttip Tipo, movestref Material, movestser Serie, movestncf Nf, me_log Processamento from me where me_est is null and movestdat> '" + dataInicio.Value.ToString("dd/MM/yyyy") + "' and movestdat< '" + dataFim.Value.ToString("dd/MM/yyyy")+"'";
             if (intFilial.Value != 0)
              {
                 listaME += " and movestseo ='" + intFilial.Value+"' ";
              }
            listaME += " order by movestref, movestser, movestdat";
            prodErros = conecta.Consulta(listaME);
            tabelaNProc.DataSource = prodErros;
            ConsultaNumLinhas.Text = tabelaNProc.RowCount + " Acertos encontrados.";
        } // Ao clicar na pesquisa
      
        private void tabelaNProc_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                produto = new Produto(tabelaNProc.Rows[e.RowIndex].Cells["material"].Value.ToString(), tabelaNProc.Rows[e.RowIndex].Cells["serie"].Value.ToString(), Convert.ToInt32(tabelaNProc.Rows[e.RowIndex].Cells["Origem"].Value), conecta);
            }
        }
        public void Appender(string text, Color cor, RichTextBox campo)
        {
            campo.SelectionStart = campo.TextLength;
            campo.SelectionLength = 0;
            campo.SelectionColor = cor;
            campo.AppendText(text);
            campo.SelectionColor = campo.ForeColor;
        } // Adiciona texto ao richtextbox
    }
}
