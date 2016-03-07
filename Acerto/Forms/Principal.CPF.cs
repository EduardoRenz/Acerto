﻿using System;
using Consulta.utilitarios;
using System.Windows.Forms;
using System.ComponentModel;

namespace Acerto
{
   partial class Principal
    {
         private void btCPF_Click(object sender, EventArgs e)
        {
            cpfResultDoc.DataSource = null;
            query = "select distinct trim(mov_dat) data ,mov_doc NF from movimento where mov_cdemp = '" + textCPF.Value +"' and rownum <=1000 group by mov_dat,mov_doc";
            gridCPF.DataSource = conecta.Consulta(query);
            gridCPF.Sort(gridCPF.Columns["DATA"], ListSortDirection.Ascending);
            gridCPF.Columns["NF"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        private void gridCPF_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1){
                query = "select mov_doc nf, mov_seo filial,mov_ref material,mov_ser serie,mov_val preco from movimento where mov_doc= '"+
                         gridCPF["NF", e.RowIndex ].Value+ "' and mov_cdemp = '" + textCPF.Value + "' and rownum <=100";
                cpfResultDoc.DataSource = conecta.Consulta(query);
            }
        }
        private void cpfResultDoc_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                produto = new Produto(cpfResultDoc.Rows[e.RowIndex].Cells["material"].Value.ToString(), cpfResultDoc.Rows[e.RowIndex].Cells["serie"].Value.ToString(), Convert.ToInt32(cpfResultDoc.Rows[e.RowIndex].Cells["Filial"].Value), conecta);
            }
        }
    }
}

