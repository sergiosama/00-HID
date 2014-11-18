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
      ServiceContainer.Default.RegisterService(new DlgEditProveedoresService());
      ServiceContainer.Default.RegisterService(new SearchEntityService<Proveedor>());

      BindCommands();
    }

    protected override void OnLoad(EventArgs e)
    {
      base.OnLoad(e);
      //btxtUsuario.Caption = Contexto.Current.Sesion.FullName;
    }

    private void BindCommands()
    {
      bbnNuevoProveedor.BindCommand(() => _vm.NewProveedor(), _vm);
      bbnEditProvedor.BindCommand(() => _vm.EditProveedor(), _vm);
      bbnBuscarProveedor.BindCommand(() => _vm.BuscarProveedor(), _vm);
      //
      //  OJO!! Si estan invisibles no participan del binding!!! Dejarlos visibles y SendToBack
      //
      txtHidden.DataBindings.Add(new Binding("Text", _vm, "UserName"));
      txtHiddenSearch.DataBindings.Add(new Binding("Text", _vm, "SearchResult"));
    }

    private void Hidden_TextChanged(object sender, EventArgs e)
    {
      if (!string.IsNullOrWhiteSpace(txtHidden.Text))
        btxtUsuario.Caption = txtHidden.Text;

      if (!string.IsNullOrWhiteSpace(txtHiddenSearch.Text))
        btxtSearchResult.Caption = string.Format("Resultado > {0}", txtHiddenSearch.Text);
      else
        btxtSearchResult.Caption = "Resultado de la busqueda";
    }
  }
}