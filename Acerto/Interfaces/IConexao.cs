using System.Collections.Generic;

namespace Acerto
{
    interface IConexao
    {
       List<string> Consulta(string query);
       bool Conectar(string sqlConexao);
       void Close();
    }
}
