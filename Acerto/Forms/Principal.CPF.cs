﻿using System;
using Consulta.utilitarios;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;
using System.Text.RegularExpressions;

namespace Acerto
{
   partial class Principal
    {
        private long cpf;

        private void btCPF_Click(object sender, EventArgs e)
        {
            // Deixa só numeros no valor de cpf
            if(textCPF.Text.Length > 0)
            {
                cpf = Int64.Parse(Regex.Replace(textCPF.Text, @"[^0-9]", ""));
                textCPF.Text = cpf.ToString();
            }
            else
            {
                cpf = 00000000000;
            }

            cpfResultDoc.DataSource = null;
            query = "select distinct trim(mov_dat) data ,mov_doc NF from movimento where mov_cdemp = '"+cpf+"' and rownum <=1000 group by mov_dat,mov_doc";
            gridCPF.DataSource = conecta.Consulta(query);
            setNomeCliente(cpf);
            gridCPF.Sort(gridCPF.Columns["DATA"], ListSortDirection.Ascending);
            gridCPF.Columns["NF"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;



        }
        private void gridCPF_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1){
                query = "select mov_doc nf, mov_seo filial,mov_ref material,mov_ser serie,mov_val preco from movimento where mov_doc= '"+
                         gridCPF["NF", e.RowIndex ].Value+ "' and mov_cdemp = '" + cpf + "' and rownum <=100";
                cpfResultDoc.DataSource = conecta.Consulta(query);
            }
        }
        private void setNomeCliente(long cpf)
        {
            DataTable dt = new DataTable();
            query = "select base_nom from cadastro.base where base_cpf='"+cpf+"'";
            dt = conecta.Consulta(query);

            if(dt.Rows.Count > 0)
            {
                lblClienteNome.Text = dt.Rows[0].Field<string>("base_nom");
            }
            else
            {
                lblClienteNome.Text = "";
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

