using System;

namespace Entidades
{
	public class enTCtaCteRecurso
	{
		#region Fields

		private int idCtaCteRecursos;
		private int idRecursos;
		private DateTime fecha;
		private decimal debe;
		private decimal haber;
		private decimal saldo;

		#endregion

		#region Constructors

		/// <summary>
		/// Initializes a new instance of the enTCtaCteRecurso class.
		/// </summary>
		public enTCtaCteRecurso()
		{
		}

		/// <summary>
		/// Initializes a new instance of the enTCtaCteRecurso class.
		/// </summary>
		public enTCtaCteRecurso(int idRecursos, DateTime fecha, decimal debe, decimal haber, decimal saldo)
		{
			this.idRecursos = idRecursos;
			this.fecha = fecha;
			this.debe = debe;
			this.haber = haber;
			this.saldo = saldo;
		}

		/// <summary>
		/// Initializes a new instance of the enTCtaCteRecurso class.
		/// </summary>
		public enTCtaCteRecurso(int idCtaCteRecursos, int idRecursos, DateTime fecha, decimal debe, decimal haber, decimal saldo)
		{
			this.idCtaCteRecursos = idCtaCteRecursos;
			this.idRecursos = idRecursos;
			this.fecha = fecha;
			this.debe = debe;
			this.haber = haber;
			this.saldo = saldo;
		}

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the IdCtaCteRecursos value.
		/// </summary>
		public virtual int IdCtaCteRecursos
		{
			get { return idCtaCteRecursos; }
			set { idCtaCteRecursos = value; }
		}

		/// <summary>
		/// Gets or sets the IdRecursos value.
		/// </summary>
		public virtual int IdRecursos
		{
			get { return idRecursos; }
			set { idRecursos = value; }
		}

		/// <summary>
		/// Gets or sets the Fecha value.
		/// </summary>
		public virtual DateTime Fecha
		{
			get { return fecha; }
			set { fecha = value; }
		}

		/// <summary>
		/// Gets or sets the Debe value.
		/// </summary>
		public virtual decimal Debe
		{
			get { return debe; }
			set { debe = value; }
		}

		/// <summary>
		/// Gets or sets the Haber value.
		/// </summary>
		public virtual decimal Haber
		{
			get { return haber; }
			set { haber = value; }
		}

		/// <summary>
		/// Gets or sets the Saldo value.
		/// </summary>
		public virtual decimal Saldo
		{
			get { return saldo; }
			set { saldo = value; }
		}

		#endregion
	}
}
