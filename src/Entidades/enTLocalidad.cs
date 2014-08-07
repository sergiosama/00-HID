using System;

namespace Entidades
{
	public class enTLocalidad
	{
		#region Fields

		private int idcodloc;
		private string localidad;
		private string codpostal;
		private string idcodprov;

		#endregion

		#region Constructors

		/// <summary>
		/// Initializes a new instance of the enTLocalidad class.
		/// </summary>
		public enTLocalidad()
		{
		}

		/// <summary>
		/// Initializes a new instance of the enTLocalidad class.
		/// </summary>
		public enTLocalidad(int idcodloc, string localidad, string codpostal, string idcodprov)
		{
			this.idcodloc = idcodloc;
			this.localidad = localidad;
			this.codpostal = codpostal;
			this.idcodprov = idcodprov;
		}

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the Idcodloc value.
		/// </summary>
		public virtual int Idcodloc
		{
			get { return idcodloc; }
			set { idcodloc = value; }
		}

		/// <summary>
		/// Gets or sets the Localidad value.
		/// </summary>
		public virtual string Localidad
		{
			get { return localidad; }
			set { localidad = value; }
		}

		/// <summary>
		/// Gets or sets the Codpostal value.
		/// </summary>
		public virtual string Codpostal
		{
			get { return codpostal; }
			set { codpostal = value; }
		}

		/// <summary>
		/// Gets or sets the Idcodprov value.
		/// </summary>
		public virtual string Idcodprov
		{
			get { return idcodprov; }
			set { idcodprov = value; }
		}

		#endregion
	}
}
