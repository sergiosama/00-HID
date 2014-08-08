using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using Maquetas.Common;

namespace Maquetas.ViewModel
{
  public class MainViewModel : ViewModelBase
  {
    private ViewType _selectedViewType;
    private object _selectedView;
    private readonly IViewLocator _locator;

    public MainViewModel(IViewLocator locator)
    {
      _locator = locator;
    }

    public virtual ViewType SelectedViewType { get; set; }

    public virtual object SelectedView { get; set; }

    /*
        [BindableProperty(OnPropertyChangedMethodName = "OnSelectedViewTypeChanged")]
        public virtual ViewType SelectedViewType
        {
          get
          {
            Debug.WriteLine("get SelectedViewType");
            return _selectedViewType;
          }
          set
          {
            Debug.WriteLine("set SelectedViewType");
            _selectedViewType = value;
          }
        }

        public virtual object SelectedView
        {
          get
          {
            Debug.WriteLine("get SelectedView");
            return _selectedView;
          }
          set
          {
            Debug.WriteLine("set SelectedView");
            _selectedView = value;
          }
        }
    */

    #region Eventos para avisar a la View

    public event EventHandler ViewAdded;
    public event EventHandler ViewRemoved;
    public event EventHandler SelectedViewChanged;
    public event EventHandler SelectedViewTypeChanged;

    #endregion


    #region Comandos

    [Command(UseCommandManager = false)]
    public void Login()
    {
      Debug.WriteLine("Mostrar dialogo de login");
    }

    public bool CanLogin()
    {
      return false;
    }

    [Command(UseCommandManager = false)]
    public void About()
    {
      Debug.WriteLine("Mostrar modulo de about");
      SelectView(ViewType.About);
    }

    [Command(UseCommandManager = false)]
    public void Logout()
    {
      Debug.WriteLine("Realizar logout del usuario");
    }

    public bool CanLogout()
    {
      return true;
    }

    /// <summary>
    /// Permite seleccionar una vista en base al tipo de la misma
    /// </summary>
    /// <param name="viewType"></param>
    [Command(UseCommandManager = false)]
    public void SelectView(ViewType viewType)
    {
      SelectedViewType = viewType;
    }

    /// <summary>
    /// Cierra la unica vista que puede estar abierta (la SelectedView)
    /// Si no hay ninguna, no hace nada...
    /// Si SelectedView soporta vista anterior
    /// </summary>
    public void CloseView()
    {
      //  intenta cerrar la vista actual, volviendo a la previa...
      if (SelectedView != null)
      {
        if (SelectedView is ISupportPreviousView)
        {
          ViewType previousViewType;

          previousViewType = ((ISupportPreviousView)SelectedView).PreviousView;
          SelectedViewType = previousViewType;
        }
      }
    }

    #endregion

    protected void OnSelectedViewTypeChanged(ViewType oldType)
    {
      Debug.WriteLine("OnSelectedViewTypeChanged: oldType = {0}", oldType);

      SelectedView = _locator.GetView(SelectedViewType);
      //  RaiseSelectedViewTypeChanged()

      //  esto es mio... si soporta vista anterior, coloco oldView para que quede 
      if (SelectedView is ISupportPreviousView)
        ((ISupportPreviousView)SelectedView).PreviousView = oldType;
    }

    protected void OnSelectedViewChanged(object oldView)
    {
      //  doy aviso a la vista que elimine o haga lo que quiera con la vista previa
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
  }
}
