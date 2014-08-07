using System;

namespace Entidades
{
	public class enTRecurso
	{
		#region Fields

		private int idRecursos;
		private string apellido;
		private string nombre;
		private string matricula;
		private DateTime fechaTituloMedico;
		private DateTime fechaNacimiento;
		private string direccion;
		private string telefono;
		private string celular;
		private int idCategoria;
		private string cUIT;
		private int idTipoIVA;
		private string email;
		private string nroSeguroMAP;
		private string sssalud;
		private byte[] adjuntos;
		private byte[] foto;
		private byte[] clave;
		private string observaciones;

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
		public enTRecurso(string apellido, string nombre, string matricula, DateTime fechaTituloMedico, DateTime fechaNacimiento, string direccion, string telefono, string celular, int idCategoria, string cUIT, int idTipoIVA, string email, string nroSeguroMAP, string sssalud, byte[] adjuntos, byte[] foto, byte[] clave, string observaciones)
		{
			this.apellido = apellido;
			this.nombre = nombre;
			this.matricula = matricula;
			this.fechaTituloMedico = fechaTituloMedico;
			this.fechaNacimiento = fechaNacimiento;
			this.direccion = direccion;
			this.telefono = telefono;
			this.celular = celular;
			this.idCategoria = idCategoria;
			this.cUIT = cUIT;
			this.idTipoIVA = idTipoIVA;
			this.email = email;
			this.nroSeguroMAP = nroSeguroMAP;
			this.sssalud = sssalud;
			this.adjuntos = adjuntos;
			this.foto = foto;
			this.clave = clave;
			this.observaciones = observaciones;
		}

		/// <summary>
		/// Initializes a new instance of the enTRecurso class.
		/// </summary>
		public enTRecurso(int idRecursos, string apellido, string nombre, string matricula, DateTime fechaTituloMedico, DateTime fechaNacimiento, string direccion, string telefono, string celular, int idCategoria, string cUIT, int idTipoIVA, string email, string nroSeguroMAP, string sssalud, byte[] adjuntos, byte[] foto, byte[] clave, string observaciones)
		{
			this.idRecursos = idRecursos;
			this.apellido = apellido;
			this.nombre = nombre;
			this.matricula = matricula;
			this.fechaTituloMedico = fechaTituloMedico;
			this.fechaNacimiento = fechaNacimiento;
			this.direccion = direccion;
			this.telefono = telefono;
			this.celular = celular;
			this.idCategoria = idCategoria;
			this.cUIT = cUIT;
			this.idTipoIVA = idTipoIVA;
			this.email = email;
			this.nroSeguroMAP = nroSeguroMAP;
			this.sssalud = sssalud;
			this.adjuntos = adjuntos;
			this.foto = foto;
			this.clave = clave;
			this.observaciones = observaciones;
		}

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the IdRecursos value.
		/// </summary>
		public virtual int IdRecursos
		{
			get { return idRecursos; }
			set { idRecursos = value; }
		}

		/// <summary>
		/// Gets or sets the Apellido value.
		/// </summary>
		public virtual string Apellido
		{
			get { return apellido; }
			set { apellido = value; }
		}

		/// <summary>
		/// Gets or sets the Nombre value.
		/// </summary>
		public virtual string Nombre
		{
			get { return nombre; }
			set { nombre = value; }
		}

		/// <summary>
		/// Gets or sets the Matricula value.
		/// </summary>
		public virtual string Matricula
		{
			get { return matricula; }
			set { matricula = value; }
		}

		/// <summary>
		/// Gets or sets the FechaTituloMedico value.
		/// </summary>
		public virtual DateTime FechaTituloMedico
		{
			get { return fechaTituloMedico; }
			set { fechaTituloMedico = value; }
		}

		/// <summary>
		/// Gets or sets the FechaNacimiento value.
		/// </summary>
		public virtual DateTime FechaNacimiento
		{
			get { return fechaNacimiento; }
			set { fechaNacimiento = value; }
		}

		/// <summary>
		/// Gets or sets the Direccion value.
		/// </summary>
		public virtual string Direccion
		{
			get { return direccion; }
			set { direccion = value; }
		}

		/// <summary>
		/// Gets or sets the Telefono value.
		/// </summary>
		public virtual string Telefono
		{
			get { return telefono; }
			set { telefono = value; }
		}

		/// <summary>
		/// Gets or sets the Celular value.
		/// </summary>
		public virtual string Celular
		{
			get { return celular; }
			set { celular = value; }
		}

		/// <summary>
		/// Gets or sets the IdCategoria value.
		/// </summary>
		public virtual int IdCategoria
		{
			get { return idCategoria; }
			set { idCategoria = value; }
		}

		/// <summary>
		/// Gets or sets the CUIT value.
		/// </summary>
		public virtual string CUIT
		{
			get { return cUIT; }
			set { cUIT = value; }
		}

		/// <summary>
		/// Gets or sets the IdTipoIVA value.
		/// </summary>
		public virtual int IdTipoIVA
		{
			get { return idTipoIVA; }
			set { idTipoIVA = value; }
		}

		/// <summary>
		/// Gets or sets the Email value.
		/// </summary>
		public virtual string Email
		{
			get { return email; }
			set { email = value; }
		}

		/// <summary>
		/// Gets or sets the NroSeguroMAP value.
		/// </summary>
		public virtual string NroSeguroMAP
		{
			get { return nroSeguroMAP; }
			set { nroSeguroMAP = value; }
		}

		/// <summary>
		/// Gets or sets the Sssalud value.
		/// </summary>
		public virtual string Sssalud
		{
			get { return sssalud; }
			set { sssalud = value; }
		}

		/// <summary>
		/// Gets or sets the Adjuntos value.
		/// </summary>
		public virtual byte[] Adjuntos
		{
			get { return adjuntos; }
			set { adjuntos = value; }
		}

		/// <summary>
		/// Gets or sets the Foto value.
		/// </summary>
		public virtual byte[] Foto
		{
			get { return foto; }
			set { foto = value; }
		}

		/// <summary>
		/// Gets or sets the Clave value.
		/// </summary>
		public virtual byte[] Clave
		{
			get { return clave; }
			set { clave = value; }
		}

		/// <summary>
		/// Gets or sets the Observaciones value.
		/// </summary>
		public virtual string Observaciones
		{
			get { return observaciones; }
			set { observaciones = value; }
		}

		#endregion
	}
}
