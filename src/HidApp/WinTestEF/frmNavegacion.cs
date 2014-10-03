using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using WinTestEF.View;
using WinTestEF.ViewModel;

namespace WinTestEF
{
  public partial class frmNavegacion : DevExpress.XtraBars.Ribbon.RibbonForm
  {
    private MainViewModel _vm ;

    public frmNavegacion()
    {
      Helpers.MainForm = this;

      InitializeComponent();
      _vm = ViewModelSource.Create<MainViewModel>(() => new MainViewModel(new Localizador()));
      
      //  bind eventos del VM
      _vm.ViewAdded += ViewModelOnViewAdded;
      _vm.ViewRemoved += ViewModelOnViewRemoved;

      //  bind comandos
      bbnVista1.BindCommand(() => _vm.Vista_1(), _vm);
      //  bind propiedades
    }

    protected override void OnLoad(EventArgs e)
    {
      base.OnLoad(e);

      //  Reemplaza a TryLogin()
      _vm.SetDefaultView();
    }

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

    public MainViewModel MainViewModel { get { return _vm; } }


    private void ViewModelOnViewRemoved(object sender, EventArgs eventArgs)
    {
      var oldVista = sender as Control;

      oldVista.Parent = null;

      if (oldVista is ISupportRibbon)
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
        nuevaVista.Parent = mainContent;
        if (nuevaVista is ISupportRibbon)
        {
          ISupportRibbon rib = nuevaVista as ISupportRibbon;

          ribMain.MergeRibbon(rib.Ribbon);
          rib.FocusOnPage(ribMain);
        }
        //  cambiar titulo de barra segun la vista!!
        //  CONECTAR A SEARCH CONTROL!!
      }
    }
  
  }
}