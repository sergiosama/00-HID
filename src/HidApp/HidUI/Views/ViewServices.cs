using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Mvvm;
using Entidades;
using HidUI.Common;

namespace HidUI.Views
{
  public class LoginService : ILoginService
  {
    public void Show()
    {
      winLogin login = new winLogin();
      login.ShowDialog();
    }
  }

  public class DlgEditProveedoresService : IFormEditService<Proveedor>
  {
    public DlgEditProveedoresService()
    {
      ViewModel = null;
    }

    public FormEditResult Run(FormEditAction action)
    {
      //  necesitara alguna vez un view model inyectado en el ctor?? ==> parece que si!
      winProveedores editProveedores = new winProveedores(ViewModel, action); 

      DialogResult res = editProveedores.ShowDialog();

      return res == DialogResult.Cancel ? FormEditResult.Cancelado : FormEditResult.Modificado;
    }

    public IFormEditViewModel<Proveedor> ViewModel { get; set; }
  }

  public class DlgEditAlquilablesService : IFormEditService<enTArticulo>
  {
    public FormEditResult Run(FormEditAction action)
    {
      throw new NotImplementedException();
    }

    public IFormEditViewModel<enTArticulo> ViewModel { get; set; }
  }

  //  TODO Atento TURKO
  //  public class PopEditProveedoresService : IForm...
  //  pero internamente usa un popupcontrol
  //

  public class SearchEntityService<T> : IFormSearchService<T> where T: class 
  {
    public T Show()
    {
      winSimpleSearch<T> search = new winSimpleSearch<T>();

      search.ShowDialog();
      return search.Resultado;
    }
  }
}
