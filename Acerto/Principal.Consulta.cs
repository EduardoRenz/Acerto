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
         gridConsulta.DataSource =   conecta.Consulta("select * from produto where serie LIKE '%"+ txtConsultaSerie.Text+ "%' and material LIKE'%" + txtConsultaMaterial.Text + "%'");
        }
    }
}
