
using System.Data;


namespace Acerto.Interfaces
{
    interface ICorretor
    {
        void Corrigir_Transferencia(DataTable dados); // Ira corrigir erros de transferencias encontrados
        void Corrigir_Venda(DataTable dados);  // Ira corrigir erros de vendas encontrados
    }
}
