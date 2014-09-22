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
    public Sesion()
    {
      LastLogin = DateTime.Now;
    }

    //  TODO quitar Usuario del grafo de update en E-F ya que no se modifica mas
    //  Pero ojo cuando el usuario quiera cambiar su perfil porque en ese caso es necesario volver a meterlo en el grafo
    public Usuario Usuario { get; set; }

//    //  TODO cambiar por una estructura que retorne foto, last login, etc...para mostrar en una barra de estado
//    Eliminado 16/09/14 --> obtengo los datos desde el control UserinfoView
    public string FullName 
    {
      get { return string.Format("{0} {1}", Usuario.Recurso.Nombre, Usuario.Recurso.Apellido); }
    }

    public DateTime LastLogin { get; private set; }

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
