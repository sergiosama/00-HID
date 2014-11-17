using System;
using System.Diagnostics;
using System.Windows.Forms;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using DevExpress.Utils;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using HidUI.Common;
using HidUI.ViewModel;
using HidUI.Views;
using Infraestructura;

namespace HidUI
{
  public partial class winMain : DevExpress.XtraBars.Ribbon.RibbonForm
  {
    private readonly MainViewModel _viewModel;
    //  private IViewLocator _localizador;

    public winMain()
    {
      Helpers.MainForm = this;
      //
      //  Inicializa las vistas
      ViewManager.Current.AddView(ViewType.Stock, null, StockView.RegisterViews);

      InitializeComponent();

      //  usar un registro para obtener el localizador (no crear dependencia)
      _viewModel = ViewModelSource.Create(() => new MainViewModel(new Localizador()));    

      ServiceContainer.Default.RegisterService(new LoginService());

      _viewModel.ViewAdded += ViewModelOnViewAdded;
      _viewModel.ViewRemoved += ViewModelOnViewRemoved;
      BindCommands();

      //simpleButton1.BindCommand(() => _viewModel.TestBoton(), _viewModel);

      //  binding trucho temporal hasta que el bar button item soporte binding (14.1.7)
      txtHidden.DataBindings.Add(new Binding("Text", _viewModel, "FullName"));
    }

    #region Propiedades

    public MainViewModel MainViewModel { get { return _viewModel; } }

    /// <summary>
    /// El area principal de contenido que dispone la ventana de la aplicacion para ubicar cualquier vista
    /// </summary>
    public Control Content
    {
      get { return mainContent; }
    }

    /// <summary>
    /// Referencia al control de busqueda
    /// </summary>
    public SearchControl Search
    {
      get
      {
        return mainSearch;
      }
    }

#endregion


    /// <summary>
    /// Usamos por ahora para "simular" un login exitoso
    /// </summary>
    /// <param name="e"></param>
    protected override void OnLoad(EventArgs e)
    {
      base.OnLoad(e);

      _viewModel.TryLogin();
    }

    private void BindCommands()
    {
      bbiLogin.BindCommand(() => _viewModel.Login(), _viewModel);
      bbiLogout.BindCommand(() => _viewModel.Logout(), _viewModel);
      bbiAbout.BindCommand(() => _viewModel.About(), _viewModel);
      bbUserConnected.BindCommand(() => _viewModel.UserInfo(), _viewModel);

      //  textEdit1.DataBindings.Add(new Binding("Text", _viewModel, "Texto"));
    }


    #region ViewModel Event Handlers

    private void ViewModelOnViewRemoved(object sender, EventArgs eventArgs)
    {
      var oldVista = sender as Control;

      if (oldVista is INavigableView)
      {
        //  avisar para que
        //  - GUARDE LA VISTA ACTUAL (y la pueda recuperar cuando se active nuevamente)
        //  - desconecte la workview del espacio reservado para contenido
        ((INavigableView)oldVista).UnsetContainer();
        //  TODO llamar a SaveVisualState()
      }

      oldVista.Parent = null;

      if (oldVista is ISupportRibbon || oldVista is IWorkView)
      {
        ribMain.UnMergeRibbon();
      }
    }

    /// <summary>
    /// El ViewModel informa a la vista principal que OTRA vista fue elegida
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="eventArgs"></param>
    private void ViewModelOnViewAdded(object sender, EventArgs eventArgs)
    {
      var nuevaVista = sender as Control;

      if (nuevaVista != null)
      {
        nuevaVista.Dock = DockStyle.Fill;

        if (nuevaVista is INavigableView)
        {
          //  Si la vista que se agrega es navegable, le informo cual es el contenedor que puede utilizar para las vistas de trabajo
          //
          ((INavigableView) nuevaVista).SetContainer(mainContent);
          //  TODO pensar si no hay que llamar a RestoreVisualState() Que pasaria si la vista no tiene ribbon??
        }
        else
        {
          //  Si es una vista comun, seteo el Parent para que aparezca en el area de contenidos
          //
          nuevaVista.Parent = mainContent;  //  con esto evito el BringToFront()
        }

        if (nuevaVista is ISupportRibbon)
        {
          //  Si soporta ribbon, hago el merge del ribbon de la vista con el principal
          //  BindEvents() --> le da lugar a nuevaVista de enlazar los eventos que necesite para manejar los cambios de pagina del ribbon
          //  FocusOnPage() --> le permite a nuevaVista mostrar una determinada pagina del ribbon
          //
          ISupportRibbon rib = nuevaVista as ISupportRibbon;

          ribMain.MergeRibbon(rib.Ribbon);
          rib.SetMainRibbon(ribMain);
          rib.BindEvents();
          rib.FocusOnPage();
        }
        //  cambiar titulo de barra segun la vista!!
        //  CONECTAR A SEARCH CONTROL!!
      }
    }

    #endregion

    #region Event Handlers

    private void Ribbon_CambiarPagina(object sender, EventArgs e)
    {
      //  chequear qué pagina activo, ajustar el view model y el view que debo colocar
      //  "descargar" los modelos anteriores
      //  OJO porque hay varios comportamientos posibles
      //  - si el cambio de pagina no implica una nueva vista
      //  - si el cambio de pagina implica una nueva vista que reemplaza a la actual
      //  
      Debug.WriteLine("frmMain: Cambio de Pagina");

      //  aca deberia haber un chequeo si la vista que esta activa DEJA que esto ocurra
      //  de no ser asi puede forzarse mediante reingreso de credenciales?
      //
      //  TODO Chequear que la vista activa permite ser removida
      //
      RibbonControl rib = sender as RibbonControl;
      ViewType vtTag;

      //  se produce cuando cambio de pagina en ribbon => hay que cambiar de vista de trabajo
      string nombreVista = rib.SelectedPage.Tag as string;

      Debug.WriteLine(string.Format("Cambio de pagina MAIN destino --> {0}", rib.SelectedPage.Text));

      //  chequear si el tag no corresponde, tendriamos que avisar a la vista principal (no es necesario porque el evento tambien lo recibe 
      //  la vista principal)
      //  TODO Validar que si ya es START, no se cambia de nuevo la vista...normalmente solamente una ribbon page estaria asociada a START pero quien dice

      if (nombreVista == null)
      {
        //  significa que el usuario no esta logueado...
        //
        _viewModel.SelectedViewType = ViewType.Ninguno;
      }
      else
      {
        if (nombreVista == "START")
          _viewModel.SelectedViewType = ViewType.StartMenu;
      }

      //  _viewModel.SetCurrentWorkViewType((ViewType)Enum.Parse(typeof(ViewType), nombreVista));
    }

    private void GrupoClick(object sender, DevExpress.XtraBars.Ribbon.RibbonPageGroupEventArgs e)
    {
      Debug.WriteLine("frmMain: Click en Grupo");
    }

    //  Manejo del evento VerPerfil del control de usuario UserInfoView
    private void ViewPerfilUsuario(object sender, EventArgs e)
    {
      MessageBox.Show("No implementado...");
      ppUserInfo.HidePopup();
    }

    //  Manejo del evento Popup de ETPopupControlContainer (contenedor que tiene el UserInfoView)
    private void UserInfo_Popup(object sender, EventArgs e)
    {
      //  Debug.WriteLine("POPUP!!");
      usrInfo.RefreshUserInfo();
    }

    //  Cuando cambia el texto del textbox hidden, ocurre esto...
    //  Admito que es una chanchada
    //  Maneja evento TextChanged de txtHidden
    //  Ocurre cuando el usuario se loguea/desloguea
    private void CambiarBinding(object sender, EventArgs e)
    {
      if (string.IsNullOrWhiteSpace(txtHidden.Text))
      {
        bbUserConnected.Caption = "<Desconectado>";
        bbUserConnected.Glyph = null;
        bbUserConnected.SuperTip = null;
        rbpgInicio.Tag = null;
      }
      else
      {
        bbUserConnected.Glyph = HidUI.Properties.Resources.administrator_48;
        bbUserConnected.Caption = txtHidden.Text;
        bbUserConnected.SuperTip = new SuperToolTip();
        bbUserConnected.SuperTip.Items.AddTitle("Usuario actualmente conectado");
        bbUserConnected.SuperTip.Items.Add("Presione para ver informacion del usuario actual y tiempos de conexion");
        rbpgInicio.Tag = "START";
      }
    }

    #endregion
  }
}
