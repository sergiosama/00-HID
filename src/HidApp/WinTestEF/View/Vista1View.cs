using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using DevExpress.Mvvm.POCO;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
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

    private Control _parent;
    private RibbonControl _ribbon;

    private string _lastPage;

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

      _lastPage = null;   //  ya se... redundante...

      _locator = locator;
      //  _viewModel = ViewModelSource.Create(() => new StockViewModel(new Localizador()));
      _viewModel = ViewModelSource.Create(() => new Vista1ViewModel(_locator));

      //  bind eventos del VM
      _viewModel.WorkViewAdded += ViewModelOnWorkViewAdded;
      _viewModel.WorkViewRemoved += ViewModelOnWorkViewRemoved;

      //  Esto era para probar algo...
      //  object x = ribView.Items["bbnPagina1"];

      CreateWorkViews();

      BindCommands();
    }

    private void CreateWorkViews()
    {
      _workViews = new Dictionary<ViewType, IWorkView>();

      _workViews.Add(ViewType.Pagina_1, _locator.GetView(ViewType.Pagina_1) as IWorkView);
      _workViews.Add(ViewType.Pagina_2, _locator.GetView(ViewType.Pagina_2) as IWorkView);
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
      //  tengo que tomar cada work view y asociarles los comandos a sus respectivos viewmodels...
      IWorkView workView;

      workView = _workViews[ViewType.Pagina_1];

      bbnPagina1.BindCommand(workView.ViewModel.GetActionFromName("Procesar1"), workView.ViewModel);
      bbnToggle.BindCommand(workView.ViewModel.GetActionFromName("Toggle"), workView.ViewModel);

      workView = _workViews[ViewType.Pagina_2];

      bbnPagina2.BindCommand(workView.ViewModel.GetActionFromName("Procesar2"), workView.ViewModel);
    }

    //  Eventos de cambio de pagina: asociarlos al view model para que cambie tambien

    #endregion


    /// <summary>
    /// Este Ribbon es local y solamente sirve para hacer merge con el MAIN
    /// Luego no se puede utilizar para NADA
    /// </summary>
    public DevExpress.XtraBars.Ribbon.RibbonControl Ribbon
    {
      get { return this.ribView; }
    }

    public void SetMainRibbon(RibbonControl ribbon)
    {
      _ribbon = ribbon;
    }

    public void BindEvents()
    {
      _ribbon.SelectedPageChanged += Cambio_Pagina;
    }

    public void FocusOnPage()
    {
      //  ojo: guardar donde estaba posicionado...
      //
      //  ribbon.SelectedPage = ribStock.Pages["INSUMOS"];
      if (_lastPage != null)
        _ribbon.SelectedPage = ribView.Pages[_lastPage];
      else
        _ribbon.SelectedPage = _ribbon.MergedPages[0];
      //_viewModel.SetDefaultView();
    }

    /// <summary>
    /// Antes de abandonar la vista navegable, tengo que guardar el estado de donde estaba
    /// </summary>
    public void SaveVisualState()
    {
      _lastPage = _ribbon.SelectedPage.Text;
    }

    /// <summary>
    /// Cuando la vista navegable vuelve a estar activa
    /// </summary>
    public void RestoreVisualState()
    {
      
    }

    private void ViewModelOnWorkViewRemoved(object sender, EventArgs eventArgs)
    {
      var oldVista = sender as Control;

      oldVista.Parent = null;
    }

    /// <summary>
    /// El ViewModel informa a la vista principal que OTRA vista fue elegida
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="eventArgs"></param>
    private void ViewModelOnWorkViewAdded(object sender, EventArgs eventArgs)
    {
      var nuevaVista = sender as Control;

      if (nuevaVista != null)
      {
        nuevaVista.Dock = DockStyle.Fill;
        nuevaVista.Parent = _parent;
        //  Si en la principal seteo la navegable en el control parent, tengo que hacer
        //  si o si el BringToFront()
        //nuevaVista.BringToFront();
        //  cambiar titulo de barra segun la vista!!
        //  CONECTAR A SEARCH CONTROL!!
      }
    }

    ViewType ISupportPreviousView.PreviousViewType { get; set; }

    private void Cambio_Pagina(object sender, EventArgs e)
    {
      //  OJO!! Que pasa si va a una vista que no esta dentro del navegador???
      RibbonControl rib = sender as RibbonControl;
      ViewType vtTag;

      Debug.WriteLine(string.Format("Cambio de pagina MERGED destino --> {0}", rib.SelectedPage.Text));

      //  se produce cuando cambio de pagina en ribbon => hay que cambiar de vista de trabajo
      string nombreVista = rib.SelectedPage.Tag as string;

      //  chequear si el tag no corresponde, tendriamos que avisar a la vista principal (no es necesario porque el evento tambien lo recibe 
      //  la vista principal)
      if (Enum.TryParse(nombreVista, out vtTag))
      {
        _viewModel.SetCurrentWorkViewType(vtTag);
        SaveVisualState();
      }
      //  _viewModel.SetCurrentWorkViewType((ViewType)Enum.Parse(typeof(ViewType), nombreVista));
    }

    public void SetContainer(Control ctrl)
    {
      _parent = ctrl;
    }

    public void UnsetContainer()
    {
      _parent = null;
      _viewModel.SelectedWorkViewType = ViewType.Ninguno;
    }
  }
}
