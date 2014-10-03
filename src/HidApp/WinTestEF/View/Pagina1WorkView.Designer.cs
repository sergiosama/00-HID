namespace WinTestEF.View
{
  partial class Pagina1WorkView
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
      this.txtPagina1 = new DevExpress.XtraEditors.TextEdit();
      ((System.ComponentModel.ISupportInitialize)(this.txtPagina1.Properties)).BeginInit();
      this.SuspendLayout();
      // 
      // txtPagina1
      // 
      this.txtPagina1.Location = new System.Drawing.Point(183, 204);
      this.txtPagina1.Name = "txtPagina1";
      this.txtPagina1.Properties.Appearance.BackColor = System.Drawing.Color.LightGreen;
      this.txtPagina1.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 14F);
      this.txtPagina1.Properties.Appearance.Options.UseBackColor = true;
      this.txtPagina1.Properties.Appearance.Options.UseFont = true;
      this.txtPagina1.Size = new System.Drawing.Size(375, 32);
      this.txtPagina1.TabIndex = 0;
      // 
      // Pagina1WorkView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.txtPagina1);
      this.Name = "Pagina1WorkView";
      this.Size = new System.Drawing.Size(600, 392);
      ((System.ComponentModel.ISupportInitialize)(this.txtPagina1.Properties)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraEditors.TextEdit txtPagina1;
  }
}
