using System;

namespace Entidades
{
	public class enTCategoria
	{
		#region Fields

		private int idCategoria;
		private string detalleCategoria;

		#endregion

		#region Constructors

		/// <summary>
		/// Initializes a new instance of the enTCategoria class.
		/// </summary>
		public enTCategoria()
		{
		}

		/// <summary>
		/// Initializes a new instance of the enTCategoria class.
		/// </summary>
		public enTCategoria(string detalleCategoria)
		{
			this.detalleCategoria = detalleCategoria;
		}

		/// <summary>
		/// Initializes a new instance of the enTCategoria class.
		/// </summary>
		public enTCategoria(int idCategoria, string detalleCategoria)
		{
			this.idCategoria = idCategoria;
			this.detalleCategoria = detalleCategoria;
		}

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the IdCategoria value.
		/// </summary>
		public virtual int IdCategoria
		{
			get { return idCategoria; }
			set { idCategoria = value; }
		}

		/// <summary>
		/// Gets or sets the DetalleCategoria value.
		/// </summary>
		public virtual string DetalleCategoria
		{
			get { return detalleCategoria; }
			set { detalleCategoria = value; }
		}

		#endregion
	}
}
