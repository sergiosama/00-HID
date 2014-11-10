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
using Entidades;
using HidUI.ViewModel;
using HidUI.Views;
using Infraestructura;

namespace HidUI
{
  public partial class winTestUI : DevExpress.XtraBars.Ribbon.RibbonForm
  {
    private TestUIViewModel _vm;

    public winTestUI()
    {
      InitializeComponent();
      _vm = ViewModelSource.Create(() => new TestUIViewModel());

      //  Acá es donde digo que servicios CONCRETOS va a utilizar esta vista...
      ServiceContainer.Default.RegisterService(new EditProveedoresService());
      ServiceContainer.Default.RegisterService(new SearchEntityService<Proveedor>());

      BindCommands();
    }

    protected override void OnLoad(EventArgs e)
    {
      base.OnLoad(e);
      btxtUsuario.Caption = Contexto.Current.Sesion.FullName;
    }

    private void BindCommands()
    {
      bbnNuevoProveedor.BindCommand(() => _vm.NewProveedor(), _vm);
      bbnEditProvedor.BindCommand(() => _vm.EditProveedor(), _vm);
      bbnBuscarProveedor.BindCommand(() => _vm.BuscarProveedor(), _vm);
    }
  }
}