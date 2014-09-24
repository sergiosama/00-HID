using System;

namespace Entidades
{
	public class enTPlanObraSocial
	{
		#region Fields

		private int idPlanObraSocial;
		private int idObraSocial;
		private string nombrePlan;

		#endregion

		#region Constructors

		/// <summary>
		/// Initializes a new instance of the enTPlanObraSocial class.
		/// </summary>
		public enTPlanObraSocial()
		{
		}

		/// <summary>
		/// Initializes a new instance of the enTPlanObraSocial class.
		/// </summary>
		public enTPlanObraSocial(int idObraSocial, string nombrePlan)
		{
			this.idObraSocial = idObraSocial;
			this.nombrePlan = nombrePlan;
		}

		/// <summary>
		/// Initializes a new instance of the enTPlanObraSocial class.
		/// </summary>
		public enTPlanObraSocial(int idPlanObraSocial, int idObraSocial, string nombrePlan)
		{
			this.idPlanObraSocial = idPlanObraSocial;
			this.idObraSocial = idObraSocial;
			this.nombrePlan = nombrePlan;
		}

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the IdPlanObraSocial value.
		/// </summary>
		public virtual int IdPlanObraSocial
		{
			get { return idPlanObraSocial; }
			set { idPlanObraSocial = value; }
		}

		/// <summary>
		/// Gets or sets the IdObraSocial value.
		/// </summary>
		public virtual int IdObraSocial
		{
			get { return idObraSocial; }
			set { idObraSocial = value; }
		}

		/// <summary>
		/// Gets or sets the NombrePlan value.
		/// </summary>
		public virtual string NombrePlan
		{
			get { return nombrePlan; }
			set { nombrePlan = value; }
		}

		#endregion
	}
}
