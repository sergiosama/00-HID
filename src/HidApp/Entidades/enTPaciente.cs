using System;
using System.Collections.Generic;

namespace Entidades
{
	public class enTPaciente
	{  
        public enTPaciente()
        {
            this.TCtaCtePaciente = new HashSet<enTCtaCtePaciente>();
            this.TCtaCteRecursos = new HashSet<enTCtaCteRecurso>();
            this.TOrden = new HashSet<enTOrden>();
        }
    
        public int IdPaciente { get; set; }
        public Nullable<int> IdTipoDocumento { get; set; }
        public Nullable<int> IdObraSocial { get; set; }
        public Nullable<int> IdPlanObraSocial { get; set; }
        public Nullable<int> IdCalle { get; set; }
        public string Calle { get; set; }
        public Nullable<int> NroDomicilio { get; set; }
        public Nullable<int> NroDni { get; set; }
        public string Apellido { get; set; }
        public string Nombres { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public string NroObraSocial { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string email { get; set; }
        public string Comentarios { get; set; }
        public Nullable<int> Idcodloc { get; set; }
    
        public virtual ICollection<enTCtaCtePaciente> TCtaCtePaciente { get; set; }
        public virtual ICollection<enTCtaCteRecurso> TCtaCteRecursos { get; set; }
        public virtual enTLocalidad TLocalidad { get; set; }
        public virtual enTObraSocial TObraSocial { get; set; }
        public virtual ICollection<enTOrden> TOrden { get; set; }
        public virtual enTPlanObraSocial TPlanObraSocial { get; set; }
	}
}
