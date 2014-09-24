using System;

namespace Entidades
{
	public class enTOrden
	{
		#region Fields

		private int idOrder;
		private int idArticulo;
		private int idPacientes;
		private int idRecurso;
		private DateTime fechaOrden;

		#endregion

		#region Constructors

		/// <summary>
		/// Initializes a new instance of the enTOrden class.
		/// </summary>
		public enTOrden()
		{
		}

		/// <summary>
		/// Initializes a new instance of the enTOrden class.
		/// </summary>
		public enTOrden(int idOrder, int idArticulo, int idPacientes, int idRecurso, DateTime fechaOrden)
		{
			this.idOrder = idOrder;
			this.idArticulo = idArticulo;
			this.idPacientes = idPacientes;
			this.idRecurso = idRecurso;
			this.fechaOrden = fechaOrden;
		}

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the IdOrder value.
		/// </summary>
		public virtual int IdOrder
		{
			get { return idOrder; }
			set { idOrder = value; }
		}

		/// <summary>
		/// Gets or sets the IdArticulo value.
		/// </summary>
		public virtual int IdArticulo
		{
			get { return idArticulo; }
			set { idArticulo = value; }
		}

		/// <summary>
		/// Gets or sets the IdPacientes value.
		/// </summary>
		public virtual int IdPacientes
		{
			get { return idPacientes; }
			set { idPacientes = value; }
		}

		/// <summary>
		/// Gets or sets the IdRecurso value.
		/// </summary>
		public virtual int IdRecurso
		{
			get { return idRecurso; }
			set { idRecurso = value; }
		}

		/// <summary>
		/// Gets or sets the FechaOrden value.
		/// </summary>
		public virtual DateTime FechaOrden
		{
			get { return fechaOrden; }
			set { fechaOrden = value; }
		}

		#endregion
	}
}
