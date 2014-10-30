using System;


namespace Entidades
{
	public class enTOrden
	{
       

        public int IdOrder { get; set; }
        public Nullable<int> IdArticulo { get; set; }
        public Nullable<int> IdPaciente { get; set; }
        public Nullable<int> IdRecurso { get; set; }
        
        public Nullable<DateTime> FechaOrden { get; set; }

        public virtual enTArticulo TArticulo { get; set; }
        public virtual enTDetalleOrden TDetalleOrden { get; set; }
        public virtual enTPaciente TPaciente { get; set; }
        public virtual enTRecurso TRecurso { get; set; }
	}
}
