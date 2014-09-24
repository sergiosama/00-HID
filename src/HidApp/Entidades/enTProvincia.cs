using System;

namespace Entidades
{
	public class enTProvincia
	{
		#region Fields

		private string idcodprov;
		private string provincia;

		#endregion

		#region Constructors

		/// <summary>
		/// Initializes a new instance of the enTProvincia class.
		/// </summary>
		public enTProvincia()
		{
		}

		/// <summary>
		/// Initializes a new instance of the enTProvincia class.
		/// </summary>
		public enTProvincia(string idcodprov, string provincia)
		{
			this.idcodprov = idcodprov;
			this.provincia = provincia;
		}

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the Idcodprov value.
		/// </summary>
		public virtual string Idcodprov
		{
			get { return idcodprov; }
			set { idcodprov = value; }
		}

		/// <summary>
		/// Gets or sets the Provincia value.
		/// </summary>
		public virtual string Provincia
		{
			get { return provincia; }
			set { provincia = value; }
		}

		#endregion
	}
}
