using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acerto
{
    class Corretor
    {
        public Corretor()
        {


        }
        public void Appender(string text, Color cor, RichTextBox campo)
        {
            campo.SelectionStart = campo.TextLength;
            campo.SelectionLength = 0;
            campo.SelectionColor = cor;
            campo.AppendText(text);
            campo.SelectionColor = campo.ForeColor;
        } // Adiciona texto ao richtextbox
        public bool verificador(string busca, string dado)
        {
            if(busca == dado)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Analise(DataTable tabela, int coluna,string tipo_correcao, RichTextBox log)
        {
            if (verificador("1", tabela.Rows[coluna]["saldo"].ToString()) && tipo_correcao == "Transferências") // Trocar para os valores corretos no oracle
            {

                Appender(tabela.Rows[coluna]["Serie"].ToString() + " \n",Color.Black,log);
            }
            if (verificador("0", tabela.Rows[coluna]["saldo"].ToString()) && tipo_correcao == "Vendas") // Trocar para os valores corretos no oracle
            {

                Appender(tabela.Rows[coluna]["Serie"].ToString() + "  \n", Color.Black, log);
            }
            // verifica se pode corigir venda ou transferencia
            // corrige
        }

        public void Corrigir_Transferencia(DataTable dados)
        {

        }


      
    }
}
