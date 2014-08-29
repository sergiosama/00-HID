namespace HidUI.Views
{
  partial class winConfirmarRecuperarPassword
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
      DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
      DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
      DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
      this.textEdit3 = new DevExpress.XtraEditors.TextEdit();
      this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
      this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
      this.btnSendPassword = new DevExpress.XtraEditors.SimpleButton();
      this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
      ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
      this.SuspendLayout();
      // 
      // textEdit3
      // 
      this.textEdit3.Location = new System.Drawing.Point(152, 38);
      this.textEdit3.Margin = new System.Windows.Forms.Padding(10);
      this.textEdit3.Name = "textEdit3";
      this.textEdit3.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
      this.textEdit3.Properties.Appearance.Options.UseFont = true;
      this.textEdit3.Size = new System.Drawing.Size(260, 24);
      superToolTip1.AllowHtmlText = DevExpress.Utils.DefaultBoolean.True;
      toolTipTitleItem1.Text = "Que hago si no recuerdo mi usuario?";
      toolTipItem1.LeftIndent = 6;
      toolTipItem1.Text = "Contactarse con los administradores del sistema , consulte la opción <b>Acerca de" +
    "...</b> en la cinta de opciones para obtener los datos de contacto";
      superToolTip1.Items.Add(toolTipTitleItem1);
      superToolTip1.Items.Add(toolTipItem1);
      this.textEdit3.SuperTip = superToolTip1;
      this.textEdit3.TabIndex = 16;
      // 
      // labelControl3
      // 
      this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
      this.labelControl3.Location = new System.Drawing.Point(152, 12);
      this.labelControl3.Margin = new System.Windows.Forms.Padding(10);
      this.labelControl3.Name = "labelControl3";
      this.labelControl3.Size = new System.Drawing.Size(228, 17);
      this.labelControl3.TabIndex = 15;
      this.labelControl3.Text = "Nombre del Usuario (debe recordarlo)";
      // 
      // simpleButton1
      // 
      this.simpleButton1.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
      this.simpleButton1.Appearance.Options.UseFont = true;
      this.simpleButton1.Enabled = false;
      this.simpleButton1.Location = new System.Drawing.Point(152, 103);
      this.simpleButton1.Margin = new System.Windows.Forms.Padding(10);
      this.simpleButton1.Name = "simpleButton1";
      this.simpleButton1.Size = new System.Drawing.Size(120, 40);
      this.simpleButton1.TabIndex = 14;
      this.simpleButton1.Text = "Cancelar";
      // 
      // btnSendPassword
      // 
      this.btnSendPassword.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
      this.btnSendPassword.Appearance.Options.UseFont = true;
      this.btnSendPassword.Enabled = false;
      this.btnSendPassword.Location = new System.Drawing.Point(292, 103);
      this.btnSendPassword.Margin = new System.Windows.Forms.Padding(10);
      this.btnSendPassword.Name = "btnSendPassword";
      this.btnSendPassword.Size = new System.Drawing.Size(120, 40);
      this.btnSendPassword.TabIndex = 13;
      this.btnSendPassword.Text = "Enviar Contraseña";
      // 
      // panelControl1
      // 
      this.panelControl1.AutoSize = true;
      this.panelControl1.ContentImage = global::HidUI.Properties.Resources.realvista_general_lock_128;
      this.panelControl1.Location = new System.Drawing.Point(12, 12);
      this.panelControl1.Name = "panelControl1";
      this.panelControl1.Size = new System.Drawing.Size(127, 131);
      this.panelControl1.TabIndex = 17;
      // 
      // winConfirmarRecuperarPassword
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(421, 158);
      this.ControlBox = false;
      this.Controls.Add(this.panelControl1);
      this.Controls.Add(this.textEdit3);
      this.Controls.Add(this.labelControl3);
      this.Controls.Add(this.simpleButton1);
      this.Controls.Add(this.btnSendPassword);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "winConfirmarRecuperarPassword";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Seguro que quiere recuperar su contraseña?";
      ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private DevExpress.XtraEditors.TextEdit textEdit3;
    private DevExpress.XtraEditors.LabelControl labelControl3;
    private DevExpress.XtraEditors.SimpleButton simpleButton1;
    private DevExpress.XtraEditors.SimpleButton btnSendPassword;
    private DevExpress.XtraEditors.PanelControl panelControl1;
  }
}