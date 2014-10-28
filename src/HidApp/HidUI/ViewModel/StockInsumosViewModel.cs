using DevExpress.Mvvm;

using HidUI.Common;


namespace HidUI.ViewModel
{
  public class StockInsumosViewModel : ViewModelBase
  {
    public StockInsumosViewModel()
    {
        Helpers.MainForm.MainViewModel.NavigateTo(ViewType.StockInsumos);
    }
  }
}
