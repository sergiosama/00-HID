namespace HidUI.Views
{
  partial class winInsumos
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
      this.ctlEditInsumo = new HidUI.Views.InsumosEditControl();
      ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
      this.SuspendLayout();
      // 
      // ctlEditInsumo
      // 
      this.ctlEditInsumo.Action = HidUI.Common.FormEditAction.EditarNuevo;
      this.ctlEditInsumo.Dock = System.Windows.Forms.DockStyle.Fill;
      this.ctlEditInsumo.Location = new System.Drawing.Point(0, 0);
      this.ctlEditInsumo.Name = "ctlEditInsumo";
      this.ctlEditInsumo.Size = new System.Drawing.Size(748, 425);
      this.ctlEditInsumo.TabIndex = 0;
      this.ctlEditInsumo.CloseView += new System.EventHandler(this.Cerrar_Dialogo);
      // 
      // winInsumos
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(748, 425);
      this.ControlBox = false;
      this.Controls.Add(this.ctlEditInsumo);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Name = "winInsumos";
      this.ShowIcon = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Agregar Insumo";
      ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.BindingSource bindingSource1;
    private InsumosEditControl ctlEditInsumo;

  }
}