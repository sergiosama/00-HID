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
		#region Fields

		private int _idRent;
//		private int _idArticulo;
//		private int _idPacientes;
		private int _idRecursos;
		private DateTime _fechaSalida;
		private DateTime _desde;
		private DateTime _hasta;
		private DateTime _fechaEntrada;
		private int _diferenciaDias;
		private decimal _monto;
		private int _idObraSocial;

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
		public enTRent(enTArticulo articulo, enTPaciente paciente, int idRecursos, DateTime fechaSalida, DateTime desde, 
      DateTime hasta, DateTime fechaEntrada, int diferenciaDias, decimal monto, int idObraSocial)
		{
//			this._idArticulo = idArticulo;
//			this._idPacientes = idPacientes;
		  this.Articulo = articulo;
		  this.Paciente = paciente;

			this._idRecursos = idRecursos;
			this._fechaSalida = fechaSalida;
			this._desde = desde;
			this._hasta = hasta;
			this._fechaEntrada = fechaEntrada;
			this._diferenciaDias = diferenciaDias;
			this._monto = monto;
			this._idObraSocial = idObraSocial;
		}

		/// <summary>
		/// Dificil que se instancie un objeto con idRent...
		/// </summary>
		public enTRent(int idRent, enTArticulo articulo, enTPaciente paciente, int idRecursos, DateTime fechaSalida, DateTime desde, 
      DateTime hasta, DateTime fechaEntrada, int diferenciaDias, decimal monto, int idObraSocial)
		{
			this._idRent = idRent;
//			this._idArticulo = idArticulo;
//			this._idPacientes = idPacientes;
      this.Articulo = articulo;
      this.Paciente = paciente;
      
      this._idRecursos = idRecursos;
			this._fechaSalida = fechaSalida;
			this._desde = desde;
			this._hasta = hasta;
			this._fechaEntrada = fechaEntrada;
			this._diferenciaDias = diferenciaDias;
			this._monto = monto;
			this._idObraSocial = idObraSocial;
		}

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the IdRent value.
		/// </summary>
		public virtual int IdRent
		{
			get { return _idRent; }
			set { _idRent = value; }
		}

//		public virtual int IdArticulo
//		{
//			get { return _idArticulo; }
//			set { _idArticulo = value; }
//		}

		/// <summary>
		/// Articulo que se está alquilando en esta transacción
		/// </summary>
    public virtual enTArticulo Articulo { get; set; }

//		public virtual int IdPacientes
//		{
//			get { return _idPacientes; }
//			set { _idPacientes = value; }
//		}

    /// <summary>
    /// El Paciente al cual se le efectua el alquiler
    /// </summary>
    public virtual enTPaciente Paciente { get; set; }

		/// <summary>
		/// Que seria esto???
		/// </summary>
		public virtual int IdRecursos
		{
			get { return _idRecursos; }
			set { _idRecursos = value; }
		}

		/// <summary>
		/// Gets or sets the FechaSalida value.
		/// </summary>
		public virtual DateTime FechaSalida
		{
			get { return _fechaSalida; }
			set { _fechaSalida = value; }
		}

		/// <summary>
		/// Gets or sets the Desde value.
		/// </summary>
		public virtual DateTime Desde
		{
			get { return _desde; }
			set { _desde = value; }
		}

		/// <summary>
		/// Gets or sets the Hasta value.
		/// </summary>
		public virtual DateTime Hasta
		{
			get { return _hasta; }
			set { _hasta = value; }
		}

		/// <summary>
		/// Gets or sets the FechaEntrada value.
		/// </summary>
		public virtual DateTime FechaEntrada
		{
			get { return _fechaEntrada; }
			set { _fechaEntrada = value; }
		}

		/// <summary>
		/// Gets or sets the DiferenciaDias value.
		/// </summary>
		public virtual int DiferenciaDias
		{
			get { return _diferenciaDias; }
			set { _diferenciaDias = value; }
		}

		/// <summary>
		/// Gets or sets the Monto value.
		/// </summary>
		public virtual decimal Monto
		{
			get { return _monto; }
			set { _monto = value; }
		}

		/// <summary>
		/// Cambiar
		/// La Obra Social que autoriza el alquiler o bien null si el costo corre por cuenta del Paciente (PARTICULAR)
		/// </summary>
		public virtual int IdObraSocial
		{
			get { return _idObraSocial; }
			set { _idObraSocial = value; }
		}

		#endregion
	}
}
