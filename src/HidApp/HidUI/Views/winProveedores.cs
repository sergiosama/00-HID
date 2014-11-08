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
using DevExpress.XtraEditors;
using HidUI.Common;
using HidUI.ViewModel;
using Infraestructura;

namespace HidUI.Views
{
  /// <summary>
  /// Formulario de edicio para Proveedores. Sirve para crear uno nuevo o para modificar
  /// </summary>
  public partial class winProveedores : DevExpress.XtraEditors.XtraForm
  {
    private ProveedoresViewModel _vm;
    private FormEditAction _action;

    public winProveedores(ViewModelBase vm, FormEditAction action)
    {
      InitializeComponent();

      _action = action;

      _vm = vm as ProveedoresViewModel;

      _vm.ViewMustClose += CloseEvent;
      _vm.ViewHasErrors += ErrorEvent;

      BindCommands();

      BindControls();
    }

    #region Event Handlers

    private void CloseEvent(object sender, EventArgs args)
    {
      this.Close();
    }

    private void ErrorEvent(object sender, IList<HidErrorInfo> args)
    {
      StringBuilder sb = new StringBuilder();

      foreach (var err in args)
        sb.AppendLine(err.Descripcion);

      MessageBox.Show(sb.ToString(), "ERROR EN EL INGRESO DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

    #endregion

    private void BindCommands()
    {
      btnCancelar.BindCommand(() => _vm.Cancelar(), _vm);

      //  dependiendo si edito o agrego nuevo, los bindings son diferentes
      if (_action == FormEditAction.EditarNuevo)
      {
        btnDoAndKeep.Enabled = true;
        btnDoAndExit.BindCommand(() => _vm.Add_Exit(), _vm);
        btnDoAndKeep.BindCommand(() => _vm.Add_Keep(), _vm);
        btnDoAndExit.Text = "Agrega y Sale";
      }
      else
      {
        btnDoAndExit.BindCommand(() => _vm.Save_Exit(), _vm);
        btnDoAndKeep.Enabled = false;
        btnDoAndExit.Text = "Guarda y Sale";
      }
    }

    private void BindControls()
    {
      txtNombre.DataBindings.Add(new Binding("Text", _vm, "Current.Nombre"));
      txtDireccion.DataBindings.Add(new Binding("Text", _vm, "Current.Direccion"));
      txtCUIT.DataBindings.Add(new Binding("Text", _vm, "Current.CUIT"));
      chkHabilitado.DataBindings.Add(new Binding("Checked", _vm, "Current.Habilitado"));
    }

    private void Botones_OnClick(object sender, EventArgs e)
    {
      txtNombre.Focus();
    }
  }
}