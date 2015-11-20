using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acerto
{
    partial class Principal
    {
        private void btPesquisa_Click(object sender, EventArgs e)
        {
            txtProcessos.Clear();
            // listaME = "select * from produto";
           listaME = "select movestdat Data, movestseo Origem, movestsed Destino, movesttip Tipo, movestref Material, movestser Serie, movestncf Nf, me_log Processamento from me where me_est is null and movestdat> '" + dataInicio.Value.ToString("dd/MM/yyyy") + "' and movestdat< '" + dataFim.Value.ToString("dd/MM/yyyy")+"'";
             if (intFilial.Value != 0)
              {
                 listaME += " and movestseo ='" + intFilial.Value+"' ";
              }

            listaME += " order by movestref, movestser, movestdat";



            Appender("Pesquisando filial: " + intFilial.Value + ". ", Color.Black, txtProcessos);
            prodErros = conecta.Consulta(listaME);
            Appender(prodErros.Rows.Count + " Linhas encontradas \n", Color.Green, txtProcessos);
            tabelaNProc.DataSource = prodErros;
        } // Ao clicar na pesquisa
        private void btCorrigir_Click(object sender, EventArgs e)
        {
            foreach (Control contr in grpCondi.Controls) {
                if ((contr is CheckBox) && ((CheckBox)contr).Checked) {
                    Console.WriteLine(" -------------------- Ira Corrigir: " + contr.Text + " \n");
                    Appender("-------------------------------------------- Ira Corrigir: " + contr.Text + " \n", Color.Black, txtProcessos);
                    for (int i = 0; i < prodErros.Rows.Count; i++)
                    {
                        corretor.Analise(prodErros, i, contr.Text, txtProcessos);
                    }
                }
            }
        } // click no corrigir
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
