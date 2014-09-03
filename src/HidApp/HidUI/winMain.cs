using System;
using System.Diagnostics;
using System.Windows.Forms;
using DevExpress.Mvvm.POCO;
using HidUI.Common;
using HidUI.ViewModel;
using HidUI.Views;
using Infraestructura;

namespace HidUI
{
  public partial class winMain : DevExpress.XtraBars.Ribbon.RibbonForm
  {
    private readonly MainViewModel _viewModel;

    public winMain()
    {
      Helpers.MainForm = this;
      InitializeComponent();

      _viewModel = ViewModelSource.Create(() => new MainViewModel(new Localizador()));    //  usar un registro para obtener el localizador (no crear dependencia)

      _viewModel.ViewAdded += ViewModelOnViewAdded;
      _viewModel.ViewRemoved += ViewModelOnViewRemoved;
      _viewModel.BindingChanged += ViewModelOnBindingChanged;
      BindCommands();
    }

    /// <summary>
    /// Usamos por ahora para "simular" un login exitoso
    /// </summary>
    /// <param name="e"></param>
    protected override void OnLoad(EventArgs e)
    {
      base.OnLoad(e);

      _viewModel.TryLogin();
    }

    private void ViewModelOnViewRemoved(object sender, EventArgs eventArgs)
    {
      var oldVista = sender as Control;

      if (oldVista is ISupportRibbon)
      {
        ribMain.UnMergeRibbon();
      }
      oldVista.Parent = null;
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
        nuevaVista.Parent = pnlContainer;
        if (nuevaVista is ISupportRibbon)
        {
          ISupportRibbon rib = nuevaVista as ISupportRibbon;

          ribMain.MergeRibbon(rib.Ribbon);
          rib.FocusOnPage(ribMain);
        }
        //  cambiar titulo de barra segun la vista!!
      }
    }

    private void ViewModelOnBindingChanged(object sender, EventArgs e)
    {
      if (Contexto.Current.Sesion != null)
        barUserName.Caption = Contexto.Current.Sesion.FullName;
    }

    private void BindCommands()
    {
      bbiLogin.BindCommand(() => _viewModel.Login(), _viewModel);
      bbiLogout.BindCommand(() => _viewModel.Logout(), _viewModel);
      bbiAbout.BindCommand(() => _viewModel.About(), _viewModel);
    }

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

    public MainViewModel MainViewModel { get { return _viewModel;  } }
  }
}
