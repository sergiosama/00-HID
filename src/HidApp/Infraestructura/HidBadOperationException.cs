using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura
{
  public class HidBadOperationException : ApplicationException
  {
    public HidBadOperationException(string mensaje)
      : base(mensaje)
    {
      
    }
  }
}
