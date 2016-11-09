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
        private Dictionary<string, string> setores = new Dictionary<string, string>();
        public Grupo(int codigo, string abreviatura)
        {
            this.codigo = codigo;
            this.abreviatura = abreviatura;
            descricao = abreviatura;

            setores.Add("FAC", "Feminino - Acessórios");
            setores.Add("FBA", "Feminino - Botas Cano Longo");
            setores.Add("FBC", "Feminino - Botas Cano Baixo");
            setores.Add("FBD", "Feminino - Bermudas");
            setores.Add("FBM", "Feminino - Blusas com Manga");
            setores.Add("FBS", "Feminino - Blusas Sociais");
            setores.Add("FBSM","Feminino - Blusas sem Manga");
            setores.Add("FCH", "Feminino - Chinelos");
            setores.Add("FCJ", "Feminino - Calças Jeans");
            setores.Add("FCL", "Feminino - Calças Outras");
            setores.Add("FCS", "Feminino - Casacos");
            setores.Add("FEP", "Feminino - Esportes");
            setores.Add("FIN", "Feminino - Intima");
            setores.Add("FJT", "Feminino - Jaqueta");
            setores.Add("FPR", "Feminino - Praia");
            setores.Add("FSD", "Feminino - Sandalias");
            setores.Add("FSP", "Feminino - Sapatos");
            setores.Add("FSS", "Feminino - Saias");
            setores.Add("FST", "Feminino - Sapatilhas");
            setores.Add("FSH", "Feminino - Shorts");
            setores.Add("FTC", "Feminino -Tricot");
            setores.Add("FTN", "Feminino - Tênis/Sapatênis");
            setores.Add("FVT", "Feminino - Vestidos");
            setores.Add("IBT", "Infanto/Juvenil - Botas");
            setores.Add("IFBL","Infanto/Juvenil - Blusas/Vestidos/Conjuntos");
            setores.Add("IFCL","Infanto/Juvenil - Calça/Meia Calça");
            setores.Add("IFCS", "Infanto/Juvenil - Casacos/Tricot");
            setores.Add("IFSH", "Infanto/Juvenil - Shorts/Saias");
            setores.Add("IMBD", "Infanto/Juvenil - Bermudas");
            setores.Add("IMCL", "Infanto/Juvenil - Calças");
            setores.Add("IMCS", "Infanto/Juvenil - Casacos/Conjuntos/Tricot");
            setores.Add("IMCT", "Infanto/Juvenil - Camisetas");
            setores.Add("ISD", "Infanto/Juvenil - Sandálias/Chinelos/Acessórios");
            setores.Add("IST", "Infanto/Juvenil - Sapatilhas");
            setores.Add("ITN", "Infanto/Juvenil - Tênis");
            setores.Add("MAB", "Masculino - Abotinado");
            setores.Add("MBD", "Masculino - Bermudas");
            setores.Add("MCH", "Masculino - Chinelos/Sandálias");
            setores.Add("MCL", "Masculino - Calças");
            setores.Add("MCM", "Masculino - Camisas");
            setores.Add("MCS", "Masculino - Casacos");
            setores.Add("MCT", "Masculino - Camisetas");
            setores.Add("MIN", "Masculino - Intima");
            setores.Add("MPO", "Masculino - Polo");
            setores.Add("MSP", "Masculino - Sapatos/Acessórios(Cintos)");
            setores.Add("MST", "Masculino - Sapatênis");
            setores.Add("MTC", "Masculino - Tricot");
            setores.Add("MTN", "Masculino - Tênis");
            setores.Add("MEP", "Masculino - Esporte");


            GeraDesc(abreviatura); // Muda as abrviaturas para mais amigavel




        }

        private void GeraDesc(string abreviatura)
        {

            foreach(string cod in setores.Keys)
            {
                if(abreviatura == cod)
                {
                    descricao = setores[cod];
                }
            }
        }

        public override string ToString()
        {
            return  descricao;
        }

    }
}
