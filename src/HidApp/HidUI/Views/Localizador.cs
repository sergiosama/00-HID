using System.Collections.Generic;
using HidUI.Common;

namespace HidUI.Views
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

      if (!_viewsCache.TryGetValue(viewType, out result))
      {
        switch (viewType)
        {
          case ViewType.StartMenu:
            result = new StartView();
            break;

          case ViewType.About:
            result = new AboutView();
            break;

          case ViewType.Stock:
            result = new StockView(this);   //  WARNING!!!
            break;

          case ViewType.StockInsumos:
            result = new StockInsumosView();
            break;
        }
        _viewsCache.Add(viewType, result);
      }
      return result;
    }

    //  chequear el arbol de vistas, ver si es necesario activar primero una vista parent (podria haber mas de una??)
  }
}
