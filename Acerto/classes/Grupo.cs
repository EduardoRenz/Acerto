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
       public string abreviatura { get; set;}
        public string descricao { get; set; }
        public Grupo(int codigo, string abreviatura)
        {
            this.codigo = codigo;
            this.abreviatura = abreviatura;
            GeraDesc(abreviatura);
        }

        private void GeraDesc(string abreviatura)
        {
            switch (abreviatura)
            {
                case "MH":
                    descricao = "Masculino Homem";                    
                    break;
                case "MJ":
                    descricao = "Masculino Jovem";
                    break;
                case "MEP":
                    descricao = "Masculino Esporte/Praia";
                    break;
                case "MI":
                    descricao = "Masculino Intima";
                    break;
                case "FM":
                    descricao = "Feminino Mulher";
                    break;
                case "FJ":
                    descricao = "Feminino Jovem";
                    break;
                case "FEP":
                    descricao = "Feminino Esporte/Praia";
                    break;
                case "FI":
                    descricao = "Feminino Intima";
                    break;
                case "IJM":
                    descricao = "Infanto Juvenil Masculino";
                    break;
                case "IJF":
                    descricao = "Infanto Juvenil Feminino";
                    break;
                case "IBP":
                    descricao = "Infanto Bebê Primeiros Passos";
                    break;
                case "IJI":
                    descricao = "Infanto Juvenil Intima";
                    break;
                case "CM":
                    descricao = "Calçados Masculinos";
                    break;
                case "CF":
                    descricao = "Calcados Femininos";
                    break;
                case "CIJ":
                    descricao = "Calçados Infanto Juvenil";
                    break;
                case "CA":
                    descricao = "Complementos Acessórios";
                    break;
                case "C":
                    descricao = "Cama";
                    break;
                case "M":
                    descricao = "Mesa";
                    break;
                case "B":
                    descricao = "Banho";
                    break;
                default:
                    descricao = abreviatura;
                break;
            }
        }

        public override string ToString()
        {
            return  descricao;
        }

    }
}
