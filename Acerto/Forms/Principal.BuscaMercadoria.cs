using System;
using System.Data;

namespace Acerto
{
    partial class Principal
    {
        public DataTable grupo;
        public void listarGrupo(OracleConexao conecta)
        {
            grupo = conecta.Consulta("select * from GRUPO");
            foreach(DataRow row in grupo.Rows)
            {
                comboBoxGrupo.Items.Add(row[1]);
            }
          
        }
        private void btMercadoriaPesquisa_Click(object sender, EventArgs e)
        {

            //  Console.WriteLine((Datata)comboBoxGrupo.SelectedItem + (MyEnum)comboBoxGrupo.SelectedText);
            Console.WriteLine(grupo.Rows[comboBoxGrupo.SelectedIndex][0]);

            
        }
       
    }
}
