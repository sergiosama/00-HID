namespace HidUI.Views
{
  partial class ProveedorEditControl
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
      this.chkHabilitado = new DevExpress.XtraEditors.CheckEdit();
      this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
      this.txtCUIT = new DevExpress.XtraEditors.TextEdit();
      this.txtDireccion = new DevExpress.XtraEditors.TextEdit();
      this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
      this.btnDoAndKeep = new DevExpress.XtraEditors.SimpleButton();
      this.txtNombre = new DevExpress.XtraEditors.TextEdit();
      this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
      this.btnDoAndExit = new DevExpress.XtraEditors.SimpleButton();
      this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
      ((System.ComponentModel.ISupportInitialize)(this.chkHabilitado.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtCUIT.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtDireccion.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).BeginInit();
      this.SuspendLayout();
      // 
      // chkHabilitado
      // 
      this.chkHabilitado.EditValue = true;
      this.chkHabilitado.Location = new System.Drawing.Point(12, 148);
      this.chkHabilitado.Name = "chkHabilitado";
      this.chkHabilitado.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
      this.chkHabilitado.Properties.Appearance.Options.UseFont = true;
      this.chkHabilitado.Properties.Caption = "Habilitado";
      this.chkHabilitado.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far;
      this.chkHabilitado.Size = new System.Drawing.Size(97, 21);
      this.chkHabilitado.TabIndex = 29;
      // 
      // labelControl2
      // 
      this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
      this.labelControl2.Location = new System.Drawing.Point(12, 105);
      this.labelControl2.Margin = new System.Windows.Forms.Padding(10);
      this.labelControl2.Name = "labelControl2";
      this.labelControl2.Size = new System.Drawing.Size(27, 17);
      this.labelControl2.TabIndex = 35;
      this.labelControl2.Text = "CUIT";
      // 
      // txtCUIT
      // 
      this.txtCUIT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtCUIT.Location = new System.Drawing.Point(165, 102);
      this.txtCUIT.Margin = new System.Windows.Forms.Padding(10);
      this.txtCUIT.Name = "txtCUIT";
      this.txtCUIT.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
      this.txtCUIT.Properties.Appearance.Options.UseFont = true;
      this.txtCUIT.Properties.Mask.EditMask = "(20|30)-\\d\\d\\d\\d\\d\\d\\d\\d-\\d|99-\\d\\d\\d\\d\\d\\d\\d\\d-X";
      this.txtCUIT.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
      this.txtCUIT.Size = new System.Drawing.Size(263, 24);
      toolTipTitleItem1.Text = "CUIT o DNI del proveedor";
      toolTipItem1.LeftIndent = 6;
      toolTipItem1.Text = "Ingresar el CUIT del Proveedor, en caso de no disponer del mismo, reemplazar con " +
    "el DNI de la persona responsable, colocando 99 en el primer campo y X en el ulti" +
    "mo";
      superToolTip1.Items.Add(toolTipTitleItem1);
      superToolTip1.Items.Add(toolTipItem1);
      this.txtCUIT.SuperTip = superToolTip1;
      this.txtCUIT.TabIndex = 2;
      // 
      // txtDireccion
      // 
      this.txtDireccion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtDireccion.Location = new System.Drawing.Point(165, 56);
      this.txtDireccion.Margin = new System.Windows.Forms.Padding(10);
      this.txtDireccion.Name = "txtDireccion";
      this.txtDireccion.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
      this.txtDireccion.Properties.Appearance.Options.UseFont = true;
      this.txtDireccion.Size = new System.Drawing.Size(460, 24);
      this.txtDireccion.TabIndex = 1;
      // 
      // labelControl3
      // 
      this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
      this.labelControl3.Location = new System.Drawing.Point(12, 59);
      this.labelControl3.Margin = new System.Windows.Forms.Padding(10);
      this.labelControl3.Name = "labelControl3";
      this.labelControl3.Size = new System.Drawing.Size(54, 17);
      this.labelControl3.TabIndex = 34;
      this.labelControl3.Text = "Direccion";
      // 
      // btnDoAndKeep
      // 
      this.btnDoAndKeep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnDoAndKeep.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
      this.btnDoAndKeep.Appearance.Options.UseFont = true;
      this.btnDoAndKeep.Location = new System.Drawing.Point(365, 189);
      this.btnDoAndKeep.Margin = new System.Windows.Forms.Padding(10);
      this.btnDoAndKeep.Name = "btnDoAndKeep";
      this.btnDoAndKeep.Size = new System.Drawing.Size(120, 40);
      this.btnDoAndKeep.TabIndex = 4;
      this.btnDoAndKeep.Text = "Agrega y Sigue";
      this.btnDoAndKeep.Click += new System.EventHandler(this.Botones_OnClick);
      // 
      // txtNombre
      // 
      this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtNombre.Location = new System.Drawing.Point(165, 10);
      this.txtNombre.Margin = new System.Windows.Forms.Padding(10);
      this.txtNombre.Name = "txtNombre";
      this.txtNombre.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
      this.txtNombre.Properties.Appearance.Options.UseFont = true;
      this.txtNombre.Size = new System.Drawing.Size(460, 24);
      this.txtNombre.TabIndex = 0;
      // 
      // labelControl1
      // 
      this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
      this.labelControl1.Location = new System.Drawing.Point(12, 13);
      this.labelControl1.Margin = new System.Windows.Forms.Padding(10);
      this.labelControl1.Name = "labelControl1";
      this.labelControl1.Size = new System.Drawing.Size(139, 17);
      this.labelControl1.TabIndex = 33;
      this.labelControl1.Text = "Nombre o Razon Social";
      // 
      // btnDoAndExit
      // 
      this.btnDoAndExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnDoAndExit.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
      this.btnDoAndExit.Appearance.Options.UseFont = true;
      this.btnDoAndExit.Location = new System.Drawing.Point(505, 189);
      this.btnDoAndExit.Margin = new System.Windows.Forms.Padding(10);
      this.btnDoAndExit.Name = "btnDoAndExit";
      this.btnDoAndExit.Size = new System.Drawing.Size(120, 40);
      this.btnDoAndExit.TabIndex = 3;
      this.btnDoAndExit.Text = "Agrega y Sale";
      this.btnDoAndExit.Click += new System.EventHandler(this.Botones_OnClick);
      // 
      // btnCancelar
      // 
      this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnCancelar.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
      this.btnCancelar.Appearance.Options.UseFont = true;
      this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnCancelar.Location = new System.Drawing.Point(225, 189);
      this.btnCancelar.Margin = new System.Windows.Forms.Padding(10);
      this.btnCancelar.Name = "btnCancelar";
      this.btnCancelar.Size = new System.Drawing.Size(120, 40);
      this.btnCancelar.TabIndex = 5;
      this.btnCancelar.Text = "Cancelar";
      // 
      // ProveedorEditControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.chkHabilitado);
      this.Controls.Add(this.labelControl2);
      this.Controls.Add(this.txtCUIT);
      this.Controls.Add(this.txtDireccion);
      this.Controls.Add(this.labelControl3);
      this.Controls.Add(this.btnDoAndKeep);
      this.Controls.Add(this.txtNombre);
      this.Controls.Add(this.labelControl1);
      this.Controls.Add(this.btnDoAndExit);
      this.Controls.Add(this.btnCancelar);
      this.Name = "ProveedorEditControl";
      this.Size = new System.Drawing.Size(635, 239);
      ((System.ComponentModel.ISupportInitialize)(this.chkHabilitado.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtCUIT.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtDireccion.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private DevExpress.XtraEditors.CheckEdit chkHabilitado;
    private DevExpress.XtraEditors.LabelControl labelControl2;
    private DevExpress.XtraEditors.TextEdit txtCUIT;
    private DevExpress.XtraEditors.TextEdit txtDireccion;
    private DevExpress.XtraEditors.LabelControl labelControl3;
    private DevExpress.XtraEditors.SimpleButton btnDoAndKeep;
    private DevExpress.XtraEditors.TextEdit txtNombre;
    private DevExpress.XtraEditors.LabelControl labelControl1;
    private DevExpress.XtraEditors.SimpleButton btnDoAndExit;
    private DevExpress.XtraEditors.SimpleButton btnCancelar;

  }
}
