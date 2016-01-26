using System;
using System.Data;
using Consulta.utilitarios;
using Consulta.classes;

namespace Acerto
{
    partial class Principal
    {
        public DataTable grupo;
        public DataTable subGrupo;
        public void listarGrupo(OracleConexao conecta)
        {
            grupo = conecta.Consulta("select * from GRUPO");
            comboBoxGrupo.Items.Add(new Grupo(-1, "---"));
            foreach (DataRow row in grupo.Rows)
            {
                // comboBoxGrupo.Items.Add(row[1]);
                comboBoxGrupo.Items.Add(new Grupo(Convert.ToInt32(row[0]),row[1].ToString()));
            }
        } // Busca grupos no banco e adiciona na comboBox
        private void comboBoxGrupo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Grupo resultado = comboBoxGrupo.SelectedItem as Grupo;
            comboBoxSubGrupo.Items.Clear();
            if (resultado.codigo != -1)
            {
                string query = "select * from SUBGRUPO where SUBGRP_GRP = "+ resultado.codigo + "";
                subGrupo =  conecta.Consulta(query);
                foreach (DataRow row in subGrupo.Rows)
                {
                comboBoxSubGrupo.Items.Add(row[2]);
                }
            }
        } // Ao trocar de grupo, o que gera o subgrupo
        private void listaMercadorias(string busca)
        {
          string query = "select * from MERCADORIAS where MERCADO_DES like '"+textProduto.Text+ "'";
            Console.WriteLine(query);
        }// só com busca
        private void listaMercadorias(string busca, Grupo grupo) // com busca e grupo
        {
            string query = "select * from MERCADORIAS where MERCADO_DES like '" + textProduto.Text + "'";
            if (grupo.codigo != -1 && comboBoxGrupo.SelectedIndex != -1)
            {
                query += "and MERCADO_GRP = '" + grupo.codigo + "'";
            }

            Console.WriteLine(query);
        }  
        private void btMercadoriaPesquisa_Click(object sender, EventArgs e)
        {
            if(comboBoxGrupo.SelectedIndex == -1)
            {
                listaMercadorias(textProduto.Text);
            }
            else
            {
                listaMercadorias(textProduto.Text, comboBoxGrupo.SelectedItem as Grupo);
            }
   
            //  Console.WriteLine((Datata)comboBoxGrupo.SelectedItem + (MyEnum)comboBoxGrupo.SelectedText);
        } // Ao pesquisar mercadorias
    }
}
