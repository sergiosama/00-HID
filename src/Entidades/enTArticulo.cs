using System;

namespace Entidades
{
	public class enTArticulo
	{
		#region Fields

		private int _idArticulo;
		private string _codeBar;
		private int _idProveedor;
		private int _idCategoria;
		private int _idTipoArticulo;
		private string _detalleArticulo;
		private string _avisoStockMinimo;
		private float _precioCompra;
		private float _precioVenta;
		private float _precioAlquiler;
		private float _stock;
		private float _stockMinimo;

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
			this._codeBar = codeBar;
			this._idProveedor = idProveedor;
			this._idCategoria = idCategoria;
			this._idTipoArticulo = idTipoArticulo;
			this._detalleArticulo = detalleArticulo;
			this._avisoStockMinimo = avisoStockMinimo;
			this._precioCompra = precioCompra;
			this._precioVenta = precioVenta;
			this._precioAlquiler = precioAlquiler;
			this._stock = stock;
			this.stockminimo = stockminimo;
		}

		/// <summary>
		/// Initializes a new instance of the enTArticulo class.
		/// </summary>
		public enTArticulo(int idArticulo, string codeBar, int idProveedor, int idCategoria, int idTipoArticulo, string detalleArticulo, string avisoStockMinimo, float precioCompra, float precioVenta, float precioAlquiler, float stock, float stockminimo)
		{
			this._idArticulo = idArticulo;
			this._codeBar = codeBar;
			this._idProveedor = idProveedor;
			this._idCategoria = idCategoria;
			this._idTipoArticulo = idTipoArticulo;
			this._detalleArticulo = detalleArticulo;
			this._avisoStockMinimo = avisoStockMinimo;
			this._precioCompra = precioCompra;
			this._precioVenta = precioVenta;
			this._precioAlquiler = precioAlquiler;
			this._stock = stock;
			this.stockminimo = stockminimo;
		}

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the IdArticulo value.
		/// </summary>
		public virtual int IdArticulo
		{
			get { return _idArticulo; }
			set { _idArticulo = value; }
		}

		/// <summary>
		/// Gets or sets the CodeBar value.
		/// </summary>
		public virtual string CodeBar
		{
			get { return _codeBar; }
			set { _codeBar = value; }
		}

		/// <summary>
		/// Gets or sets the IdProveedor value.
		/// </summary>
		public virtual int IdProveedor
		{
			get { return _idProveedor; }
			set { _idProveedor = value; }
		}

		/// <summary>
		/// Gets or sets the IdCategoria value.
		/// </summary>
		public virtual int IdCategoria
		{
			get { return _idCategoria; }
			set { _idCategoria = value; }
		}

		/// <summary>
		/// Gets or sets the IdTipoArticulo value.
		/// </summary>
		public virtual int IdTipoArticulo
		{
			get { return _idTipoArticulo; }
			set { _idTipoArticulo = value; }
		}

		/// <summary>
		/// Gets or sets the DetalleArticulo value.
		/// </summary>
		public virtual string DetalleArticulo
		{
			get { return _detalleArticulo; }
			set { _detalleArticulo = value; }
		}

		/// <summary>
		/// Gets or sets the AvisoStockMinimo value.
		/// </summary>
		public virtual string AvisoStockMinimo
		{
			get { return _avisoStockMinimo; }
			set { _avisoStockMinimo = value; }
		}

		/// <summary>
		/// Gets or sets the PrecioCompra value.
		/// </summary>
		public virtual float PrecioCompra
		{
			get { return _precioCompra; }
			set { _precioCompra = value; }
		}

		/// <summary>
		/// Gets or sets the PrecioVenta value.
		/// </summary>
		public virtual float PrecioVenta
		{
			get { return _precioVenta; }
			set { _precioVenta = value; }
		}

		/// <summary>
		/// Gets or sets the PrecioAlquiler value.
		/// </summary>
		public virtual float PrecioAlquiler
		{
			get { return _precioAlquiler; }
			set { _precioAlquiler = value; }
		}

		/// <summary>
		/// Gets or sets the Stock value.
		/// </summary>
		public virtual float Stock
		{
			get { return _stock; }
			set { _stock = value; }
		}

		/// <summary>
		/// Gets or sets the Stockminimo value.
		/// </summary>
		public virtual float StockMinimo
		{
			get { return _stockMinimo; }
			set { _stockMinimo = value; }
		}

    /// <summary>
    /// La imagen del articulo, almacenada en la base de datos
    /// </summary>
    public byte[] Imagen { get; set; }

		#endregion
	}
}
