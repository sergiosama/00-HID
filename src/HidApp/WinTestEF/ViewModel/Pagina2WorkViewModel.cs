using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.XtraEditors.Design;

namespace WinTestEF.ViewModel
{
  public class Pagina2WorkViewModel : ViewModelBase, IWorkViewModel
  {
    #region Comandos Work Views

    [Command(UseCommandManager = false)]
    public void Comando_Procesar2()
    {
      Debug.WriteLine("Procesar 2 Ejecutado!!");
    }

    public bool CanComando_Procesar2()
    {
      return true;
    }

    #endregion

    public Expression<Action> GetActionFromName(string name)
    {
      if (name == "Procesar2")
        return () => this.Comando_Procesar2();
      return null;
    }
  }
}
