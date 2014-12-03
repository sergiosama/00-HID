using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Mvvm.DataAnnotations;
using Entidades;
using HidUI.Common;
using Infraestructura;
using Servicios;

namespace HidUI.ViewModel
{
  public class InsumosViewModel : IFormEditViewModel<enTArticulo>
  {
    public event EventHandler ViewMustClose;
    public event EventHandler<IList<HidErrorInfo>> ViewHasErrors;

    private readonly ArticulosServices _svc;
    private bool _canKeep;

    public InsumosViewModel()
    {
      _svc = new ArticulosServices();
      Current = new enTArticulo();
      _canKeep = true;
    }

    public enTArticulo Current { get; set; }

    public void SetCurrent(enTArticulo newCurrent)
    {
      throw new NotImplementedException();
    }

    public void SetNew()
    {
      throw new NotImplementedException();
    }

    #region Comandos

    [Command(UseCommandManager = false)]
    public void Add_Exit()
    {
      throw new NotImplementedException();
    }

    public bool CanAdd_Exit()
    {
      Debug.WriteLine("PRIVILEGIOS: agregar Insumo");
      return true;
    }

    [Command(UseCommandManager = false)]
    public void Add_Keep()
    {
      throw new NotImplementedException();
    }

    public bool CanAdd_Keep()
    {
      Debug.WriteLine("PRIVILEGIOS: agregar Insumo");
      return _canKeep;
    }

    [Command(UseCommandManager = false)]
    public void Save_Exit()
    {
      throw new NotImplementedException();
    }

    public bool CanSave_Exit()
    {
      Debug.WriteLine("PRIVILEGIOS: modificar Insumo");
      return true;
    }

    [Command(UseCommandManager = false)]
    public void Cancel()
    {
      throw new NotImplementedException();
    }

    public bool CanCancel()
    {
      return true;
    }

    #endregion
  }
}
