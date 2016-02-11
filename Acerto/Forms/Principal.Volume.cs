using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acerto
{
    partial class Principal
    {
        private void btVolume_Click(object sender, EventArgs e)
        {

            volFilial();
            volMatriz();
          //  ConsultaNumLinhas.Text = gridVolumeMatriz.RowCount + " mercadorias encontradas no volume";
        }

        private void volFilial()
        {
            query = "SELECT mov_ser as serie from movimento where mov_doc = '" + textVolumes.Text+"'";

            if (intFilial.Value != 0)
            {
                query += " and mov_sed ='" + intFilial.Value+"'";
            }
            gridVolumeFilial.DataSource = conecta.Consulta(query);
        }

        private void volMatriz()
        {
            gridVolumeMatriz.DataSource = conecta.Consulta("SELECT  trf_ser as serie from transferido where trf_vol  = '" + textVolumes.Text + "'  and trf_dtc is null order by trf_ser");
        }


    }
}
