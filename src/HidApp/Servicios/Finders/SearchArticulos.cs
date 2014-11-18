using System;
using Entidades;

namespace Servicios.Finders
{
  public class SearchArticulos : IFinder<enTArticulo>
  {
    public enTArticulo FindByText(string text)
    {
      throw new NotImplementedException();
    }

    public string Descripcion
    {
      get { return @"Busqueda de articulos..."; }
      set { throw new NotSupportedException("Metodo set no soportado para propiedad SearchProveedores.Descripcion"); }
    }
  }
}
