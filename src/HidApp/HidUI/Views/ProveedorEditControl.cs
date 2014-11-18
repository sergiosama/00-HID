using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Entidades;
using HidUI.Common;
using HidUI.ViewModel;
using Infraestructura;

namespace HidUI.Views
{
  public partial class ProveedorEditControl : DevExpress.XtraEditors.XtraUserControl, IFormEditView<Proveedor>
  {
    private ProveedoresViewModel _vm;

    public ProveedorEditControl()
    {
      InitializeComponent();
    }

    private void BindCommands()
    {
      btnCancelar.BindCommand(() => _vm.Cancel(), _vm);

      //  dependiendo si edito o agrego nuevo, los bindings son diferentes
      if (Action == FormEditAction.EditarNuevo)
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

    protected override bool ProcessKeyPreview(ref Message m)
    {
      //  Chequear primero que el tipo de mensaje sea WM_KEYDOWN para que no lo procese otra vez en el key up
      //  Ref: http://msdn.microsoft.com/en-us/library/windows/desktop/ms646280%28v=vs.85%29.aspx
      //
      if (m.Msg == 256)
      {
        if ((Keys)m.WParam == Keys.Enter)
        {
          btnDoAndExit.PerformClick();
          return true;
        }
        if ((Keys)m.WParam == Keys.Escape)
        {
          btnCancelar.PerformClick();
          return true;
        }
      }
      return base.ProcessKeyPreview(ref m);
    }

    #region Event Handlers

    private void CloseEvent(object sender, EventArgs args)
    {
      if (CloseView != null)
        CloseView(this, null);
    }

    private void ErrorEvent(object sender, IList<HidErrorInfo> args)
    {
      StringBuilder sb = new StringBuilder();

      foreach (var err in args)
        sb.AppendLine(err.Descripcion);

      MessageBox.Show(sb.ToString(), "ERROR EN EL INGRESO DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

    private void Botones_OnClick(object sender, EventArgs e)
    {
      txtNombre.Focus();
    }

    #endregion

    public event EventHandler CloseView;

    public FormEditAction Action { get; set; }

    public void SetViewModel(IFormEditViewModel<Proveedor> vm)
    {
      _vm = vm as ProveedoresViewModel;
      
      _vm.ViewMustClose += CloseEvent;
      _vm.ViewHasErrors += ErrorEvent;

      BindCommands();

      BindControls();
    }
  }
}
