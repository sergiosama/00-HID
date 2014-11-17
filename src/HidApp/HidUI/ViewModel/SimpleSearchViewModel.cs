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
using Servicios.Finders;

namespace HidUI.ViewModel
{
  //  TODO no deberia ser generico este en lugar del formulario? O quizas ambos...
  //  
  public class SimpleSearchViewModel : ViewModelBase
  {

    //  public event EventHandler ViewMustClose;
    //  public event EventHandler<IList<HidErrorInfo>> ViewHasErrors;

    public SimpleSearchViewModel()
    {
    }

    #region Comandos

    [Command(UseCommandManager = false)]
    public void Search()
    {
      SearchProveedores srch = new SearchProveedores();

      //  srch.FindByText();
    }

    public bool CanSearch()
    {
      return true;
    }


    #endregion

  }
}
