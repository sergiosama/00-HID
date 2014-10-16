using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
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

      if (oldVista is INavigableView)
      {
        //  avisar para que
        //  - GUARDE LA VISTA ACTUAL (y la pueda recuperar cuando se active nuevamente)
        //  - desconecte la workview del espacio reservado para contenido
        ((INavigableView)oldVista).UnsetContainer();
      }

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
          rib.BindEvents(ribMain);
          rib.FocusOnPage(ribMain);
        }
        //  cambiar titulo de barra segun la vista!!
        //  CONECTAR A SEARCH CONTROL!!
      }
    }

    private void CambioPagina_Principal(object sender, EventArgs e)
    {
      //  aca deberia haber un chequeo si la vista que esta activa DEJA que esto ocurra
      //  de no ser asi puede forzarse mediante reingreso de credenciales?
      //
      Debug.WriteLine("Cambio de pagina principal...");
      
      RibbonControl rib = sender as RibbonControl;
      ViewType vtTag;

      Debug.Write("Cambio de pagina merged");
      //  se produce cuando cambio de pagina en ribbon => hay que cambiar de vista de trabajo
      string nombreVista = rib.SelectedPage.Tag as string;

      //  chequear si el tag no corresponde, tendriamos que avisar a la vista principal (no es necesario porque el evento tambien lo recibe 
      //  la vista principal)
      //  TODO Validar que si ya es START, no se cambia de nuevo la vista...
      if (nombreVista == "START")
        _vm.SelectedViewType = ViewType.StartMenu;

      //  _viewModel.SetCurrentWorkViewType((ViewType)Enum.Parse(typeof(ViewType), nombreVista));
    }
  
  }
}