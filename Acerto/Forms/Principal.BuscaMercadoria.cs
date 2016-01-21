using System;
using System.Data;

namespace Acerto
{
    partial class Principal
    {
        public DataTable grupo;
        public DataTable subGrupo;
        public void listarGrupo(OracleConexao conecta)
        {
            grupo = conecta.Consulta("select * from GRUPO");
            comboBoxGrupo.Items.Add("---");
            foreach(DataRow row in grupo.Rows)
            {
                comboBoxGrupo.Items.Add(row[1]);
            }
        } // Busca grupos no banco e adiciona na comboBox
        private void btMercadoriaPesquisa_Click(object sender, EventArgs e)
        {
            //  Console.WriteLine((Datata)comboBoxGrupo.SelectedItem + (MyEnum)comboBoxGrupo.SelectedText);
        } // Ao pesquisar mercadorias
        private void comboBoxGrupo_SelectedIndexChanged(object sender, EventArgs e)
        {
           // Console.WriteLine(grupo.Rows[comboBoxGrupo.SelectedIndex][0]);
            comboBoxSubGrupo.Items.Clear();
            if (comboBoxGrupo.SelectedItem.ToString() != "---" || comboBoxGrupo.SelectedItem.ToString() == "")
            {
                string query = "select * from SUBGRUPO where SUBGRP_GRP = '"+ grupo.Rows[comboBoxGrupo.SelectedIndex][0] + "'";
                subGrupo =  conecta.Consulta(query);
                foreach (DataRow row in subGrupo.Rows)
                {
                comboBoxSubGrupo.Items.Add(row[2]);
                }
                Console.WriteLine(comboBoxGrupo.SelectedItem);
            }
        } // Ao trocar de grupo, o que gera o subgrupo
        private void listaMercadorias(string busca,string grupo,string subgrupo)
        {

        }
    }
}
