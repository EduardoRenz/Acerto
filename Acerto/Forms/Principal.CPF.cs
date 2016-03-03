using System;
using Consulta.utilitarios;
using System.Windows.Forms;

namespace Acerto
{
   partial class Principal
    {
         private void btCPF_Click(object sender, EventArgs e)
        {
            query = "select count (mov_doc) as Itens,mov_dat data,mov_tip tipo, mov_cdemp CPF ,mov_doc NF from movimento where mov_cdemp = '" + Eduardo.SqlScape(textCPF.Text) +"' and rownum <=1000 group by mov_dat,mov_tip, mov_cdemp,mov_doc";
            gridCPF.DataSource = conecta.Consulta(query);
            gridCPF.Columns["CPF"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        private void gridCPF_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1){
                query = "select mov_doc nf, mov_seo filial,mov_ref material,mov_ser serie,mov_val preco from movimento where mov_doc= '"+gridCPF["NF", e.RowIndex ].Value+"' and mov_cdemp = '" + gridCPF["CPF", e.RowIndex ].Value+ "' and rownum <=100";
                cpfResultDoc.DataSource = conecta.Consulta(query);
            }
        }
    }
}

