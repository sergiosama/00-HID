using System;

namespace Entidades
{
	public class enTArticulo
	{
		#region Fields

		private int idArticulo;
		private string codeBar;
		private int idProveedor;
		private int idCategoria;
		private int idTipoArticulo;
		private string detalleArticulo;
		private string avisoStockMinimo;
		private float precioCompra;
		private float precioVenta;
		private float precioAlquiler;
		private float stock;
		private float stockminimo;

		#endregion

		#region Constructors

		/// <summary>
		/// Initializes a new instance of the enTArticulo class.
		/// </summary>
		public enTArticulo()
		{
		}

		/// <summary>
		/// Initializes a new instance of the enTArticulo class.
		/// </summary>
		public enTArticulo(string codeBar, int idProveedor, int idCategoria, int idTipoArticulo, string detalleArticulo, string avisoStockMinimo, float precioCompra, float precioVenta, float precioAlquiler, float stock, float stockminimo)
		{
			this.codeBar = codeBar;
			this.idProveedor = idProveedor;
			this.idCategoria = idCategoria;
			this.idTipoArticulo = idTipoArticulo;
			this.detalleArticulo = detalleArticulo;
			this.avisoStockMinimo = avisoStockMinimo;
			this.precioCompra = precioCompra;
			this.precioVenta = precioVenta;
			this.precioAlquiler = precioAlquiler;
			this.stock = stock;
			this.stockminimo = stockminimo;
		}

		/// <summary>
		/// Initializes a new instance of the enTArticulo class.
		/// </summary>
		public enTArticulo(int idArticulo, string codeBar, int idProveedor, int idCategoria, int idTipoArticulo, string detalleArticulo, string avisoStockMinimo, float precioCompra, float precioVenta, float precioAlquiler, float stock, float stockminimo)
		{
			this.idArticulo = idArticulo;
			this.codeBar = codeBar;
			this.idProveedor = idProveedor;
			this.idCategoria = idCategoria;
			this.idTipoArticulo = idTipoArticulo;
			this.detalleArticulo = detalleArticulo;
			this.avisoStockMinimo = avisoStockMinimo;
			this.precioCompra = precioCompra;
			this.precioVenta = precioVenta;
			this.precioAlquiler = precioAlquiler;
			this.stock = stock;
			this.stockminimo = stockminimo;
		}

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the IdArticulo value.
		/// </summary>
		public virtual int IdArticulo
		{
			get { return idArticulo; }
			set { idArticulo = value; }
		}

		/// <summary>
		/// Gets or sets the CodeBar value.
		/// </summary>
		public virtual string CodeBar
		{
			get { return codeBar; }
			set { codeBar = value; }
		}

		/// <summary>
		/// Gets or sets the IdProveedor value.
		/// </summary>
		public virtual int IdProveedor
		{
			get { return idProveedor; }
			set { idProveedor = value; }
		}

		/// <summary>
		/// Gets or sets the IdCategoria value.
		/// </summary>
		public virtual int IdCategoria
		{
			get { return idCategoria; }
			set { idCategoria = value; }
		}

		/// <summary>
		/// Gets or sets the IdTipoArticulo value.
		/// </summary>
		public virtual int IdTipoArticulo
		{
			get { return idTipoArticulo; }
			set { idTipoArticulo = value; }
		}

		/// <summary>
		/// Gets or sets the DetalleArticulo value.
		/// </summary>
		public virtual string DetalleArticulo
		{
			get { return detalleArticulo; }
			set { detalleArticulo = value; }
		}

		/// <summary>
		/// Gets or sets the AvisoStockMinimo value.
		/// </summary>
		public virtual string AvisoStockMinimo
		{
			get { return avisoStockMinimo; }
			set { avisoStockMinimo = value; }
		}

		/// <summary>
		/// Gets or sets the PrecioCompra value.
		/// </summary>
		public virtual float PrecioCompra
		{
			get { return precioCompra; }
			set { precioCompra = value; }
		}

		/// <summary>
		/// Gets or sets the PrecioVenta value.
		/// </summary>
		public virtual float PrecioVenta
		{
			get { return precioVenta; }
			set { precioVenta = value; }
		}

		/// <summary>
		/// Gets or sets the PrecioAlquiler value.
		/// </summary>
		public virtual float PrecioAlquiler
		{
			get { return precioAlquiler; }
			set { precioAlquiler = value; }
		}

		/// <summary>
		/// Gets or sets the Stock value.
		/// </summary>
		public virtual float Stock
		{
			get { return stock; }
			set { stock = value; }
		}

		/// <summary>
		/// Gets or sets the Stockminimo value.
		/// </summary>
		public virtual float Stockminimo
		{
			get { return stockminimo; }
			set { stockminimo = value; }
		}

		#endregion
	}
}
