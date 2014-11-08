using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura
{
  /// <summary>
  /// SINGLETON
  /// Esta clase contiene propiedades que serán comunes para toda la aplicación, no importa el usuario que este autenticado
  /// o bien que no haya ningun usuario autenticado
  /// </summary>
  public class Contexto
  {
    private static readonly Contexto _contexto;

    /// <summary>
    /// Retorna una referencia al Contexto actual y UNICO de la aplicacion
    /// </summary>
    public static Contexto Current { get { return _contexto; } }

    static Contexto()
    {
      _contexto = new Contexto();
    }

    private Contexto()
    {
      Sesion = null;
    }

    //  Propiedades publicas DE LA INSTANCIA
    public Sesion Sesion { get; set; }

    public void InvalidateSesion()
    {
      this.Sesion = null;
    }
  }
}
