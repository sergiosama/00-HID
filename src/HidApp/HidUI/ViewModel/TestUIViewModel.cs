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

    public TestUIViewModel()
    {
      SecurityServices sec = new SecurityServices();

      Contexto.Current.Sesion = sec.LoginUser("ethedy", "viterilove");

      //  lo creo porque lo necesito, puede que ya este creado por otra VIEW...
      _viewModel = ViewModelSource.Create(() => new ProveedoresViewModel());
    }

    #region Comandos

    [Command(UseCommandManager = false)]
    public void NewProveedor()
    {
      var editService = GetService<IFormEditService>();

      editService.ViewModel = _viewModel;
      editService.Run(FormEditAction.EditarNuevo);
    }

    public bool CanNewProveedor()
    {
      return true;
    }

    public void EditProveedor()
    {
      var editService = GetService<IFormEditService>();

      editService.ViewModel = _viewModel;
      //  obtener un proveedor --> LISTO
      //  setear el proveedor en el view model --> LISTO
      editService.Run(FormEditAction.EditarExitente);
    }

    public bool CanEditProveedor()
    {
      return (_viewModel.Current != null);
    }

    public void BuscarProveedor()
    {
      var searchService = GetService<IFormSearchService<Proveedor>>();

      Proveedor prov = searchService.Show();
      _viewModel.SetProveedor(prov);
    }

    public bool CanBuscarProveedor()
    {
      return true;
    }

    #endregion

  }
}
