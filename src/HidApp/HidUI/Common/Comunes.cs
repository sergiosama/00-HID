using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Windows.Forms;
using DevExpress.Mvvm;
using DevExpress.XtraBars.Ribbon;
using Infraestructura;

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
    /// [NAVEGABLE] UC con Ribbon integrable, no tiene nada pero por defecto deberia ir a StockInsumos (guardar ultima seleccion)
    /// </summary>
    Stock,

    /// <summary>
    /// [WORK VIEW] UC integrable, seleccionado mediante la pagina Insumos de la Ribbon de Stock
    /// </summary>
    StockInsumos,

    /// <summary>
    /// [WORK VIEW] UC integrable, seleccionado mediante la pagina Alquilables de la Ribbon de Stock
    /// </summary>
    StockAlquilables,

    /// <summary>
    /// [WORK VIEW] UC integrable, permite administrar la impresion de etiquetas
    /// </summary>
    ///StockEtiquetas,
    /// 
    /// <summary>
    /// [WORK VIEW] UC integrable, permite incorporar la impresión de reportes relacionados con el stock
    /// </summary>
    StockReportes,

    

    PacientesView
  }

  /// <summary>
  /// Define las distintas posibilidades de terminación de un servicio de edicion
  /// </summary>
  public enum FormEditResult
  {
    Cancelado,
    /// <summary>
    /// Este valor puede usarse tanto para los elementos que SOLO se modifican como para especificar que ALGO se modifico (por ejemplo
    /// la coleccion de dichos elementos por el agregado de uno o mas elementos)
    /// </summary>
    Modificado,
    Agregado,
    AgregadoUno,
    AgregadoVarios
  }

  public enum FormEditAction
  {
    EditarNuevo,
    EditarExitente
  }

  /// <summary>
  /// Esta interface sirve para decidir si una vista necesita o no merge y por supuesto para obtener el ribbon que posee
  /// </summary>
  public interface ISupportRibbon
  {
    RibbonControl Ribbon { get; }

    /// <summary>
    /// Informa a la vista cual es la instancia de la ribbon merged (MAIN) que de hecho es la unica que tiene sentido utilizar
    /// </summary>
    /// <param name="ribbon"></param>
    void SetMainRibbon(RibbonControl ribbon);

    /// <summary>
    /// Le da oportunidad a la vista de asociar nuevos eventos de cambio de pagina a la ribbon merged
    /// </summary>
    void BindEvents();

    /// <summary>
    /// Le da oportunidad a la vista de hacer foco en una pagina determinada de la ribbon compuesta
    /// </summary>
    void FocusOnPage();
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
    ViewType PreviousViewType { get; set; }
  }

  /// <summary>
  /// [VIEW MODEL] El VM de una vista de trabajo debera tener como minimo un metodo para enlazar comandos
  /// Por otra parte, es un VM común y corriente
  /// </summary>
  public interface IWorkViewModel
  {
    Expression<Action> GetActionFromName(string name);
  }

  /// <summary>
  /// Una vista navegable posee un ribbon y no tiene contenidos
  /// Utiliza el contenedor de la vista principal para incorporar las vistas de trabajo que se vayan activando
  /// </summary>
  public interface INavigableView
  {
    /// <summary>
    /// Permite asociar un control de la vista principal para que sirva de content control en todas las work-views de la vista navegable
    /// </summary>
    /// <param name="ctrl"></param>
    void SetContainer(Control ctrl);

    /// <summary>
    /// Avisa que el control que se esta usando de content ya no estara mas disponible para la vista navegable
    /// </summary>
    void UnsetContainer();

    /// <summary>
    /// Le da la oportunidad a la vista de guardar el estado visual (en discusion)
    /// </summary>
    void SaveVisualState();

    /// <summary>
    /// En discusion
    /// </summary>
    void RestoreVisualState();
  }

  /// <summary>
  /// Establece la minima funcionalidad que el view model de una vista navegable deberia disponer
  /// </summary>
  public interface INavigableViewModel
  {
    ViewType SelectedWorkViewType { get; set; }

    object SelectedWorkView { get; set; }
    
    void SetCurrentWorkViewType(ViewType vt);

    /// <summary>
    /// Este metodo esta en capilla...
    /// </summary>
    void SetDefaultView();

    event EventHandler WorkViewAdded;
    event EventHandler WorkViewRemoved;
  }

  /// <summary>
  /// [WORK VIEW] Una vista de trabajo no posee ribbon sino que usa la ribbon de la vista navegable en donde esta\n
  /// residiendo. Para eso BindCommands permite enlazar controles de la ribbon en esta vista de trabajo\n
  /// Toda vista de trabajo debe tener una referencia a un view model que implemente IWorkViewModel para poder enlazar
  /// estos comandos
  /// Las vistas de trabajo comunmente se activan mediante cambios de pagina del ribbon
  /// </summary>
  public interface IWorkView
  {
    void BindCommands(ISupportRibbon parent);

    IWorkViewModel ViewModel { get; set; }
  }

  /// <summary>
  /// Interface utilizada para servicios de login
  /// </summary>
  public interface ILoginService
  {
    void Show();
  }

  /// <summary>
  /// Contiene la funcionalidad comun a todos los view model que pueden usarse dentro de un formulario de edicion de entidades
  /// </summary>
  /// <remarks>
  /// Add_Exit(), Add_Keep(), Save_Exit() y Cancel() seran las acciones basicas que cualquiera de estos formularios debera tener
  /// Luego podran existir otras
  /// 
  /// </remarks>
  /// <typeparam name="T"></typeparam>
  public interface IFormEditViewModel<T> 
  {
    event EventHandler ViewMustClose;

    event EventHandler<IList<HidErrorInfo>> ViewHasErrors;

    /// <summary>
    /// Devuelve o establece la instancia actual (tipo T) del elemento que esta siendo editado
    /// </summary>
    T Current { get; set; }

    void SetCurrent(T newCurrent);

    /// <summary>
    /// Este metodo por ahora es necesario para poder saber si estoy o no editando...
    /// Pensar bien si es util
    /// </summary>
    void SetNew();

    void Add_Exit();

    void Add_Keep();

    void Save_Exit();

    void Cancel();
  }

  /// <summary>
  /// Una vista o control que contiene entrada tipo formulario y que puede embeberse en un dialogo, popup, etc...
  /// </summary>
  public interface IFormEditView<T>
  {
    event EventHandler CloseView;

    /// <summary>
    /// Devuelve o establece el tipo de accion a la que tiene que responder el view model: editar existente o editar nuevo
    /// </summary>
    FormEditAction Action { get; set; }

    void SetViewModel(IFormEditViewModel<T> vm);
  }

  /// <summary>
  /// Interface utilizada para servicios de edicion de cualquier tipo 
  /// (normalmente un formulario con campos para ingresar o actualizar elementos)
  /// Este servicio seguro que necesita de un ViewModel para funcionar...
  /// El hecho que diga FORM es porque el ingreso es una especie de formulario, no porque tenga que usarse forms de Windows...
  /// </summary>
  public interface IFormEditService<T> 
  {
    /// <summary>
    /// Metodo que efectivamente muestra el formulario de edicion para la entidad que estoy necesitando
    /// </summary>
    /// <param name="action">Permite ejecutar el servicio en modo nuevo elemento o en modo editar actual</param>
    /// <returns></returns>
    FormEditResult Run(FormEditAction action);

    /// <summary>
    /// El view model de un servicio de edicion tiene que tener una serie de miembros bien definidos
    /// Entre ellos, uno que permita setear y obtener el valor actual que se quiere editar
    /// </summary>
    IFormEditViewModel<T> ViewModel { get; set; }

    //  IDoc
    //  podria retornar un valor que diga si agrego/modifico uno, varios o ningun registro?
    //  podria haber metodos de callback?
    //  podria haber una propiedad que retorne una lista de los elementos agregados? (solo para ADD)
  }

  /// <summary>
  /// 
  /// </summary>
  /// <typeparam name="T"></typeparam>
  public interface IFormSearchService<out T>  where T: class 
  {
    /// <summary>
    /// Metodo que permite mostrar una ventana de busqueda simple, que retorna un elemento del tipo T o bien el 
    /// default si no se encuentra
    /// </summary>
    /// <returns></returns>
    T Show();
  }
}
