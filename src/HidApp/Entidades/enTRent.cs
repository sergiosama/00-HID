using System;

namespace Entidades
{
  /// <summary>
  /// Representa una transaccion de alquiler particular
  /// Un Paciente alquila o renta un Articulo, a partir de una Fecha, durante un periodo de tiempo
  /// Cuidado!!! El Monto representa el precio pactado para el periodo inicial? O es el precio que se carga en cada vencimiento?? 
  /// </summary>
	public class enTRent
	{
        public int IdRent { get; set; }
        public Nullable<int> IdArticulo { get; set; }
        public Nullable<int> IdPacientes { get; set; }
        public Nullable<int> IdRecursos { get; set; }
        public DateTime? FechaSalida { get; set; }
        public DateTime? Desde { get; set; }
        public DateTime? Hasta { get; set; }
        public DateTime? FechaEntrada { get; set; }
        public Nullable<int> DiferenciaDias { get; set; }
        public Nullable<decimal> Monto { get; set; }
        public Nullable<int> IdObraSocial { get; set; }

        public virtual enTArticulo TArticulos { get; set; }
	}
}
