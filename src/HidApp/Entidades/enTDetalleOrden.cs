using System;
using System.Collections.Generic;

namespace Entidades
{
	public class enTDetalleOrden
	{

      
        //[ForeignKey("enTOrden")]
        public int IdDetalleOrden { get; set; }
        public int IdArticulo { get; set; }
        public Nullable<decimal> Precio { get; set; }
        public Nullable<double> Cantidad { get; set; }
        public Nullable<bool> Discontinuo { get; set; }

        public virtual enTArticulo TArticulo { get; set; }

      
        public virtual enTOrden TOrden { get; set; }
	}
}
