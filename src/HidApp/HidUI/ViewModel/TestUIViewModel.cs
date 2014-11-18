using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using Entidades;
using HidUI.Common;
using Infraestructura;
using Servicios;

namespace HidUI.ViewModel
{
  public class TestUIViewModel : ViewModelBase
  {
    private readonly ProveedoresViewModel _viewModel;

    private bool _editEnabled;

    public TestUIViewModel()
    {
      _editEnabled = false;
      
      SecurityServices sec = new SecurityServices();

      Contexto.Current.Sesion = sec.LoginUser("ethedy", "viterilove");

      //  lo creo porque lo necesito, puede que ya este creado por otra VIEW...
      _viewModel = ViewModelSource.Create(() => new ProveedoresViewModel());

      UserName = Contexto.Current.Sesion.FullName;
    }

    public virtual string UserName { get; set; }

    public virtual string SearchResult { get; set; }

    #region Comandos

    [Command(UseCommandManager = false)]
    public void NewProveedor()
    {
      var editService = GetService<IFormEditService<Proveedor>>();

      SearchResult = null;

      _editEnabled = false;
      this.RaiseCanExecuteChanged(x => x.EditProveedor());

      //  Si selecciona la opcion de nuevo proveedor, entonces hay que crear una instancia nueva de esta clase
      //
      _viewModel.SetCurrent(new Proveedor());   //  TODO reemplazar por metodo NewProveedor??
      editService.ViewModel = _viewModel;
      editService.Run(FormEditAction.EditarNuevo);
    }

    public bool CanNewProveedor()
    {
      return true;
    }

    [Command(UseCommandManager = false)]
    public void EditProveedor()
    {
      var editService = GetService<IFormEditService<Proveedor>>();

      editService.ViewModel = _viewModel;
      //  obtener un proveedor --> LISTO
      //  setear el proveedor en el view model --> LISTO
      editService.Run(FormEditAction.EditarExitente);
    }

    public bool CanEditProveedor()
    {
      return _editEnabled;
    }

    [Command(UseCommandManager = false)]
    public void BuscarProveedor()
    {
      var searchService = GetService<IFormSearchService<Proveedor>>();
      Proveedor prov = searchService.Show();

      if (prov != null)
      {
        SearchResult = prov.Nombre;
        _viewModel.SetCurrent(prov);
        _editEnabled = true;
      }
      else
      {
        _editEnabled = false;
        SearchResult = null;
      }

      this.RaiseCanExecuteChanged(x => x.EditProveedor());
    }

    public bool CanBuscarProveedor()
    {
      return true;
    }

    #endregion

  }
}
