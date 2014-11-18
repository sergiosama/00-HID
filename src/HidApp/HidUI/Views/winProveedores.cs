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
using Entidades;
using HidUI.Common;
using HidUI.ViewModel;
using Infraestructura;

namespace HidUI.Views
{
  /// <summary>
  /// Formulario de edicion para Proveedores. Sirve para crear uno nuevo o para modificar
  /// </summary>
  public partial class winProveedores : DevExpress.XtraEditors.XtraForm
  {
    public winProveedores(IFormEditViewModel<Proveedor> vm, FormEditAction action)
    {
      InitializeComponent();
      //
      ctlEditProveedor.Action = action;
      ctlEditProveedor.SetViewModel(vm);
    }

    private void Cerrar_Dialogo(object sender, EventArgs e)
    {
      this.Close();
    }
  }
}