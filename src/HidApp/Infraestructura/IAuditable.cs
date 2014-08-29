using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades;

namespace Infraestructura
{
  public interface IAuditable
  {
    IList<AuditInfo> Auditoria { get; set; }
  }
}
