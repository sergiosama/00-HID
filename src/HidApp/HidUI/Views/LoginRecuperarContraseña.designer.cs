namespace HidUI.Views
{
  partial class LoginRecuperarContraseña
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

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
      this.SuspendLayout();
      // 
      // labelControl1
      // 
      this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI Light", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
      this.labelControl1.Appearance.ForeColor = System.Drawing.Color.MediumBlue;
      this.labelControl1.Location = new System.Drawing.Point(7, 4);
      this.labelControl1.Name = "labelControl1";
      this.labelControl1.Size = new System.Drawing.Size(158, 20);
      this.labelControl1.TabIndex = 6;
      this.labelControl1.Text = "Recuperar Contraseña";
      this.labelControl1.Click += new System.EventHandler(this.RecuperarPassword);
      // 
      // LoginRecuperarContraseña
      // 
      this.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
      this.Appearance.Options.UseFont = true;
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.labelControl1);
      this.Margin = new System.Windows.Forms.Padding(10);
      this.Name = "LoginRecuperarContraseña";
      this.Size = new System.Drawing.Size(211, 29);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private DevExpress.XtraEditors.LabelControl labelControl1;

  }
}
