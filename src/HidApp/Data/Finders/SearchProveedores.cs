using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Data.Finders
{
  public interface IFinder<out T> 
  {
    T FindByText(string text);
  }

  public class SearchProveedores : IFinder<Proveedor>
  {
    public Proveedor FindByText(string text)
    {
      //  podemos buscar por razon social o por CUIT o por ID...
      //  por ahora solo por ID
      HIDContext ctx = DB.Context;
      int id;
      Proveedor result = null;

      if (Int32.TryParse(text, out id))
      {
        result = ctx.Proveedores.Find(id);
      }
      return result;
    }
  }

  public class FinderFactory
  {
    public static IFinder<T> CreateFinder<T>()
    {
      return (IFinder<T>) new SearchProveedores();
    }
  }
}
