using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ViewType = HidUI.Common.ViewType;

namespace HidUI.Views
{
  /// <summary>
  /// [[SINGLETON]]
  /// Permite administrar el arbol de vistas de la aplicacion
  /// </summary>
  public class ViewManager
  {
    private static ViewManager _current;

    static ViewManager()
    {
      _current = new ViewManager();
    }

    public static ViewManager Current { get { return _current; } }

    public void AddView(ViewType vt, ViewType? vtParent, Action regSubviews)
    { 
      //  ver como armar el arbol de vistas...
      if (regSubviews != null)
        regSubviews();
    }
  }
}
