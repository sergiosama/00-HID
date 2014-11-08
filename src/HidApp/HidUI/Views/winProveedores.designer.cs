namespace HidUI.Views
{
  partial class winProveedores
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
      this.components = new System.ComponentModel.Container();
      DevExpress.Utils.SuperToolTip superToolTip2 = new DevExpress.Utils.SuperToolTip();
      DevExpress.Utils.ToolTipTitleItem toolTipTitleItem2 = new DevExpress.Utils.ToolTipTitleItem();
      DevExpress.Utils.ToolTipItem toolTipItem2 = new DevExpress.Utils.ToolTipItem();
      this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
      this.btnDoAndKeep = new DevExpress.XtraEditors.SimpleButton();
      this.txtNombre = new DevExpress.XtraEditors.TextEdit();
      this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
      this.btnDoAndExit = new DevExpress.XtraEditors.SimpleButton();
      this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
      this.txtDireccion = new DevExpress.XtraEditors.TextEdit();
      this.txtCUIT = new DevExpress.XtraEditors.TextEdit();
      this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
      this.chkHabilitado = new DevExpress.XtraEditors.CheckEdit();
      this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
      ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtDireccion.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtCUIT.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.chkHabilitado.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
      this.SuspendLayout();
      // 
      // labelControl3
      // 
      this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
      this.labelControl3.Location = new System.Drawing.Point(19, 65);
      this.labelControl3.Margin = new System.Windows.Forms.Padding(10);
      this.labelControl3.Name = "labelControl3";
      this.labelControl3.Size = new System.Drawing.Size(54, 17);
      this.labelControl3.TabIndex = 22;
      this.labelControl3.Text = "Direccion";
      // 
      // btnDoAndKeep
      // 
      this.btnDoAndKeep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnDoAndKeep.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
      this.btnDoAndKeep.Appearance.Options.UseFont = true;
      this.btnDoAndKeep.Location = new System.Drawing.Point(370, 194);
      this.btnDoAndKeep.Margin = new System.Windows.Forms.Padding(10);
      this.btnDoAndKeep.Name = "btnDoAndKeep";
      this.btnDoAndKeep.Size = new System.Drawing.Size(120, 40);
      this.btnDoAndKeep.TabIndex = 5;
      this.btnDoAndKeep.Text = "Agrega y Sigue";
      this.btnDoAndKeep.Click += new System.EventHandler(this.Botones_OnClick);
      // 
      // txtNombre
      // 
      this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtNombre.Location = new System.Drawing.Point(172, 16);
      this.txtNombre.Margin = new System.Windows.Forms.Padding(10);
      this.txtNombre.Name = "txtNombre";
      this.txtNombre.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
      this.txtNombre.Properties.Appearance.Options.UseFont = true;
      this.txtNombre.Size = new System.Drawing.Size(458, 24);
      this.txtNombre.TabIndex = 0;
      // 
      // labelControl1
      // 
      this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
      this.labelControl1.Location = new System.Drawing.Point(19, 19);
      this.labelControl1.Margin = new System.Windows.Forms.Padding(10);
      this.labelControl1.Name = "labelControl1";
      this.labelControl1.Size = new System.Drawing.Size(139, 17);
      this.labelControl1.TabIndex = 18;
      this.labelControl1.Text = "Nombre o Razon Social";
      // 
      // btnDoAndExit
      // 
      this.btnDoAndExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnDoAndExit.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
      this.btnDoAndExit.Appearance.Options.UseFont = true;
      this.btnDoAndExit.Location = new System.Drawing.Point(510, 194);
      this.btnDoAndExit.Margin = new System.Windows.Forms.Padding(10);
      this.btnDoAndExit.Name = "btnDoAndExit";
      this.btnDoAndExit.Size = new System.Drawing.Size(120, 40);
      this.btnDoAndExit.TabIndex = 4;
      this.btnDoAndExit.Text = "Agrega y Sale";
      this.btnDoAndExit.Click += new System.EventHandler(this.Botones_OnClick);
      // 
      // btnCancelar
      // 
      this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnCancelar.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
      this.btnCancelar.Appearance.Options.UseFont = true;
      this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnCancelar.Location = new System.Drawing.Point(230, 194);
      this.btnCancelar.Margin = new System.Windows.Forms.Padding(10);
      this.btnCancelar.Name = "btnCancelar";
      this.btnCancelar.Size = new System.Drawing.Size(120, 40);
      this.btnCancelar.TabIndex = 6;
      this.btnCancelar.Text = "Cancelar";
      // 
      // txtDireccion
      // 
      this.txtDireccion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtDireccion.Location = new System.Drawing.Point(172, 62);
      this.txtDireccion.Margin = new System.Windows.Forms.Padding(10);
      this.txtDireccion.Name = "txtDireccion";
      this.txtDireccion.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
      this.txtDireccion.Properties.Appearance.Options.UseFont = true;
      this.txtDireccion.Size = new System.Drawing.Size(458, 24);
      this.txtDireccion.TabIndex = 1;
      // 
      // txtCUIT
      // 
      this.txtCUIT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtCUIT.Location = new System.Drawing.Point(172, 108);
      this.txtCUIT.Margin = new System.Windows.Forms.Padding(10);
      this.txtCUIT.Name = "txtCUIT";
      this.txtCUIT.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
      this.txtCUIT.Properties.Appearance.Options.UseFont = true;
      this.txtCUIT.Properties.Mask.EditMask = "(20|30)-\\d\\d\\d\\d\\d\\d\\d\\d-\\d|99-\\d\\d\\d\\d\\d\\d\\d\\d-X";
      this.txtCUIT.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
      this.txtCUIT.Size = new System.Drawing.Size(277, 24);
      toolTipTitleItem2.Text = "CUIT o DNI del proveedor";
      toolTipItem2.LeftIndent = 6;
      toolTipItem2.Text = "Ingresar el CUIT del Proveedor, en caso de no disponer del mismo, reemplazar con " +
    "el DNI de la persona responsable, colocando 99 en el primer campo y X en el ulti" +
    "mo";
      superToolTip2.Items.Add(toolTipTitleItem2);
      superToolTip2.Items.Add(toolTipItem2);
      this.txtCUIT.SuperTip = superToolTip2;
      this.txtCUIT.TabIndex = 2;
      // 
      // labelControl2
      // 
      this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
      this.labelControl2.Location = new System.Drawing.Point(19, 111);
      this.labelControl2.Margin = new System.Windows.Forms.Padding(10);
      this.labelControl2.Name = "labelControl2";
      this.labelControl2.Size = new System.Drawing.Size(27, 17);
      this.labelControl2.TabIndex = 25;
      this.labelControl2.Text = "CUIT";
      // 
      // chkHabilitado
      // 
      this.chkHabilitado.EditValue = true;
      this.chkHabilitado.Location = new System.Drawing.Point(19, 154);
      this.chkHabilitado.Name = "chkHabilitado";
      this.chkHabilitado.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
      this.chkHabilitado.Properties.Appearance.Options.UseFont = true;
      this.chkHabilitado.Properties.Caption = "Habilitado";
      this.chkHabilitado.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far;
      this.chkHabilitado.Size = new System.Drawing.Size(97, 21);
      this.chkHabilitado.TabIndex = 3;
      // 
      // winProveedores
      // 
      this.AcceptButton = this.btnDoAndExit;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.btnCancelar;
      this.ClientSize = new System.Drawing.Size(649, 253);
      this.ControlBox = false;
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
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Name = "winProveedores";
      this.ShowIcon = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Nuevo Proveedor";
      ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtDireccion.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtCUIT.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.chkHabilitado.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private DevExpress.XtraEditors.LabelControl labelControl3;
    private DevExpress.XtraEditors.SimpleButton btnDoAndKeep;
    private DevExpress.XtraEditors.TextEdit txtNombre;
    private DevExpress.XtraEditors.LabelControl labelControl1;
    private DevExpress.XtraEditors.SimpleButton btnDoAndExit;
    private DevExpress.XtraEditors.SimpleButton btnCancelar;
    private DevExpress.XtraEditors.TextEdit txtDireccion;
    private DevExpress.XtraEditors.TextEdit txtCUIT;
    private DevExpress.XtraEditors.LabelControl labelControl2;
    private DevExpress.XtraEditors.CheckEdit chkHabilitado;
    private System.Windows.Forms.BindingSource bindingSource1;

  }
}