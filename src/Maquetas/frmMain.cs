using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.Mvvm.POCO;
using Maquetas.Common;
using Maquetas.ViewModel;
using Maquetas.Views;

namespace Maquetas
{
  public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
  {
    private readonly MainViewModel _viewModel;
    public frmMain()
    {
      Helpers.MainForm = this;
      InitializeComponent();

      _viewModel = ViewModelSource.Create(() => new MainViewModel(new Localizador()));

      _viewModel.ViewAdded += ViewModelOnViewAdded;
      _viewModel.ViewRemoved += ViewModelOnViewRemoved;
      BindCommands();
    }

    private void ViewModelOnViewRemoved(object sender, EventArgs eventArgs)
    {
      var oldVista = sender as Control;

      if (oldVista is ISupportRibbon)
      {
        ribbonControl1.UnMergeRibbon();
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

          ribbonControl1.MergeRibbon(rib.Ribbon);
          rib.FocusOnPage(ribbonControl1);
        }
      }
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
