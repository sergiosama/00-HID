using System;

namespace Entidades
{
	public class enTCtaCteRecurso
	{
        public int IdCtaCteRecursos { get; set; }
        public Nullable<int> IdRecurso { get; set; }
        public Nullable<int> IdPaciente { get; set; }
        public DateTime?  Fecha { get; set; }
        public Nullable<decimal> Debe { get; set; }
        public Nullable<decimal> Haber { get; set; }
        public Nullable<decimal> saldo { get; set; }

        public virtual enTCtaCteRecurso TCtaCteRecursos { get; set; }
       
        public virtual enTPaciente TPaciente { get; set; }
        public virtual enTRecurso TRecurso { get; set; }
	}
}
