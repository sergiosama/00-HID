using System;
using System.Diagnostics;
using System.Linq.Expressions;
using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using HidUI.Common;

namespace HidUI.ViewModel
{
  public class StockInsumosViewModel : ViewModelBase, IWorkViewModel
  {
    public StockInsumosViewModel()
    {
      
    }

    #region Comandos Work Views

/*
    [Command(UseCommandManager = false)]
    public void Comando_Procesar1()
    {
      Debug.WriteLine("Procesar 1 Ejecutado!!");
    }

    public bool CanComando_Procesar1()
    {
      return _local;
    }

    [Command(UseCommandManager = false)]
    public void Comando_Toggle()
    {
      Debug.WriteLine("Toggle Ejecutado!!");
      _local = !_local;

      this.RaiseCanExecuteChanged(x => x.Comando_Procesar1());
    }
*/
    #endregion

    public Expression<Action> GetActionFromName(string name)
    {
      throw new NotImplementedException();
    }
  }
}
