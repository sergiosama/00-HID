using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity.Core;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.XtraPrinting.Native;

using Entidades;
using Servicios;
using Infraestructura;

namespace HidUI.Views
{
  public partial class LoginIngresoNormal : DevExpress.XtraEditors.XtraUserControl
  {
    public event EventHandler CancelLogin;
    public event EventHandler<Sesion> LoginOK;
    public event EventHandler<Exception> LoginIssues;

    public LoginIngresoNormal()
    {
      InitializeComponent();
    }

    private void LoginUser(object sender, EventArgs e)
    {
      errLogin.ClearErrors();
      if (!string.IsNullOrWhiteSpace(txtUser.Text))
      {
        if (!string.IsNullOrWhiteSpace(txtPassword.Text))
        {
          //  all right intentar login...
          SecurityServices ss = new SecurityServices();

          try
          {
            Sesion newSes = ss.LoginUser(txtUser.Text, txtPassword.Text);

            if (LoginOK != null)
              LoginOK(null, newSes);
          }
          catch (HidAuthException ex)
          {
            if (LoginIssues != null)
              LoginIssues(null, ex);
          }
          catch (HidPasswordExpiredException ex)
          {
            if (LoginIssues != null)
              LoginIssues(null, ex);
          }
          catch (EntityException ex)
          {
            if (LoginIssues != null)
              LoginIssues(null, ex);
          }
          catch (System.Data.SqlClient.SqlException ex)
          {
            if (LoginIssues != null)
              LoginIssues(null, ex);
          }
        }
        else
          errLogin.SetError(txtPassword, "Debe indicarse la contraseña de ingreso para este usuario", ErrorType.Critical);
      }
      else
        errLogin.SetError(txtUser, "El nombre de usuario no puede estar vacio para efectuar el ingreso", ErrorType.Critical);
    }

    private void LoginCancelado(object sender, EventArgs e)
    {
      if (CancelLogin != null)
        CancelLogin(this, null);
    }

    public void Focus()
    {
      txtUser.Focus();
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
          LoginUser(this, null);
          return true;
        }
        if ((Keys)m.WParam == Keys.Escape)
        {
          LoginCancelado(this, null);
          return true;
        }
      }
      return base.ProcessKeyPreview(ref m);
    }


//    public void OnKeyPress(object sender, KeyPressEventArgs e)
//    {
//      if (e.KeyChar == (char) Keys.Return)
//      {
//        e.Handled = true;
//        LoginUser(this, null);
//      }
//
//      if (e.KeyChar == (char) Keys.Escape)
//      {
//        e.Handled = true;
//        LoginCancelado(this, null);
//      }
//    }

  }
}
