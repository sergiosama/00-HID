using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura
{
  /// <summary>
  /// Excepción lanzada cuando el usuario intenta ingresar con una contraseña que expiró
  /// </summary>
  public class HidPasswordExpiredException : ApplicationException
  {
    public HidPasswordExpiredException(string mensaje) : base(mensaje) { }
  }
}
