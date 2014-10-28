using System;

namespace Entidades
{
	public class enTDetalleOrden
	{
        public int IdOrder { get; set; }
        public int IdArticulo { get; set; }
        public Nullable<double> Precio { get; set; }
        public Nullable<double> Cantidad { get; set; }
        public Nullable<bool> Discontinuo { get; set; }

        public virtual enTArticulo TArticulo { get; set; }
        public virtual enTOrden TOrden { get; set; }
	}
}
