using System;

namespace Entidades
{
	public class enTPaciente
	{
		#region Fields

		private int idPacientes;
		private int idTipoDocumento;
		private int idObraSocial;
		private int idPlanObraSocial;
		private int idCalle;
		private int nroDni;
		private string apellido;
		private string nombres;
		private DateTime fechaNacimiento;
		private int nroDomicilio;
		private string nroObraSocial;
		private string telefono;
		private string celular;
		private string email;
		private string comentarios;

		#endregion

		#region Constructors

		/// <summary>
		/// Initializes a new instance of the enTPaciente class.
		/// </summary>
		public enTPaciente()
		{
		}

		/// <summary>
		/// Initializes a new instance of the enTPaciente class.
		/// </summary>
		public enTPaciente(int idTipoDocumento, int idObraSocial, int idPlanObraSocial, int idCalle, int nroDni, string apellido, string nombres, DateTime fechaNacimiento, int nroDomicilio, string nroObraSocial, string telefono, string celular, string email, string comentarios)
		{
			this.idTipoDocumento = idTipoDocumento;
			this.idObraSocial = idObraSocial;
			this.idPlanObraSocial = idPlanObraSocial;
			this.idCalle = idCalle;
			this.nroDni = nroDni;
			this.apellido = apellido;
			this.nombres = nombres;
			this.fechaNacimiento = fechaNacimiento;
			this.nroDomicilio = nroDomicilio;
			this.nroObraSocial = nroObraSocial;
			this.telefono = telefono;
			this.celular = celular;
			this.email = email;
			this.comentarios = comentarios;
		}

		/// <summary>
		/// Initializes a new instance of the enTPaciente class.
		/// </summary>
		public enTPaciente(int idPacientes, int idTipoDocumento, int idObraSocial, int idPlanObraSocial, int idCalle, int nroDni, string apellido, string nombres, DateTime fechaNacimiento, int nroDomicilio, string nroObraSocial, string telefono, string celular, string email, string comentarios)
		{
			this.idPacientes = idPacientes;
			this.idTipoDocumento = idTipoDocumento;
			this.idObraSocial = idObraSocial;
			this.idPlanObraSocial = idPlanObraSocial;
			this.idCalle = idCalle;
			this.nroDni = nroDni;
			this.apellido = apellido;
			this.nombres = nombres;
			this.fechaNacimiento = fechaNacimiento;
			this.nroDomicilio = nroDomicilio;
			this.nroObraSocial = nroObraSocial;
			this.telefono = telefono;
			this.celular = celular;
			this.email = email;
			this.comentarios = comentarios;
		}

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the IdPacientes value.
		/// </summary>
		public virtual int IdPacientes
		{
			get { return idPacientes; }
			set { idPacientes = value; }
		}

		/// <summary>
		/// Gets or sets the IdTipoDocumento value.
		/// </summary>
		public virtual int IdTipoDocumento
		{
			get { return idTipoDocumento; }
			set { idTipoDocumento = value; }
		}

		/// <summary>
		/// Gets or sets the IdObraSocial value.
		/// </summary>
		public virtual int IdObraSocial
		{
			get { return idObraSocial; }
			set { idObraSocial = value; }
		}

		/// <summary>
		/// Gets or sets the IdPlanObraSocial value.
		/// </summary>
		public virtual int IdPlanObraSocial
		{
			get { return idPlanObraSocial; }
			set { idPlanObraSocial = value; }
		}

		/// <summary>
		/// Gets or sets the IdCalle value.
		/// </summary>
		public virtual int IdCalle
		{
			get { return idCalle; }
			set { idCalle = value; }
		}

		/// <summary>
		/// Gets or sets the NroDni value.
		/// </summary>
		public virtual int NroDni
		{
			get { return nroDni; }
			set { nroDni = value; }
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
		/// Gets or sets the Nombres value.
		/// </summary>
		public virtual string Nombres
		{
			get { return nombres; }
			set { nombres = value; }
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
		/// Gets or sets the NroDomicilio value.
		/// </summary>
		public virtual int NroDomicilio
		{
			get { return nroDomicilio; }
			set { nroDomicilio = value; }
		}

		/// <summary>
		/// Gets or sets the NroObraSocial value.
		/// </summary>
		public virtual string NroObraSocial
		{
			get { return nroObraSocial; }
			set { nroObraSocial = value; }
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
		/// Gets or sets the Email value.
		/// </summary>
		public virtual string Email
		{
			get { return email; }
			set { email = value; }
		}

		/// <summary>
		/// Gets or sets the Comentarios value.
		/// </summary>
		public virtual string Comentarios
		{
			get { return comentarios; }
			set { comentarios = value; }
		}

		#endregion
	}
}
