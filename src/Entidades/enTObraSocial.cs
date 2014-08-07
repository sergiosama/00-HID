using System;

namespace Entidades
{
	public class enTObraSocial
	{
		#region Fields

		private int idObraSocial;
		private string mnemonico;
		private string obraSocial;

		#endregion

		#region Constructors

		/// <summary>
		/// Initializes a new instance of the enTObraSocial class.
		/// </summary>
		public enTObraSocial()
		{
		}

		/// <summary>
		/// Initializes a new instance of the enTObraSocial class.
		/// </summary>
		public enTObraSocial(string mnemonico, string obraSocial)
		{
			this.mnemonico = mnemonico;
			this.obraSocial = obraSocial;
		}

		/// <summary>
		/// Initializes a new instance of the enTObraSocial class.
		/// </summary>
		public enTObraSocial(int idObraSocial, string mnemonico, string obraSocial)
		{
			this.idObraSocial = idObraSocial;
			this.mnemonico = mnemonico;
			this.obraSocial = obraSocial;
		}

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the IdObraSocial value.
		/// </summary>
		public virtual int IdObraSocial
		{
			get { return idObraSocial; }
			set { idObraSocial = value; }
		}

		/// <summary>
		/// Gets or sets the Mnemonico value.
		/// </summary>
		public virtual string Mnemonico
		{
			get { return mnemonico; }
			set { mnemonico = value; }
		}

		/// <summary>
		/// Gets or sets the ObraSocial value.
		/// </summary>
		public virtual string ObraSocial
		{
			get { return obraSocial; }
			set { obraSocial = value; }
		}

		#endregion
	}
}
