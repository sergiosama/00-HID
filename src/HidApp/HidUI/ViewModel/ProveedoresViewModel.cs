using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;

using Entidades;
using Infraestructura;
using Servicios;

namespace HidUI.ViewModel
{
  public class ProveedoresViewModel : ViewModelBase
  {
    public event EventHandler ViewMustClose;
    public event EventHandler<IList<HidErrorInfo>> ViewHasErrors;

    private readonly ArticulosServices _svc;

    private bool _canKeep;

    public ProveedoresViewModel()
    {
      _svc = new ArticulosServices();
      Current = new Proveedor();
      _canKeep = true;
    }

    /// <summary>
    /// Propiedad de binding con la UI
    /// </summary>
    public virtual Proveedor Current { get; set; }

    /// <summary>
    /// Ajusta una instancia de Proveedor en el VM para permitir la edicion
    /// La opcion de "Guardar y Seguir" se deshabilita
    /// </summary>
    /// <param name="proveedor"></param>
    public void SetProveedor(Proveedor proveedor)
    {
      Current = proveedor;
      _canKeep = false;
    }

    #region Comandos

    [Command(UseCommandManager = false)]
    public void Add_Exit()
    {
      if (_svc.AddProveedor(Current))
      {
        if (ViewMustClose != null)
          ViewMustClose(null, null);
      }
      else
      {
        //  avisar de alguna manera que existe un error...
        //  servicio MessageBoxService
        //  por ahora un evento
        if (ViewHasErrors != null)
          ViewHasErrors(this, _svc.Errores);
      }
    }

    public bool CanAdd_Exit()
    {
      Debug.WriteLine("PRIVILEGIOS: agregar proveedor");
      return true;
    }

    [Command(UseCommandManager = false)]
    public void Add_Keep()
    {
      if (!_svc.AddProveedor(Current))
      {
        if (ViewHasErrors != null)
          ViewHasErrors(this, _svc.Errores);
      }
      else
        Current = new Proveedor();
    }

    public bool CanAdd_Keep()
    {
      Debug.WriteLine("PRIVILEGIOS: agregar proveedor");
      return _canKeep;
    }

    [Command(UseCommandManager = false)]
    public void Cancelar()
    {
      //  deshacer cualquier cambio hecho...
      if (ViewMustClose != null)
        ViewMustClose(null, null);
    }

    public bool CanCancelar()
    {
      return true;
    }

    [Command(UseCommandManager = false)]
    public void Save_Exit()
    {
      if (_svc.UpdateProveedor(Current))
      {
        if (ViewMustClose != null)
          ViewMustClose(null, null);
      }
      else
      {
        if (ViewHasErrors != null)
          ViewHasErrors(this, _svc.Errores);
      }
    }

    public bool CanSave_Exit()
    {
      Debug.WriteLine("PRIVILEGIOS: modificar proveedor");
      return true;
    }

    #endregion
  }
}
