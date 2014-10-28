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
            this.TRecurso = new HashSet<enTRecurso>();
        }
    
        public int IdTipoIVA { get; set; }
        public string DescripcionIVA { get; set; }
    
        public virtual ICollection<enTObraSocial> TObraSocial { get; set; }
        public virtual ICollection<enTRecurso> TRecurso { get; set; }
	}
}
