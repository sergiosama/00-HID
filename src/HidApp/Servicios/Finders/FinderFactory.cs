using System;
using Entidades;
using Infraestructura;

namespace Servicios.Finders
{
  public interface IFinder<out T> 
  {
    T FindByText(string text);

    //  TODO incorporar helper para mostrar tooltip en la UI 
    //  TODO Si no que hacer? Otro servicio mas cercano a la UI que me diga las reglas de busqueda??
    //  TODO Encadenar o asociar finders? Como hacer que se busque en toda la aplicacion?
    /// <summary>
    /// Retorna una cadena (opcional) que describe el uso del buscador (reglas, etc...)
    /// </summary>
    string Descripcion { get; set; }
  }

  public class FinderFactory
  {
    public static IFinder<T> CreateFinder<T>()
    {
      Type tipo = typeof (T);
      
      if (tipo == typeof(Proveedor))
        return (IFinder<T>) new SearchProveedores();

      if (tipo == typeof(enTArticulo))
        return (IFinder<T>)new SearchArticulos();

      throw new HidBadOperationException(string.Format("No existe un proveedor de busqueda para el tipo {0}", tipo.Name));
    }
  }
}