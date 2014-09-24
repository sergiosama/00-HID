using System;

namespace Entidades
{
	public class enTCodigoNomenclador
	{
		#region Fields

		private int idCodigoNomenclador;
		private string codigo;
		private string descripcion;
		private string norma1;
		private string norma2;

		#endregion

		#region Constructors

		/// <summary>
		/// Initializes a new instance of the enTCodigoNomenclador class.
		/// </summary>
		public enTCodigoNomenclador()
		{
		}

		/// <summary>
		/// Initializes a new instance of the enTCodigoNomenclador class.
		/// </summary>
		public enTCodigoNomenclador(string codigo, string descripcion, string norma1, string norma2)
		{
			this.codigo = codigo;
			this.descripcion = descripcion;
			this.norma1 = norma1;
			this.norma2 = norma2;
		}

		/// <summary>
		/// Initializes a new instance of the enTCodigoNomenclador class.
		/// </summary>
		public enTCodigoNomenclador(int idCodigoNomenclador, string codigo, string descripcion, string norma1, string norma2)
		{
			this.idCodigoNomenclador = idCodigoNomenclador;
			this.codigo = codigo;
			this.descripcion = descripcion;
			this.norma1 = norma1;
			this.norma2 = norma2;
		}

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the IdCodigoNomenclador value.
		/// </summary>
		public virtual int IdCodigoNomenclador
		{
			get { return idCodigoNomenclador; }
			set { idCodigoNomenclador = value; }
		}

		/// <summary>
		/// Gets or sets the Codigo value.
		/// </summary>
		public virtual string Codigo
		{
			get { return codigo; }
			set { codigo = value; }
		}

		/// <summary>
		/// Gets or sets the Descripcion value.
		/// </summary>
		public virtual string Descripcion
		{
			get { return descripcion; }
			set { descripcion = value; }
		}

		/// <summary>
		/// Gets or sets the Norma1 value.
		/// </summary>
		public virtual string Norma1
		{
			get { return norma1; }
			set { norma1 = value; }
		}

		/// <summary>
		/// Gets or sets the Norma2 value.
		/// </summary>
		public virtual string Norma2
		{
			get { return norma2; }
			set { norma2 = value; }
		}

		#endregion
	}
}
