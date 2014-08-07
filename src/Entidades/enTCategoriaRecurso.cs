using System;

namespace Entidades
{
	public class enTCategoriaRecurso
	{
		#region Fields

		private int idCategoria;
		private string detalle;

		#endregion

		#region Constructors

		/// <summary>
		/// Initializes a new instance of the enTCategoriaRecurso class.
		/// </summary>
		public enTCategoriaRecurso()
		{
		}

		/// <summary>
		/// Initializes a new instance of the enTCategoriaRecurso class.
		/// </summary>
		public enTCategoriaRecurso(string detalle)
		{
			this.detalle = detalle;
		}

		/// <summary>
		/// Initializes a new instance of the enTCategoriaRecurso class.
		/// </summary>
		public enTCategoriaRecurso(int idCategoria, string detalle)
		{
			this.idCategoria = idCategoria;
			this.detalle = detalle;
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
		/// Gets or sets the Detalle value.
		/// </summary>
		public virtual string Detalle
		{
			get { return detalle; }
			set { detalle = value; }
		}

		#endregion
	}
}
