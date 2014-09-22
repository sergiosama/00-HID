using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraEditors;

using Entidades;
using Infraestructura;

namespace HidUI.Views
{
  public partial class UserInfoView : DevExpress.XtraEditors.XtraUserControl
  {
    public event EventHandler VerPerfil;

    private ImageConverter _converter;
    private enTRecurso _recurso;

    public UserInfoView()
    {
      InitializeComponent();
      _converter = new ImageConverter();
    }

    private void VerPerfil_Click(object sender, EventArgs e)
    {
      if (VerPerfil != null)
        VerPerfil(null, null);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    /// <remarks>
    /// Cuidado!! El usuario original puede haberse desconectado y ahora hay otro recurso por lo tanto hay que refrescar toda la informacion
    /// </remarks>
    private void UserInfo_Load(object sender, EventArgs e)
    {
      if (!this.DesignMode)
      {
        RefreshUserInfo();
      }
    }

    /// <summary>
    /// Actualiza la informacion del usuario que podria haber cambiado desde la ultima vez que se activo el control
    /// Verifica si el mismo usuario no cambio, en tal caso actualiza completo
    /// </summary>
    public void RefreshUserInfo()
    {
      //  Si el usuario cambio desde la ultima vez...tengo que refrescar toda la informacion
      if (_recurso == null || _recurso.IdRecurso != Contexto.Current.Sesion.Usuario.Recurso.IdRecurso)
      {
        _recurso = Contexto.Current.Sesion.Usuario.Recurso;
        RefreshUserInfoInternal();
      }

      DateTime login = Contexto.Current.Sesion.LastLogin;
      int dias = (DateTime.Now - login).Days;
      string desde;

      switch (dias)
      {
        case 0:
          desde = string.Format("Conectado: hoy, {0}", login.ToString("HH:mm"));
          break;

        case 1:
          desde = string.Format("Conectado: ayer, {0}", login.ToString("HH:mm"));
          break;

        default:
          desde = string.Format("Conectado: hace {0} dias", dias);
          break;
      }
      lblLoginDesde.Text = desde;
    }

    /// <summary>
    /// Actualiza la informacion fija del usuario (foto, nombre, mail...)
    /// </summary>
    private void RefreshUserInfoInternal()
    {
      lblUserName.Text = string.Format("{0} {1}", _recurso.Nombre, _recurso.Apellido);

      lblUserMail.Text = _recurso.Email ?? "<sin email>";

      lblUserMail.SuperTip = new SuperToolTip();
      lblUserMail.SuperTip.Items.AddTitle("Direccion de correo del usuario");
      lblUserMail.SuperTip.Items.Add(lblUserMail.Text);

      lblFuncionUsuario.Text = _recurso.Categoria.Detalle;
      if (_recurso.Foto == null)
      {
        if (_recurso.Sexo[0] == 'F')
          imgUsuario.Image = global::HidUI.Properties.Resources.F_Avatar_128;
        else
          imgUsuario.Image = global::HidUI.Properties.Resources.M_Avatar_128;
      }
      else
        imgUsuario.Image = (Bitmap)_converter.ConvertFrom(_recurso.Foto);
    }
  }
}
