using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Infraestructura
{
  /// <summary>
  /// Representa toda la información que un usuario puede llegar a necesitar mientras este conectado trabajando con la aplicacion
  /// </summary>
  public class Sesion
  {
    //  TODO quitar Usuario del grafo de update en E-F ya que no se modifica mas
    public Usuario Usuario { get; set; }

    //  TODO cambiar por una estructura que retorne foto, last login, etc...para mostrar en una barra de estado
    public string FullName {
      get { return string.Format("{0} {1}", Usuario.Recurso.Nombre, Usuario.Recurso.Apellido); }
    }

    /// <summary>
    /// Obtiene una lista de posibles mensajes para el usuario
    /// Deberiamos cambiar string por otra clase para ver si el mensaje es mas o menos importante
    /// Por ahora pretendo que lo que salga de aca sea "la pass expira en N dias"
    /// </summary>
    /// <returns></returns>
    public IList<string> GetMessagesForUser()
    {
      return null;
    }
  }
}
