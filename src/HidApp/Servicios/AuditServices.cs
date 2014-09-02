using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades;
using Infraestructura;
using Data;

namespace Servicios
{
  /// <summary>
  /// Ninguno de los métodos de AuditServices debería lanzar excepciones
  /// </summary>
  public class AuditServices
  {
    /// <summary>
    /// Intenta guardar la información de auditoria pasada en la base de datos
    /// De no ser posible, guarda en medio local para luego recuperarlo
    /// </summary>
    /// <param name="ai"></param>
    /// <remarks>No lanza excepciones!!</remarks>
    public void SaveAuditInfo(AuditInfo ai)
    {
      //  Siempre dentro de un try, si hay problemas lo tengo que guardar localmente y luego volcarlo
      try
      {
        HIDContext ctx = DB.Context;

        ctx.Auditoria.Add(ai);
        ctx.SaveChanges();
      }
      finally
      {
        //  guardar datos en repositorio local...
      }
    }
  }
}
