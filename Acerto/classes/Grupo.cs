using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consulta.classes
{
    class Grupo
    {
       public int codigo { get; set;}
       public string descricao { get; set;}
        public Grupo(int codigo, string descricao)
        {
            this.codigo = codigo;
            this.descricao = descricao;
        }

        public override string ToString()
        {
            return  descricao;
        }

    }
}
