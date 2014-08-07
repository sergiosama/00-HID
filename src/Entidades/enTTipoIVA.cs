using System;

namespace Entidades
{
	public class enTTipoIVA
	{
		#region Fields

		private int idTipoIVA;
		private string descripcionIVA;

		#endregion

		#region Constructors

		/// <summary>
		/// Initializes a new instance of the enTTipoIVA class.
		/// </summary>
		public enTTipoIVA()
		{
		}

		/// <summary>
		/// Initializes a new instance of the enTTipoIVA class.
		/// </summary>
		public enTTipoIVA(string descripcionIVA)
		{
			this.descripcionIVA = descripcionIVA;
		}

		/// <summary>
		/// Initializes a new instance of the enTTipoIVA class.
		/// </summary>
		public enTTipoIVA(int idTipoIVA, string descripcionIVA)
		{
			this.idTipoIVA = idTipoIVA;
			this.descripcionIVA = descripcionIVA;
		}

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the IdTipoIVA value.
		/// </summary>
		public virtual int IdTipoIVA
		{
			get { return idTipoIVA; }
			set { idTipoIVA = value; }
		}

		/// <summary>
		/// Gets or sets the DescripcionIVA value.
		/// </summary>
		public virtual string DescripcionIVA
		{
			get { return descripcionIVA; }
			set { descripcionIVA = value; }
		}

		#endregion
	}
}
