using DevExpress.Mvvm.POCO;
using DevExpress.XtraEditors;
using HidUI.Common;
using HidUI.ViewModel;

namespace HidUI.Views
{
  /// <summary>
  /// Vista que permite usar las paginas del ribbon para navegar entre diferentes sub-vistas o vistas de trabajo
  /// Ojo una vista navegable tiene muchas cosas en comun, posiblemente haya que hacer una clase base...
  /// </summary>
  public partial class StockView : XtraUserControl, ISupportRibbon, INavigableView
  {
    private readonly StockViewModel _viewModel;

    public StockView()
    {
      InitializeComponent();
      _viewModel = ViewModelSource.Create(() => new StockViewModel(new Localizador()));
    }

#region Command Binding

    //  Tener en cuenta que por ahora tenemos todos los view models accesibles, luego deberiamos bindear solo los necesarios!!

    //  Eventos de cambio de pagina: asociarlos al view model para que cambie tambien

#endregion



    public DevExpress.XtraBars.Ribbon.RibbonControl Ribbon
    {
      get { return this.ribStock; }
    }

    public void FocusOnPage(DevExpress.XtraBars.Ribbon.RibbonControl ribbon)
    {
      //  ojo: guardar donde estaba posicionado...
      //
      ribbon.SelectedPage = ribStock.Pages["INSUMOS"];
    }
  }
}
