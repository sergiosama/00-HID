using System;

namespace Entidades
{
	public class enTTipoDocumento
	{
		#region Fields

		private int idTipoDocumento;
		private string tipoDocumento;

		#endregion

		#region Constructors

		/// <summary>
		/// Initializes a new instance of the enTTipoDocumento class.
		/// </summary>
		public enTTipoDocumento()
		{
		}

		/// <summary>
		/// Initializes a new instance of the enTTipoDocumento class.
		/// </summary>
		public enTTipoDocumento(string tipoDocumento)
		{
			this.tipoDocumento = tipoDocumento;
		}

		/// <summary>
		/// Initializes a new instance of the enTTipoDocumento class.
		/// </summary>
		public enTTipoDocumento(int idTipoDocumento, string tipoDocumento)
		{
			this.idTipoDocumento = idTipoDocumento;
			this.tipoDocumento = tipoDocumento;
		}

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the IdTipoDocumento value.
		/// </summary>
		public virtual int IdTipoDocumento
		{
			get { return idTipoDocumento; }
			set { idTipoDocumento = value; }
		}

		/// <summary>
		/// Gets or sets the TipoDocumento value.
		/// </summary>
		public virtual string TipoDocumento
		{
			get { return tipoDocumento; }
			set { tipoDocumento = value; }
		}

		#endregion
	}
}
