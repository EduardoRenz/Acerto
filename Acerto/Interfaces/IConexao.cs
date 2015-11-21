using System.Collections.Generic;
using System.Data;

namespace Acerto
{
    interface IConexao
    {
       DataTable Consulta(string query);
       bool Conectar();
       void Close();
    }
}
