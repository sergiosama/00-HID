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
using HidUI.Common;

namespace HidUI.ViewModel
{
  public class StockAlquilablesViewModel : ViewModelBase, IWorkViewModel
  {
    public StockAlquilablesViewModel()
    {
      //  
    }

    #region Comandos Work Views

    [Command(UseCommandManager = false)]
    public void Nuevo()
    {
      Debug.WriteLine("Nuevo Alquilable!!");
    }

    public bool CanNuevo()
    {
      //  TODO incorporar seguridad
      return true;
    }

    [Command(UseCommandManager = false)]
    public void Devolucion()
    {
      Debug.WriteLine("Toggle Ejecutado!!");

      //this.RaiseCanExecuteChanged(x => x.Comando_Procesar1());
    }

    #endregion

    public Expression<Action> GetActionFromName(string name)
    {
      if (name == "Nuevo")
        return () => this.Nuevo();

      if (name == "Devolucion")
        return () => this.Devolucion();

      return null;
    }
  }
}
