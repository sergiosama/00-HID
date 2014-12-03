using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq.Expressions;
using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using Entidades;
using HidUI.Common;
using Servicios;

namespace HidUI.ViewModel
{
  public class StockInsumosViewModel : ViewModelBase, IWorkViewModel
  {
    private ArticulosServices _svc;

    public StockInsumosViewModel()
    {
      _svc = new ArticulosServices();
    }

    /// <summary>
    /// El articulo actual que se esta editando o agregando
    /// </summary>
    public virtual enTArticulo Current { get; set; }

    //  usar ObservableCollection? o BindingList?
    //  public virtual TiposArticulo
    //  Proveedores

    #region Comandos Work Views

    [Command(UseCommandManager = false)]
    public void Nuevo()
    {
      Debug.WriteLine("PRIVILEGIOS: agregar articulo");
      Current = new enTArticulo();
    }

    public bool CanNuevo()
    {
      return true;
    }

    /*
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
      if (name == "Nuevo")
        return () => this.Nuevo();

      //if (name == "Dummy")
      //  return () => this.Dummy();

      return null;
    }
  }
}
