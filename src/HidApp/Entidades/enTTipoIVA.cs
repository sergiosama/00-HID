using System;
using System.Collections.Generic;

namespace Entidades
{
  /// <summary>
  /// Representa la condicion de una persona o empresa respecto a la AFIP
  /// Algunos valores posibles
  /// - Responsable Inscripto
  /// - Excento
  /// - Monotributo B
  /// Estas condiciones no tienen que ver con el tipo de factura que debe emitirse (depende de quien la emite tambien)
  /// </summary>
	public class enTTipoIVA
	{
    public enTTipoIVA()
    {
      this.TObraSocial = new HashSet<enTObraSocial>();
    }
    
    public int IdTipoIVA { get; set; }
    public string DescripcionIVA { get; set; }
    
    public virtual ICollection<enTObraSocial> TObraSocial { get; set; }

    //  saque el hashset de recursos porque la condicion de IVA no deberia ser navegable hacia el recurso (fijate que la DB no lo tiene)
	}
}
