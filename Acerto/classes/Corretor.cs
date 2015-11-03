using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acerto
{
    class Corretor
    {
        public Corretor(DataTable dados,string tipo)
        {

            switch (tipo)
            {
                case "Transferências":
                    Console.WriteLine("Corrigindo Transferências");
                    break;
                case "Vendas":
                    Console.WriteLine("Corrigindo Vendas");
                    break;
                default:
                    Console.WriteLine("Nenhuma opção valida");
                    break;
            }

        }
        public void Corrigir_Transferencia(DataTable dados)
        {

        }
    }
}
