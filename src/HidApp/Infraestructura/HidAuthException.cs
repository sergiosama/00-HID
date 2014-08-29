using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Infraestructura
{
  /// <summary>
  /// Excepción lanzada cuando existe un ingreso erroneo al sistema
  /// </summary>
  /// <remarks>
  /// Posiblemente haya que registrar tambien el equipo desde el cual se intento ingresar
  /// </remarks>
  public class HidAuthException : ApplicationException, IAuditable
  {
    public HidAuthException(string mensaje) : base(mensaje)
    {
      //  auditar acceso erroneo
    }

    public IList<AuditInfo> Auditoria { get; set; }
  }
}
