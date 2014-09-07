﻿using System;
using System.Diagnostics;
using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using HidUI.Common;
using HidUI.Views;
using Infraestructura;

namespace HidUI.ViewModel
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
    public event EventHandler BindingChanged;

    #endregion


    #region Comandos

    [Command(UseCommandManager = false)]
    public void Login()
    {
      TryLogin();
    }

    public bool CanLogin()
    {
      return Contexto.Current.Sesion == null;
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
    /// PSEUDO COMMAND
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

    /// <summary>
    /// PSEUDO COMMAND
    /// Se recibe desde el StartViewModel (navegador)
    /// </summary>
    public void NavigateTo(ViewType newViewType)
    {
      //  algo distinto deberia hacer.... por ejemplo guardar el estado...
      SelectedViewType = newViewType;
    }

    #endregion

    public void TryLogin()
    {
      if (Contexto.Current.Sesion == null)
      {
        //  a loguearse!!!
        winLogin login = new winLogin();

        login.ShowDialog();
        if (Contexto.Current.Sesion != null)
        {
          if (BindingChanged != null)
            BindingChanged(this, null);
          SelectedViewType = ViewType.StartMenu;
        }
      }
    }

    protected void OnSelectedViewTypeChanged(ViewType oldType)
    {
      Debug.WriteLine("OnSelectedViewTypeChanged: oldType = {0}", oldType);

      SelectedView = _locator.GetView(SelectedViewType);
      //  RaiseSelectedViewTypeChanged()

      //  esto es mio... si soporta vista anterior, coloco oldView para que quede registro de donde tiene que volver
      if (SelectedView is ISupportPreviousView)
        ((ISupportPreviousView)SelectedView).PreviousView = oldType;

      //  esto tambien es mio... si la vista es tipo navegador, los eventos de navegación deberian replicarse en 
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