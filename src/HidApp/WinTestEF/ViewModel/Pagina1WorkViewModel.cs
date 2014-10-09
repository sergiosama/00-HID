using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;

namespace WinTestEF.ViewModel
{
  public class Pagina1WorkViewModel : ViewModelBase, IWorkViewModel
  {
    private bool _local;

    public Pagina1WorkViewModel()
    {
      _local = false;
    }

    #region Comandos Work Views

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

    #endregion

    public Expression<Action> GetActionFromName(string name)
    {
      if (name == "Procesar1")
        return () => this.Comando_Procesar1();

      if (name == "Toggle")
        return () => this.Comando_Toggle();

      return null;
    }
  }
}
