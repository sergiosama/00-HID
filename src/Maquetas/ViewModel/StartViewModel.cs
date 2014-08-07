using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Mvvm;
using Maquetas.Common;

namespace Maquetas.ViewModel
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
