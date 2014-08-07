using System;

namespace Entidades
{
	public class enTSubCodigoNomenclador
	{
		#region Fields

		private int idSubCodigoNomenclador;
		private int idCodigoNomenclador;
		private string subCodigo;
		private string descripcion1;
		private string descripcion2;
		private float honorarios;
		private string valor_H;
		private string tipo;
		private float gastos;
		private string valor_G;
		private string nomra1;
		private string norma2;
		private string norma3;

		#endregion

		#region Constructors

		/// <summary>
		/// Initializes a new instance of the enTSubCodigoNomenclador class.
		/// </summary>
		public enTSubCodigoNomenclador()
		{
		}

		/// <summary>
		/// Initializes a new instance of the enTSubCodigoNomenclador class.
		/// </summary>
		public enTSubCodigoNomenclador(int idCodigoNomenclador, string subCodigo, string descripcion1, string descripcion2, float honorarios, string valor_H, string tipo, float gastos, string valor_G, string nomra1, string norma2, string norma3)
		{
			this.idCodigoNomenclador = idCodigoNomenclador;
			this.subCodigo = subCodigo;
			this.descripcion1 = descripcion1;
			this.descripcion2 = descripcion2;
			this.honorarios = honorarios;
			this.valor_H = valor_H;
			this.tipo = tipo;
			this.gastos = gastos;
			this.valor_G = valor_G;
			this.nomra1 = nomra1;
			this.norma2 = norma2;
			this.norma3 = norma3;
		}

		/// <summary>
		/// Initializes a new instance of the enTSubCodigoNomenclador class.
		/// </summary>
		public enTSubCodigoNomenclador(int idSubCodigoNomenclador, int idCodigoNomenclador, string subCodigo, string descripcion1, string descripcion2, float honorarios, string valor_H, string tipo, float gastos, string valor_G, string nomra1, string norma2, string norma3)
		{
			this.idSubCodigoNomenclador = idSubCodigoNomenclador;
			this.idCodigoNomenclador = idCodigoNomenclador;
			this.subCodigo = subCodigo;
			this.descripcion1 = descripcion1;
			this.descripcion2 = descripcion2;
			this.honorarios = honorarios;
			this.valor_H = valor_H;
			this.tipo = tipo;
			this.gastos = gastos;
			this.valor_G = valor_G;
			this.nomra1 = nomra1;
			this.norma2 = norma2;
			this.norma3 = norma3;
		}

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the IdSubCodigoNomenclador value.
		/// </summary>
		public virtual int IdSubCodigoNomenclador
		{
			get { return idSubCodigoNomenclador; }
			set { idSubCodigoNomenclador = value; }
		}

		/// <summary>
		/// Gets or sets the IdCodigoNomenclador value.
		/// </summary>
		public virtual int IdCodigoNomenclador
		{
			get { return idCodigoNomenclador; }
			set { idCodigoNomenclador = value; }
		}

		/// <summary>
		/// Gets or sets the SubCodigo value.
		/// </summary>
		public virtual string SubCodigo
		{
			get { return subCodigo; }
			set { subCodigo = value; }
		}

		/// <summary>
		/// Gets or sets the Descripcion1 value.
		/// </summary>
		public virtual string Descripcion1
		{
			get { return descripcion1; }
			set { descripcion1 = value; }
		}

		/// <summary>
		/// Gets or sets the Descripcion2 value.
		/// </summary>
		public virtual string Descripcion2
		{
			get { return descripcion2; }
			set { descripcion2 = value; }
		}

		/// <summary>
		/// Gets or sets the Honorarios value.
		/// </summary>
		public virtual float Honorarios
		{
			get { return honorarios; }
			set { honorarios = value; }
		}

		/// <summary>
		/// Gets or sets the Valor_H value.
		/// </summary>
		public virtual string Valor_H
		{
			get { return valor_H; }
			set { valor_H = value; }
		}

		/// <summary>
		/// Gets or sets the Tipo value.
		/// </summary>
		public virtual string Tipo
		{
			get { return tipo; }
			set { tipo = value; }
		}

		/// <summary>
		/// Gets or sets the Gastos value.
		/// </summary>
		public virtual float Gastos
		{
			get { return gastos; }
			set { gastos = value; }
		}

		/// <summary>
		/// Gets or sets the Valor_G value.
		/// </summary>
		public virtual string Valor_G
		{
			get { return valor_G; }
			set { valor_G = value; }
		}

		/// <summary>
		/// Gets or sets the Nomra1 value.
		/// </summary>
		public virtual string Nomra1
		{
			get { return nomra1; }
			set { nomra1 = value; }
		}

		/// <summary>
		/// Gets or sets the Norma2 value.
		/// </summary>
		public virtual string Norma2
		{
			get { return norma2; }
			set { norma2 = value; }
		}

		/// <summary>
		/// Gets or sets the Norma3 value.
		/// </summary>
		public virtual string Norma3
		{
			get { return norma3; }
			set { norma3 = value; }
		}

		#endregion
	}
}
