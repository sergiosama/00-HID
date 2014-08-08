using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Maquetas.Common;


namespace Maquetas.Views
{
  public class Localizador : IViewLocator
  {
    private Dictionary<ViewType, object> _viewsCache;

    public Localizador()
    {
      _viewsCache = new Dictionary<ViewType, object>();

      _viewsCache.Add(ViewType.About, new AboutView());
    }

    public object GetView(ViewType viewType)
    {
      object result = null;

      if (viewType == ViewType.Ninguno)
        return null;

      result = _viewsCache[viewType];

      if (result == null)
      {
        switch (viewType)
        {
          case ViewType.About:
            result = new AboutView();
            break;
        }
        _viewsCache.Add(viewType, result);
      }
      return result;
    }
  }
}
