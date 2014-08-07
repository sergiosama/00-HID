using System;

namespace Entidades
{
	public class enTRent
	{
		#region Fields

		private int idRent;
		private int idArticulo;
		private int idPacientes;
		private int idRecursos;
		private DateTime fechaSalida;
		private DateTime desde;
		private DateTime hasta;
		private DateTime fechaEntrada;
		private int diferenciaDias;
		private decimal monto;
		private int idObraSocial;

		#endregion

		#region Constructors

		/// <summary>
		/// Initializes a new instance of the enTRent class.
		/// </summary>
		public enTRent()
		{
		}

		/// <summary>
		/// Initializes a new instance of the enTRent class.
		/// </summary>
		public enTRent(int idArticulo, int idPacientes, int idRecursos, DateTime fechaSalida, DateTime desde, DateTime hasta, DateTime fechaEntrada, int diferenciaDias, decimal monto, int idObraSocial)
		{
			this.idArticulo = idArticulo;
			this.idPacientes = idPacientes;
			this.idRecursos = idRecursos;
			this.fechaSalida = fechaSalida;
			this.desde = desde;
			this.hasta = hasta;
			this.fechaEntrada = fechaEntrada;
			this.diferenciaDias = diferenciaDias;
			this.monto = monto;
			this.idObraSocial = idObraSocial;
		}

		/// <summary>
		/// Initializes a new instance of the enTRent class.
		/// </summary>
		public enTRent(int idRent, int idArticulo, int idPacientes, int idRecursos, DateTime fechaSalida, DateTime desde, DateTime hasta, DateTime fechaEntrada, int diferenciaDias, decimal monto, int idObraSocial)
		{
			this.idRent = idRent;
			this.idArticulo = idArticulo;
			this.idPacientes = idPacientes;
			this.idRecursos = idRecursos;
			this.fechaSalida = fechaSalida;
			this.desde = desde;
			this.hasta = hasta;
			this.fechaEntrada = fechaEntrada;
			this.diferenciaDias = diferenciaDias;
			this.monto = monto;
			this.idObraSocial = idObraSocial;
		}

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the IdRent value.
		/// </summary>
		public virtual int IdRent
		{
			get { return idRent; }
			set { idRent = value; }
		}

		/// <summary>
		/// Gets or sets the IdArticulo value.
		/// </summary>
		public virtual int IdArticulo
		{
			get { return idArticulo; }
			set { idArticulo = value; }
		}

		/// <summary>
		/// Gets or sets the IdPacientes value.
		/// </summary>
		public virtual int IdPacientes
		{
			get { return idPacientes; }
			set { idPacientes = value; }
		}

		/// <summary>
		/// Gets or sets the IdRecursos value.
		/// </summary>
		public virtual int IdRecursos
		{
			get { return idRecursos; }
			set { idRecursos = value; }
		}

		/// <summary>
		/// Gets or sets the FechaSalida value.
		/// </summary>
		public virtual DateTime FechaSalida
		{
			get { return fechaSalida; }
			set { fechaSalida = value; }
		}

		/// <summary>
		/// Gets or sets the Desde value.
		/// </summary>
		public virtual DateTime Desde
		{
			get { return desde; }
			set { desde = value; }
		}

		/// <summary>
		/// Gets or sets the Hasta value.
		/// </summary>
		public virtual DateTime Hasta
		{
			get { return hasta; }
			set { hasta = value; }
		}

		/// <summary>
		/// Gets or sets the FechaEntrada value.
		/// </summary>
		public virtual DateTime FechaEntrada
		{
			get { return fechaEntrada; }
			set { fechaEntrada = value; }
		}

		/// <summary>
		/// Gets or sets the DiferenciaDias value.
		/// </summary>
		public virtual int DiferenciaDias
		{
			get { return diferenciaDias; }
			set { diferenciaDias = value; }
		}

		/// <summary>
		/// Gets or sets the Monto value.
		/// </summary>
		public virtual decimal Monto
		{
			get { return monto; }
			set { monto = value; }
		}

		/// <summary>
		/// Gets or sets the IdObraSocial value.
		/// </summary>
		public virtual int IdObraSocial
		{
			get { return idObraSocial; }
			set { idObraSocial = value; }
		}

		#endregion
	}
}
