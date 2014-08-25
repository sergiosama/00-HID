using System;

namespace Entidades
{
  /// <summary>
  /// Representa la condicion de una persona o empresa respecto a la AFIP
  /// Algunos valores posibles
  /// - Responsable Inscripto
  /// - Excento
  /// - Monotributo B
  /// Estas condiciones no tienen que ver con el tipo de factura que debe emitirse (depende de quien la emite tambien)
  /// </summary>
	public class enTTipoIVA
	{
		#region Fields

		private int _idTipoIVA;
		private string _descripcionIVA;

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
			this._descripcionIVA = descripcionIVA;
		}

		/// <summary>
		/// Initializes a new instance of the enTTipoIVA class.
		/// </summary>
		public enTTipoIVA(int idTipoIVA, string descripcionIVA)
		{
			this._idTipoIVA = idTipoIVA;
			this._descripcionIVA = descripcionIVA;
		}

		#endregion

		#region Properties

		/// <summary>
		/// Gets or sets the IdTipoIVA value.
		/// </summary>
		public int IdTipoIVA
		{
			get { return _idTipoIVA; }
			set { _idTipoIVA = value; }
		}

		/// <summary>
		/// Descripción de la condicion segun la AFIP
		/// </summary>
		public string DescripcionIVA
		{
			get { return _descripcionIVA; }
			set { _descripcionIVA = value; }
		}

		#endregion
	}
}
