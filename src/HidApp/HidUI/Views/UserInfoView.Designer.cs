namespace HidUI.Views
{
  partial class UserInfoView
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
      DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
      DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
      DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
      this.lblLoginDesde = new DevExpress.XtraEditors.LabelControl();
      this.lblFuncionUsuario = new DevExpress.XtraEditors.LabelControl();
      this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
      this.lblUserMail = new DevExpress.XtraEditors.LabelControl();
      this.lblUserName = new DevExpress.XtraEditors.LabelControl();
      this.imgUsuario = new System.Windows.Forms.PictureBox();
      ((System.ComponentModel.ISupportInitialize)(this.imgUsuario)).BeginInit();
      this.SuspendLayout();
      // 
      // lblLoginDesde
      // 
      this.lblLoginDesde.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
      this.lblLoginDesde.Location = new System.Drawing.Point(118, 70);
      this.lblLoginDesde.Margin = new System.Windows.Forms.Padding(10);
      this.lblLoginDesde.Name = "lblLoginDesde";
      this.lblLoginDesde.Size = new System.Drawing.Size(131, 17);
      toolTipTitleItem1.Text = "Fecha y Hora de la conexion actual";
      toolTipItem1.LeftIndent = 6;
      toolTipItem1.Text = "Indica el dia o la cantidad de dias segun corresponda y la hora en la que el usua" +
    "rio inicio esta sesion. Tiempos muy largos pueden producir mensajes auditables";
      superToolTip1.Items.Add(toolTipTitleItem1);
      superToolTip1.Items.Add(toolTipItem1);
      this.lblLoginDesde.SuperTip = superToolTip1;
      this.lblLoginDesde.TabIndex = 11;
      this.lblLoginDesde.Text = "Conectado: Hoy, 22:00";
      // 
      // lblFuncionUsuario
      // 
      this.lblFuncionUsuario.Appearance.BackColor = System.Drawing.Color.Blue;
      this.lblFuncionUsuario.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
      this.lblFuncionUsuario.Appearance.ForeColor = System.Drawing.Color.White;
      this.lblFuncionUsuario.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
      this.lblFuncionUsuario.Location = new System.Drawing.Point(8, 120);
      this.lblFuncionUsuario.Margin = new System.Windows.Forms.Padding(10);
      this.lblFuncionUsuario.Name = "lblFuncionUsuario";
      this.lblFuncionUsuario.Padding = new System.Windows.Forms.Padding(3);
      this.lblFuncionUsuario.Size = new System.Drawing.Size(160, 23);
      this.lblFuncionUsuario.TabIndex = 10;
      this.lblFuncionUsuario.Text = "Responsable de Sistemas";
      // 
      // simpleButton1
      // 
      this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.simpleButton1.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
      this.simpleButton1.Appearance.Options.UseFont = true;
      this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
      this.simpleButton1.Location = new System.Drawing.Point(179, 119);
      this.simpleButton1.Margin = new System.Windows.Forms.Padding(10);
      this.simpleButton1.Name = "simpleButton1";
      this.simpleButton1.Size = new System.Drawing.Size(100, 24);
      this.simpleButton1.TabIndex = 9;
      this.simpleButton1.Text = "Ver mi Perfil";
      this.simpleButton1.Click += new System.EventHandler(this.VerPerfil_Click);
      // 
      // lblUserMail
      // 
      this.lblUserMail.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
      this.lblUserMail.AutoEllipsis = true;
      this.lblUserMail.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
      this.lblUserMail.Location = new System.Drawing.Point(118, 33);
      this.lblUserMail.Margin = new System.Windows.Forms.Padding(10);
      this.lblUserMail.Name = "lblUserMail";
      this.lblUserMail.Size = new System.Drawing.Size(150, 17);
      this.lblUserMail.TabIndex = 8;
      this.lblUserMail.Text = "ethedy@gmail.com";
      // 
      // lblUserName
      // 
      this.lblUserName.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
      this.lblUserName.Location = new System.Drawing.Point(118, 7);
      this.lblUserName.Margin = new System.Windows.Forms.Padding(10);
      this.lblUserName.Name = "lblUserName";
      this.lblUserName.Size = new System.Drawing.Size(100, 20);
      this.lblUserName.TabIndex = 6;
      this.lblUserName.Text = "Enrique Thedy";
      // 
      // imgUsuario
      // 
      this.imgUsuario.Image = global::HidUI.Properties.Resources.M_Avatar_128;
      this.imgUsuario.Location = new System.Drawing.Point(8, 7);
      this.imgUsuario.Margin = new System.Windows.Forms.Padding(10);
      this.imgUsuario.Name = "imgUsuario";
      this.imgUsuario.Size = new System.Drawing.Size(100, 100);
      this.imgUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.imgUsuario.TabIndex = 7;
      this.imgUsuario.TabStop = false;
      // 
      // UserInfoView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.lblLoginDesde);
      this.Controls.Add(this.lblFuncionUsuario);
      this.Controls.Add(this.simpleButton1);
      this.Controls.Add(this.lblUserMail);
      this.Controls.Add(this.imgUsuario);
      this.Controls.Add(this.lblUserName);
      this.Name = "UserInfoView";
      this.Size = new System.Drawing.Size(289, 154);
      this.Load += new System.EventHandler(this.UserInfo_Load);
      ((System.ComponentModel.ISupportInitialize)(this.imgUsuario)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private DevExpress.XtraEditors.LabelControl lblLoginDesde;
    private DevExpress.XtraEditors.LabelControl lblFuncionUsuario;
    private DevExpress.XtraEditors.SimpleButton simpleButton1;
    private DevExpress.XtraEditors.LabelControl lblUserMail;
    private System.Windows.Forms.PictureBox imgUsuario;
    private DevExpress.XtraEditors.LabelControl lblUserName;
  }
}
