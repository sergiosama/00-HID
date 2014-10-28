using System;
using System.Diagnostics;
using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using Entidades;
using Infraestructura;
using Servicios;

namespace WinTestEF.ViewModel
{
  public class MainViewModel : ViewModelBase
  {
    //private ViewType _selectedViewType;
    //private object _selectedView;
    //private string _texto;
    private readonly IViewLocator _locator;

    public MainViewModel(IViewLocator locator)
    {
      _locator = locator;
      FullName = null;
    }

    public virtual ViewType SelectedViewType { get; set; }

    public virtual object SelectedView { get; set; }

    /// <summary>
    /// Propiedad que utilizo para enlazar con un textbox oculto y asi poder obtener el valor que mostraria en el BarButtonItem
    /// </summary>
    public virtual string FullName { get; set; }

    #region Eventos para avisar a la View

    public event EventHandler ViewAdded;
    public event EventHandler ViewRemoved;
    public event EventHandler SelectedViewChanged;
    public event EventHandler SelectedViewTypeChanged;
    /// <summary>
    /// Evento necesario para tratar con cambios que no puedan asociarse con Comandos
    /// </summary>
    public event EventHandler UserConnectedChanged;

    #endregion


    #region Comandos

    [Command(UseCommandManager = false)]
    public void Login()
    {
      TryLogin();
    }

    public bool CanLogin()
    {
      return true;
    }

    [Command(UseCommandManager = false)]
    public void About()
    {
      Debug.WriteLine("Mostrar modulo de about");
      SelectView(ViewType.About);
    }

    public bool CanAbout()
    {
      return true;
    }

    [Command(UseCommandManager = false)]
    public void Vista_1()
    {
      SelectView(ViewType.Vista_1);
    }

    public bool CanVista_1()
    {
      return true;
    }

    [Command(UseCommandManager = false)]
    public void Logout()
    {
      SecurityServices security = new SecurityServices();
      
      security.LogoutUser();
      //  Debug.WriteLine("Realizar logout del usuario");

      if (Contexto.Current.Sesion == null)
      {
        this.RaiseCanExecuteChanged(x => x.Logout());
        this.RaiseCanExecuteChanged(x => x.Login());
        this.RaiseCanExecuteChanged(x => x.UserInfo());

        SelectedViewType = ViewType.Ninguno;
        //  Esto anda!!
        FullName = null;
      }
    }

    public bool CanLogout()
    {
      return Contexto.Current.Sesion != null;
    }

    [Command(UseCommandManager = false)]
    public void UserInfo()
    {
      //  No hago nada...
    }

    public bool CanUserInfo()
    {
      return Contexto.Current.Sesion != null;
    }

    /// <summary>
    /// Permite seleccionar una vista en base al tipo de la misma
    /// </summary>
    /// <param name="viewType"></param>
    private void SelectView(ViewType viewType)
    {
      SelectedViewType = viewType;
    }

    /// <summary>
    /// [[PSEUDO COMMAND]]
    /// Cierra la unica vista que puede estar abierta (la SelectedView)
    /// Si no hay ninguna, no hace nada...
    /// Si SelectedView soporta vista anterior, cambia la vista actual por la previa
    /// Si no soporta vista anterior, deja la vista por defecto
    /// </summary>
    public void CloseView()
    {
      //  intenta cerrar la vista actual, volviendo a la previa...
      if (SelectedView != null)
      {
        if (SelectedView is ISupportPreviousView)
        {
          ViewType previousViewType;

          previousViewType = ((ISupportPreviousView) SelectedView).PreviousViewType;
          SelectedViewType = previousViewType;
        }
        else
        {
          //  si no hay vista previa, colocar tipo de vista por defecto
          SelectedViewType = Helpers.DefaultViewType;
        }
      }
    }

    /// <summary>
    /// [[PSEUDO COMMAND]]
    /// Se recibe desde el StartViewModel (navegador)
    /// </summary>
    public void NavigateTo(ViewType newViewType)
    {
      //  algo distinto deberia hacer.... por ejemplo guardar el estado...
      SelectedViewType = newViewType;
    }

    /// <summary>
    /// [[PSEUDO COMMAND]]
    /// 
    /// Aca iria el comando que prueba pasar a una vista en base a una busqueda
    /// Como la vista necesita otra primero (parent) carga la parent y a continuacion la final
    /// 
    /// </summary>
    public void DummyNavigate()
    {
      throw new ApplicationException("Dummy Navigate: No implementado!!");
    }

    #endregion

/*
 *  Si quiero usar esta construccion, la descomento y dejo de usar la var local loginService en TryLogin
    [ServiceProperty]
    public virtual ILoginService LoginService
    {
      get { throw new NotImplementedException(); }
    }
*/

    public void TryLogin()
    {
      if (Contexto.Current.Sesion == null)
      {
        //  a loguearse!!!
//        winLogin login = new winLogin();
//
//        login.ShowDialog();
        //  Usamos loginService para logearnos...
        var loginService = GetService<ILoginService>();

        loginService.Show();

        if (Contexto.Current.Sesion != null)
        {
          this.RaiseCanExecuteChanged(x => x.Logout());
          this.RaiseCanExecuteChanged(x => x.Login());
          this.RaiseCanExecuteChanged(x => x.UserInfo());

          //  IT WORKS!!!
          enTRecurso recurso = Contexto.Current.Sesion.Usuario.Recurso;

          FullName = string.Format("{0} {1}", recurso.Nombre, recurso.Apellido);
          //if (BindingChanged != null)
          //  BindingChanged(this, null);
          SelectedViewType = ViewType.StartMenu;
        }
      }
    }

    protected void OnSelectedViewTypeChanged(ViewType oldType)
    {
      Debug.WriteLine("OnSelectedViewTypeChanged: oldType = {0}", oldType);

      //  aca tenemos que ver si la vista en realidad necesita otra...
      //  lo tiene que decidir el locator
      SelectedView = _locator.GetView(SelectedViewType);
      //  RaiseSelectedViewTypeChanged()

      //  esto es mio... si soporta vista anterior, coloco oldView para que quede registrado donde tiene que volver
      if (SelectedView is ISupportPreviousView)
        ((ISupportPreviousView)SelectedView).PreviousViewType = oldType;

      //  esto tambien es mio... si la vista es tipo navegador, los eventos de navegación deberian replicarse ....
    }

    protected void OnSelectedViewChanged(object oldView)
    {
      //  doy aviso a la vista que elimine o haga lo que quiera con la vista previa
      //  OJO: es solamente un remove VISUAL, si quisiera hacer algo para guardar el estado deberia hacerlo en el logout
      //
      if (oldView != null)
      {
        if (ViewRemoved != null)
          ViewRemoved(oldView, EventArgs.Empty);
      }
      //  deberia asegurarme que la view tenga la parent view correcta si le hace falta
      //  y que reciba los parametros necesarios
      //  Eso es lo que hace ViewModelHelper...

      //  por ultimo avisar a la vista principal que hay una nueva vista agregada...
      //  esto es lo que realmente la muestra!!
      if (ViewAdded != null)
        ViewAdded(SelectedView, EventArgs.Empty);
    }

    public void SetDefaultView()
    {
      SelectedViewType = ViewType.StartMenu;
    }
  }
}
