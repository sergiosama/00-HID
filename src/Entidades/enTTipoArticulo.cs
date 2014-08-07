using System;

namespace Entidades
{
	public class enTTipoArticulo
	{
		#region Fields

		private int idTipoArticulo;
		private string detalleTipoArticulo;

		#endregion

		#region Constructors

		/// <summary>
		/// Initializes a new instance of the enTTipoArticulo class.
		/// </summary>
		public enTTipoArticulo()
		{
		}

		/// <summary>
		/// Initializes a new instance of the enTTipoArticulo class.
		/// </summary>
		public enTTipoArticulo(string detalleTipoArticulo)
		{
			this.detalleTipoArticulo = detalleTipoArticulo;
		}

		/// <summary>
		/// Initializes a new instance of the enTTipoArticulo class.
		/// </summary>
		public enTTipoArticulo(int idTipoArticulo, string detalleTipoArticulo)
		{
			this.idTipoArticulo = idTipoArticulo;
			this.detalleTipoArticulo = detalleTipoArticulo;
		}

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the IdTipoArticulo value.
		/// </summary>
		public virtual int IdTipoArticulo
		{
			get { return idTipoArticulo; }
			set { idTipoArticulo = value; }
		}

		/// <summary>
		/// Gets or sets the DetalleTipoArticulo value.
		/// </summary>
		public virtual string DetalleTipoArticulo
		{
			get { return detalleTipoArticulo; }
			set { detalleTipoArticulo = value; }
		}

		#endregion
	}
}
