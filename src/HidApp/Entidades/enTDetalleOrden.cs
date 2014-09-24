using System;

namespace Entidades
{
	public class enTDetalleOrden
	{
		#region Fields

		private int idOrder;
		private int idArticulo;
		private float precio;
		private float cantidad;
		private bool discontinuo;

		#endregion

		#region Constructors

		/// <summary>
		/// Initializes a new instance of the enTDetalleOrden class.
		/// </summary>
		public enTDetalleOrden()
		{
		}

		/// <summary>
		/// Initializes a new instance of the enTDetalleOrden class.
		/// </summary>
		public enTDetalleOrden(int idArticulo, float precio, float cantidad, bool discontinuo)
		{
			this.idArticulo = idArticulo;
			this.precio = precio;
			this.cantidad = cantidad;
			this.discontinuo = discontinuo;
		}

		/// <summary>
		/// Initializes a new instance of the enTDetalleOrden class.
		/// </summary>
		public enTDetalleOrden(int idOrder, int idArticulo, float precio, float cantidad, bool discontinuo)
		{
			this.idOrder = idOrder;
			this.idArticulo = idArticulo;
			this.precio = precio;
			this.cantidad = cantidad;
			this.discontinuo = discontinuo;
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
		/// Gets or sets the Precio value.
		/// </summary>
		public virtual float Precio
		{
			get { return precio; }
			set { precio = value; }
		}

		/// <summary>
		/// Gets or sets the Cantidad value.
		/// </summary>
		public virtual float Cantidad
		{
			get { return cantidad; }
			set { cantidad = value; }
		}

		/// <summary>
		/// Gets or sets the Discontinuo value.
		/// </summary>
		public virtual bool Discontinuo
		{
			get { return discontinuo; }
			set { discontinuo = value; }
		}

		#endregion
	}
}
