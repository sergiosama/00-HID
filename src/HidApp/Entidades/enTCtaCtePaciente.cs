using System;

namespace Entidades
{
	public class enTCtaCtePaciente
	{


        public int NroCuenta { get; set; }
        public int IdPaciente { get; set; }
        public Nullable<int> IdCategoria { get; set; }
        public Nullable<int> Cantidad { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public Nullable<decimal> Debe { get; set; }
        public Nullable<decimal> Haber { get; set; }
        public Nullable<decimal> Saldo { get; set; }

        public virtual enTCategoriaRecurso TCategoriaRecurso { get; set; }
        public virtual enTPaciente TPacientes { get; set; }
	
	}
}
