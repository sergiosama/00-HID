using System;
using System.Linq;
using System.Text.RegularExpressions;
using Data;
using Entidades;

namespace Servicios.Finders
{
  public class SearchProveedores : IFinder<Proveedor>
  {
    public Proveedor FindByText(string text)
    {
      //  podemos buscar por razon social o por CUIT o por ID...
      int id;
      HIDContext ctx = DB.Context;
      Proveedor result = null;

      //  Primero probamos por ID (numerico) siempre y cuando el texto esté acorde...
      //
      if (Int32.TryParse(text, out id))
        result = ctx.Proveedores.Find(id);

      //  Puede que por CUIT/Razon Social haya mas de una coincidencia...
      //  Nosotros ahora solo retornaremos la primera
      //
      if (result == null)
      {
        //  no se encontro por ID, probamos otras alternativas...
        //  por CUIT lo haremos si mas o menos coincide con la mascara (no tiene que ser identico)
        //  Exigimos como minimo 4 digitos numericos
        if (Regex.IsMatch(text, @"\d{4}"))
          result = ctx.Proveedores.FirstOrDefault(prov => prov.CUIT.Contains(text));    //  TODO transformar en coleccion
        
        if (result == null)
          result = ctx.Proveedores.FirstOrDefault(prov => prov.Nombre.Contains(text));
      }
      return result;
    }
  }
}
