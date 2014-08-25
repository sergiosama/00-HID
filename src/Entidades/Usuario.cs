using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
  /// <summary>
  /// Representa a cualquier entidad que puede ingresar al sistema mediante un Login (userid) y una contraseña
  /// </summary>
  public class Usuario
  {
    public string Login { get; set; }

    /// <summary>
    /// Temporal: por ahora el Usuario se relaciona con un Recurso 
    /// Futuro: relacionar con Persona, y derivar Recurso de Persona. Persona tambien puede ser un Paciente
    /// </summary>
    public virtual enTRecurso Recurso { get; set; }

    public DateTime? PasswordExpireTime { get; set; }
    
    public DateTime? LastLogin { get; set; }

    public bool MustChangePassword { get; set; }

    public bool EnforceExpiration { get; set; }

    public bool EnforceStrong { get; set; }
  }
}
