using System.Runtime.Remoting.Contexts;
using Infraestructura;

namespace HidUI.ViewModel
{
  public class LoginViewModel
  {
    /// <summary>
    /// Ajusta la nueva sesión en el sistema en base a lo que me retorna el login
    /// </summary>
    /// <param name="newSes"></param>
    public void SetSesion(Sesion newSes)
    {
      //  Ubicar en el contexto
      Contexto.Current.Sesion = newSes;
    }
  }
}
