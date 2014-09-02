using System;
using System.Windows.Forms;
using HidUI.ViewModel;
using Infraestructura;

namespace HidUI.Views
{
  public partial class winLogin : DevExpress.XtraEditors.XtraForm
  {
    private LoginViewModel viewModel;

    public winLogin()
    {
      InitializeComponent();
      //
      //this.KeyPreview = true;

      viewModel = new LoginViewModel();
      //
      loginIngreso.LoginOK += LoginCorrecto;
      loginIngreso.LoginIssues += FallasLogin;
    }

    private void LoginLoaded(object sender, EventArgs e)
    {
      loginIngreso.Focus();
    }

    private void IngresoCancelado(object sender, EventArgs e)
    {
      this.Close();
    }

//    private void Login_KeyPressed(object sender, System.Windows.Forms.KeyPressEventArgs e)
//    {
//      //  ver cual de todos los user controls esta activo...
//      loginIngreso.OnKeyPress(sender, e);
//    }

    private void LoginCorrecto(object sender, Sesion newSes)
    {
      MessageBox.Show(string.Format("Bienvenido/a {0} {1} - Sesion creada!!", 
        newSes.Usuario.Recurso.Nombre, newSes.Usuario.Recurso.Apellido), "Todo OK");
      this.Close();
    }

    /// <summary>
    /// El evento pasa la excepcion que se produjo...
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="ex"></param>
    private void FallasLogin(object sender, Exception ex)
    {
      MessageBox.Show(ex.Message, "Error al ingresar", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
  }
}