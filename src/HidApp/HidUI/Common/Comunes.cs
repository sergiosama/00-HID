using DevExpress.XtraBars.Ribbon;

namespace HidUI.Common
{
  /// <summary>
  /// Define cada tipo de vista dentro del sistema
  /// </summary>
  public enum ViewType
  {
    /// <summary>
    /// No hay ninguna vista activa
    /// </summary>
    Ninguno,
    /// <summary>
    /// UC integrable en el formulario principal
    /// </summary>
    About,
    /// <summary>
    /// Usado en la ventana modal de login
    /// </summary>
    Login,
    /// <summary>
    /// UC con tiles que permiten la navegación entre diferentes secciones de la aplicacion
    /// </summary>
    StartMenu,
    /// <summary>
    /// UC con Ribbon integrable, no tiene nada pero por defecto deberia ir a StockInsumos (guardar ultima seleccion)
    /// </summary>
    Stock,
    /// <summary>
    /// UC integrable, seleccionado mediante la pagina Insumos de la Ribbon de Stock
    /// </summary>
    StockInsumos,
    /// <summary>
    /// UC integrable, seleccionado mediante la pagina Alquilables de la Ribbon de Stock
    /// </summary>
    StockAlquilables,
    /// <summary>
    /// UC integrable, permite administrar la impresion de etiquetas
    /// </summary>
    ///StockEtiquetas,
    /// <summary>
    /// UC integrable, permite incorporar la impresión de reportes relacionados con el stock
    /// </summary>
    StockReportes,
    PacientesView,
    StokInsumosView

  }

  /// <summary>
  /// Esta interface sirve para decidir si una vista necesita o no merge y por supuesto para obtener el ribbon que posee
  /// </summary>
  public interface ISupportRibbon
  {
    RibbonControl Ribbon { get; }
    void FocusOnPage(RibbonControl ribbon);
  }

  public interface IViewLocator
  {
    object GetView(ViewType viewType);
  }

  /// <summary>
  /// Las vistas que implementen esta interface podran direccionarse hacia otra en el momento 
  /// de cerrarse o con alguna ayuda visual
  /// El metodo CloseView() de MainViewModel es quien finalmente cierra la vista y la reemplaza
  /// por la vista previa
  /// </summary>
  public interface ISupportPreviousView
  {
    ViewType PreviousView { get; set; }
  }

  public interface INavigableView
  {
    
  }

  public interface IWorkView
  {
    
  }

  public interface ILoginService
  {
    void Show();
  }

}
