using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acerto
{
   public partial  class Principal
    {

        private void btConsultaPesquisar_Click(object sender, EventArgs e)
        {
          string query = "select est_set Filial, est_ref material, est_ser serie, est_sal saldo, est_tam tamanho from estoques where est_set = "+consFilial.Value+" and est_ref LIKE '%"+txtConsultaMaterial.Text+ "%' and est_ser LIKE '%" + txtConsultaSerie.Text + "%'";
            Console.WriteLine(query);

            gridConsulta.DataSource =   conecta.Consulta(query);
        }
    }
}
