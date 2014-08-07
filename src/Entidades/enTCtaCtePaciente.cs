using System;

namespace Entidades
{
	public class enTCtaCtePaciente
	{
		#region Fields

		private int nroCuenta;
		private int idPaciente;
		private DateTime fecha;
		private decimal debe;
		private decimal haber;
		private decimal saldo;

		#endregion

		#region Constructors

		/// <summary>
		/// Initializes a new instance of the enTCtaCtePaciente class.
		/// </summary>
		public enTCtaCtePaciente()
		{
		}

		/// <summary>
		/// Initializes a new instance of the enTCtaCtePaciente class.
		/// </summary>
		public enTCtaCtePaciente(int nroCuenta, int idPaciente, DateTime fecha, decimal debe, decimal haber, decimal saldo)
		{
			this.nroCuenta = nroCuenta;
			this.idPaciente = idPaciente;
			this.fecha = fecha;
			this.debe = debe;
			this.haber = haber;
			this.saldo = saldo;
		}

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the NroCuenta value.
		/// </summary>
		public virtual int NroCuenta
		{
			get { return nroCuenta; }
			set { nroCuenta = value; }
		}

		/// <summary>
		/// Gets or sets the IdPaciente value.
		/// </summary>
		public virtual int IdPaciente
		{
			get { return idPaciente; }
			set { idPaciente = value; }
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
