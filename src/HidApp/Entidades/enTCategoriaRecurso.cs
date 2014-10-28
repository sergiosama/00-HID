using System;
using System.Collections.Generic;


namespace Entidades
{
  /// <summary>
  /// Categoria o Tipo del Recurso, es decir que funcion cumple dentro de la Empresa
  /// Cuidado!! esto puede transformarse o confundirse con los skills...para mi hay dos categorias principales: Administrativos y Profesionales
  /// </summary>
  public class enTCategoriaRecurso
	{



      public enTCategoriaRecurso()
        {
            this.TCtaCtePaciente = new HashSet<enTCtaCtePaciente>();
            this.TRecurso = new HashSet<enTRecurso>();
        }
    
        public int IdCategoria { get; set; }
        public string Detalle { get; set; }
    
        public virtual ICollection<enTCtaCtePaciente> TCtaCtePaciente { get; set; }
        public virtual ICollection<enTRecurso> TRecurso { get; set; }

    public override string ToString()
    {
      return Detalle;
    }



	}
}
