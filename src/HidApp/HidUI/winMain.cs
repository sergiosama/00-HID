using System;
using System.Diagnostics;
using System.Windows.Forms;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using DevExpress.Utils;
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
          ((INavigableView)nuevaVista).SetContainer(mainContent);
        }
        else
          nuevaVista.Parent = mainContent;  //  con esto evito el BringToFront()

        if (nuevaVista is ISupportRibbon)
        {
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
    private void CambiarBinding(object sender, EventArgs e)
    {
      if (string.IsNullOrWhiteSpace(txtHidden.Text))
      {
        bbUserConnected.Caption = "<Desconectado>";
        bbUserConnected.Glyph = null;
        bbUserConnected.SuperTip = null;
      }
      else
      {
        bbUserConnected.Glyph = HidUI.Properties.Resources.administrator_48;
        bbUserConnected.Caption = txtHidden.Text;
        bbUserConnected.SuperTip = new SuperToolTip();
        bbUserConnected.SuperTip.Items.AddTitle("Usuario actualmente conectado");
        bbUserConnected.SuperTip.Items.Add("Presione para ver informacion del usuario actual y tiempos de conexion");
      }
    }

    #endregion

  }
}
