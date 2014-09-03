using DevExpress.Mvvm;
using HidUI.Common;

namespace HidUI.ViewModel
{
  //
  //  Este es un VM que pertenece a una NavigableView, no deberia tener algo que lo distinga?
  //  Si lo pensamos es similar o tiene bastantes similitudes con MainViewModel....
  public class StockViewModel : ViewModelBase
  {
    private ViewType _selectedViewType;
    private object _selectedView;
    private readonly IViewLocator _locator;

    public StockViewModel(IViewLocator locator)
    {
      
    }
  }
}
