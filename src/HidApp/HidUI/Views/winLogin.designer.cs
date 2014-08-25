namespace HidUI.Views
{
  partial class winLogin
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
      this.loginRecuperarContraseña1 = new HidUI.Views.LoginRecuperarContraseña();
      this.loginIngresoNormal1 = new HidUI.Views.LoginIngresoNormal();
      ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
      this.SuspendLayout();
      // 
      // panelControl1
      // 
      this.panelControl1.ContentImage = global::HidUI.Properties.Resources.HID_Logo;
      this.panelControl1.Location = new System.Drawing.Point(14, 14);
      this.panelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.panelControl1.Name = "panelControl1";
      this.panelControl1.Size = new System.Drawing.Size(211, 145);
      this.panelControl1.TabIndex = 0;
      // 
      // loginRecuperarContraseña1
      // 
      this.loginRecuperarContraseña1.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
      this.loginRecuperarContraseña1.Appearance.Options.UseFont = true;
      this.loginRecuperarContraseña1.Location = new System.Drawing.Point(14, 170);
      this.loginRecuperarContraseña1.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
      this.loginRecuperarContraseña1.Name = "loginRecuperarContraseña1";
      this.loginRecuperarContraseña1.Size = new System.Drawing.Size(211, 29);
      this.loginRecuperarContraseña1.TabIndex = 2;
      // 
      // loginIngresoNormal1
      // 
      this.loginIngresoNormal1.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
      this.loginIngresoNormal1.Appearance.Options.UseFont = true;
      this.loginIngresoNormal1.Location = new System.Drawing.Point(245, 19);
      this.loginIngresoNormal1.Margin = new System.Windows.Forms.Padding(10);
      this.loginIngresoNormal1.Name = "loginIngresoNormal1";
      this.loginIngresoNormal1.Size = new System.Drawing.Size(285, 175);
      this.loginIngresoNormal1.TabIndex = 3;
      // 
      // winLogin
      // 
      this.Appearance.Options.UseFont = true;
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(542, 218);
      this.ControlBox = false;
      this.Controls.Add(this.loginIngresoNormal1);
      this.Controls.Add(this.loginRecuperarContraseña1);
      this.Controls.Add(this.panelControl1);
      this.Font = new System.Drawing.Font("Segoe UI", 10F);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
      this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.MaximizeBox = false;
      this.Name = "winLogin";
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Ingreso al Sistema";
      this.Load += new System.EventHandler(this.LoginLoaded);
      ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraEditors.PanelControl panelControl1;
    private LoginRecuperarContraseña loginRecuperarContraseña1;
    private LoginIngresoNormal loginIngresoNormal1;
  }
}