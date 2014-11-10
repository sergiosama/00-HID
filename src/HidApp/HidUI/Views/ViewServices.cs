using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Mvvm;
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

  public class EditProveedoresService : IFormEditService
  {
    public EditProveedoresService()
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

    public ViewModelBase ViewModel { get; set; }
  }

  public class EditAlquilablesService : IFormEditService
  {
    public FormEditResult Run(FormEditAction action)
    {
      throw new NotImplementedException();
    }

    public ViewModelBase ViewModel { get; set; }
  }

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
