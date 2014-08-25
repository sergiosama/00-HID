using System;

namespace Entidades
{
  /// <summary>
  /// Categoria o Tipo del Recurso, es decir que funcion cumple dentro de la Empresa
  /// Cuidado!! esto puede transformarse o confundirse con los skills...para mi hay dos categorias principales: Administrativos y Profesionales
  /// </summary>
  public class enTCategoriaRecurso
	{
		#region Fields

		private int _idCategoria;
		private string _detalle;

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
			this._detalle = detalle;
		}

		/// <summary>
		/// Initializes a new instance of the enTCategoriaRecurso class.
		/// </summary>
		public enTCategoriaRecurso(int idCategoria, string detalle)
		{
			this._idCategoria = idCategoria;
			this._detalle = detalle;
		}

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the IdCategoria value.
		/// </summary>
    public virtual int IdCategoria
		{
			get { return _idCategoria; }
			set { _idCategoria = value; }
		}

		/// <summary>
		/// Gets or sets the Detalle value.
		/// </summary>
		public virtual string Detalle
		{
			get { return _detalle; }
			set { _detalle = value; }
		}

		#endregion
	}
}
