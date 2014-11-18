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
      this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
      this.ctlEditProveedor = new HidUI.Views.ProveedorEditControl();
      ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
      this.SuspendLayout();
      // 
      // ctlEditProveedor
      // 
      this.ctlEditProveedor.Action = HidUI.Common.FormEditAction.EditarNuevo;
      this.ctlEditProveedor.Dock = System.Windows.Forms.DockStyle.Fill;
      this.ctlEditProveedor.Location = new System.Drawing.Point(0, 0);
      this.ctlEditProveedor.Name = "ctlEditProveedor";
      this.ctlEditProveedor.Size = new System.Drawing.Size(632, 236);
      this.ctlEditProveedor.TabIndex = 0;
      this.ctlEditProveedor.CloseView += new System.EventHandler(this.Cerrar_Dialogo);
      // 
      // winProveedores
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(632, 236);
      this.ControlBox = false;
      this.Controls.Add(this.ctlEditProveedor);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Name = "winProveedores";
      this.ShowIcon = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Nuevo Proveedor";
      ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.BindingSource bindingSource1;
    private ProveedorEditControl ctlEditProveedor;

  }
}