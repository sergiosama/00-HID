using System;

namespace Entidades
{
  /// <summary>
  /// Clase que representa a un integrante de la empresa, cualquiera sea su actividad
  /// </summary>
	public class enTRecurso
	{
		#region Fields

		private int _idRecurso;
		private string _apellido;
		private string _nombre;
		private string _matricula;
		private DateTime? _fechaTituloMedico;
		private DateTime? _fechaNacimiento;
		private string _direccion;
		private string _telefono;
		private string _celular;
		//  private int _idCategoria;
		private string _numCUIT;
		//  private int _idTipoIVA;
		private string _email;
		private string _nroSeguroMap;
		private string _sssalud;
		private byte[] _adjuntos;
		private byte[] _foto;
    //  La password no deberia formar parte de la entidad
		//  private byte[] _clave;
		private string _observaciones;

		#endregion

		#region Constructors

		/// <summary>
		/// Initializes a new instance of the enTRecurso class.
		/// </summary>
		public enTRecurso()
		{
		}

		/// <summary>
		/// Initializes a new instance of the enTRecurso class.
		/// </summary>
		public enTRecurso(string apellido, string nombre, string matricula, DateTime? fechaTituloMedico, DateTime? fechaNacimiento, 
      string direccion, string telefono, string celular, enTCategoriaRecurso categoria, string cUIT, enTTipoIVA tipoIVA, string email, 
      string nroSeguroMAP, string sssalud, byte[] adjuntos, byte[] foto, string observaciones)
		{
			this._apellido = apellido;
			this._nombre = nombre;
			this._matricula = matricula;
			this._fechaTituloMedico = fechaTituloMedico;
			this._fechaNacimiento = fechaNacimiento;
			this._direccion = direccion;
			this._telefono = telefono;
			this._celular = celular;
			//this._idCategoria = idCategoria;
		  this.Categoria = categoria;
			this._numCUIT = cUIT;
			//this._idTipoIVA = idTipoIVA;
		  this.SituacionAFIP = tipoIVA;
			this._email = email;
			this._nroSeguroMap = nroSeguroMAP;
			this._sssalud = sssalud;
			this._adjuntos = adjuntos;
			this._foto = foto;
			//  this._clave = clave;
			this._observaciones = observaciones;
		}

		/// <summary>
		/// Initializes a new instance of the enTRecurso class.
		/// </summary>
		public enTRecurso(int idRecursos, string apellido, string nombre, string matricula, DateTime? fechaTituloMedico, DateTime? fechaNacimiento, 
      string direccion, string telefono, string celular, enTCategoriaRecurso categoria, string cUIT, enTTipoIVA tipoIVA, string email, string nroSeguroMAP, 
      string sssalud, byte[] adjuntos, byte[] foto, string observaciones)
		{
			this._idRecurso = idRecursos;
			this._apellido = apellido;
			this._nombre = nombre;
			this._matricula = matricula;
			this._fechaTituloMedico = fechaTituloMedico;
			this._fechaNacimiento = fechaNacimiento;
			this._direccion = direccion;
			this._telefono = telefono;
			this._celular = celular;
			//this._idCategoria = idCategoria;
		  this.Categoria = categoria;
			this._numCUIT = cUIT;
			//this._idTipoIVA = idTipoIVA;
		  this.SituacionAFIP = tipoIVA;
			this._email = email;
			this._nroSeguroMap = nroSeguroMAP;
			this._sssalud = sssalud;
			this._adjuntos = adjuntos;
			this._foto = foto;
			//  this._clave = clave;
			this._observaciones = observaciones;
		}

		#endregion

		#region Properties

		/// <summary>
		/// ID del Recurso --> clave primaria usada por EF
		/// </summary>
		public virtual int IdRecurso
		{
			get { return _idRecurso; }
			set { _idRecurso = value; }
		}

		/// <summary>
		/// Gets or sets the Apellido value.
		/// </summary>
		public virtual string Apellido
		{
			get { return _apellido; }
			set { _apellido = value; }
		}

		/// <summary>
		/// Gets or sets the Nombre value.
		/// </summary>
		public virtual string Nombre
		{
			get { return _nombre; }
			set { _nombre = value; }
		}

		/// <summary>
		/// Gets or sets the Matricula value.
		/// </summary>
		public virtual string Matricula
		{
			get { return _matricula; }
			set { _matricula = value; }
		}

		/// <summary>
		/// Gets or sets the FechaTituloMedico value.
		/// </summary>
		public virtual DateTime? FechaTituloMedico
		{
			get { return _fechaTituloMedico; }
			set { _fechaTituloMedico = value; }
		}

		/// <summary>
		/// Gets or sets the FechaNacimiento value.
		/// </summary>
		public virtual DateTime? FechaNacimiento
		{
			get { return _fechaNacimiento; }
			set { _fechaNacimiento = value; }
		}

		/// <summary>
		/// Gets or sets the Direccion value.
		/// </summary>
		public virtual string Direccion
		{
			get { return _direccion; }
			set { _direccion = value; }
		}

		/// <summary>
		/// Gets or sets the Telefono value.
		/// </summary>
		public virtual string Telefono
		{
			get { return _telefono; }
			set { _telefono = value; }
		}

		/// <summary>
		/// Gets or sets the Celular value.
		/// </summary>
		public virtual string Celular
		{
			get { return _celular; }
			set { _celular = value; }
		}

/*
		/// <summary>
		/// Gets or sets the IdCategoria value.
		/// </summary>
		public virtual int IdCategoria
		{
			get { return _idCategoria; }
			set { _idCategoria = value; }
		}
*/
    /// <summary>
    /// Representa el Tipo del Recurso (Administrativo, Profesional...Kinesiologo...)
    /// </summary>
    
    public virtual enTCategoriaRecurso Categoria { get; set; }

		/// <summary>
		/// Gets or sets the CUIT value.
		/// </summary>
		public virtual string CUIT
		{
			get { return _numCUIT; }
			set { _numCUIT = value; }
		}

/*
		/// <summary>
		/// Gets or sets the IdTipoIVA value.
		/// </summary>
		public virtual int IdTipoIVA
		{
			get { return _idTipoIVA; }
			set { _idTipoIVA = value; }
		}
*/
    /// <summary>
    /// Como esta inscripto el Recurso en la AFIP
    /// </summary>
    
    public virtual enTTipoIVA SituacionAFIP { get; set; }

		/// <summary>
		/// Gets or sets the Email value.
		/// </summary>
		public virtual string Email
		{
			get { return _email; }
			set { _email = value; }
		}

		/// <summary>
		/// Gets or sets the NroSeguroMAP value.
		/// </summary>
		public virtual string NroSeguroMAP
		{
			get { return _nroSeguroMap; }
			set { _nroSeguroMap = value; }
		}

		/// <summary>
		/// Gets or sets the Sssalud value.
		/// </summary>
		public virtual string Sssalud
		{
			get { return _sssalud; }
			set { _sssalud = value; }
		}

		/// <summary>
		/// Gets or sets the Adjuntos value.
		/// </summary>
		public virtual byte[] Adjuntos
		{
			get { return _adjuntos; }
			set { _adjuntos = value; }
		}

		/// <summary>
		/// Gets or sets the Foto value.
		/// </summary>
		public virtual byte[] Foto
		{
			get { return _foto; }
			set { _foto = value; }
		}

/*
		/// <summary>
		/// Gets or sets the Clave value.
		/// </summary>
		public virtual byte[] Clave
		{
			get { return _clave; }
			set { _clave = value; }
		}
*/

		/// <summary>
		/// Gets or sets the Observaciones value.
		/// </summary>
		public virtual string Observaciones
		{
			get { return _observaciones; }
			set { _observaciones = value; }
		}

		#endregion
	}
}
