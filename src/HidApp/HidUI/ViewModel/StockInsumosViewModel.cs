using System;
using System.Linq.Expressions;
using DevExpress.Mvvm;
using HidUI.Common;

namespace HidUI.ViewModel
{
  public class StockInsumosViewModel : ViewModelBase, IWorkViewModel
  {
    public StockInsumosViewModel()
    {
      
    }

    public Expression<Action> GetActionFromName(string name)
    {
      throw new NotImplementedException();
    }
  }
}
