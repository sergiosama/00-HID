using DevExpress.Mvvm;

namespace WinTestEF.ViewModel
{
  public class StartViewModel : ViewModelBase
  {
    /// <summary>
    /// Avisa al ViewModel principal que debe navegar a la vista de Stock
    /// La vista de Stock a su vez consta de varias páginas o sub-vistas o WorkViews que no poseen ribbon ya que utilizarian la que 
    /// esta en la vista de Stock para navegar entre las mismas
    /// </summary>
    public void NavigateToStock()
    {
      Helpers.MainForm.MainViewModel.NavigateTo(ViewType.Stock);
    }
  }
}
