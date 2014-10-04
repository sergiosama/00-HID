using System;
using System.Collections.Generic;
using DevExpress.Mvvm.POCO;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using WinTestEF.ViewModel;

namespace WinTestEF.View
{
  /// <summary>
  /// Vista que permite usar las paginas del ribbon para navegar entre diferentes sub-vistas o vistas de trabajo
  /// Ojo una vista navegable tiene muchas cosas en comun, posiblemente haya que hacer una clase base...
  /// </summary>
  public partial class Vista1View : XtraUserControl, ISupportRibbon, INavigableView, ISupportPreviousView
  {
    private readonly Vista1ViewModel _viewModel;

    private IViewLocator _locator;

    private Dictionary<ViewType, IWorkView> _workViews;

    public static void RegisterViews()
    {
//      ViewManager.Current.AddView(ViewType.StockInsumos, ViewType.Stock, null);
//      ViewManager.Current.AddView(ViewType.StockAlquilables, ViewType.Stock, null);
//      ViewManager.Current.AddView(ViewType.StockReportes, ViewType.Stock, null);
    }

    //  public static 
    public Vista1View(IViewLocator locator)
    {
      InitializeComponent();

      _locator = locator;
      //  _viewModel = ViewModelSource.Create(() => new StockViewModel(new Localizador()));
      _viewModel = ViewModelSource.Create(() => new Vista1ViewModel(_locator));

      CreateWorkViews();

      BindCommands();
    }

    private void CreateWorkViews()
    {
      _workViews = new Dictionary<ViewType, IWorkView>();

      _workViews.Add(ViewType.Pagina_1, _locator.GetView(ViewType.Pagina_1) as IWorkView);
    }

    protected override void OnLoad(EventArgs e)
    {
      base.OnLoad(e);

      //  TODO cambiar o arreglar porque cuando reingreso con otro user no llama de nuevo a OnLoad!!
      //  TODO y eso no seria nada, el problema es que tambien puede pasar con el mismo user
      //  _viewModel.SetDefaultView();
    }


    #region Command Binding

    //  Tener en cuenta que por ahora tenemos todos los view models accesibles, luego deberiamos bindear solo los necesarios!!

    private void BindCommands()
    {
      //  bbnPagina1.BindCommand();
    }

    //  Eventos de cambio de pagina: asociarlos al view model para que cambie tambien

    #endregion



    public DevExpress.XtraBars.Ribbon.RibbonControl Ribbon
    {
      get { return this.ribView; }
    }

    public void FocusOnPage(DevExpress.XtraBars.Ribbon.RibbonControl ribbon)
    {
      //  ojo: guardar donde estaba posicionado...
      //
      //  ribbon.SelectedPage = ribStock.Pages["INSUMOS"];
      ribbon.SelectedPage = ribView.Pages["PAGINA 2"];
    }

    /// <summary>
    /// Antes de abandonar la vista navegable, tengo que guardar el estado de donde estaba
    /// </summary>
    public void SaveVisualState()
    {
      
    }

    /// <summary>
    /// Cuando la vista navegable vuelve a estar activa
    /// </summary>
    public void RestoreVisualState()
    {
      
    }

    ViewType ISupportPreviousView.PreviousViewType { get; set; }

    private void Cambio_Pagina(object sender, EventArgs e)
    {
      //  se produce cuando cambio de pagina en ribbon => hay que cambiar de vista de trabajo
    }

  }
}
