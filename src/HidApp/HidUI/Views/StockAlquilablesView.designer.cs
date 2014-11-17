namespace HidUI.Views
{
  partial class StockAlquilablesView
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
      this.gridAlquilables = new DevExpress.XtraGrid.GridControl();
      this.gviewAlquilables = new DevExpress.XtraGrid.Views.Grid.GridView();
      ((System.ComponentModel.ISupportInitialize)(this.gridAlquilables)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gviewAlquilables)).BeginInit();
      this.SuspendLayout();
      // 
      // labelControl1
      // 
      this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 24F);
      this.labelControl1.Location = new System.Drawing.Point(542, 377);
      this.labelControl1.Margin = new System.Windows.Forms.Padding(15);
      this.labelControl1.Name = "labelControl1";
      this.labelControl1.Padding = new System.Windows.Forms.Padding(10);
      this.labelControl1.Size = new System.Drawing.Size(308, 65);
      this.labelControl1.TabIndex = 0;
      this.labelControl1.Text = "Stock de Alquilables";
      // 
      // gridAlquilables
      // 
      this.gridAlquilables.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.gridAlquilables.Cursor = System.Windows.Forms.Cursors.Default;
      this.gridAlquilables.Font = new System.Drawing.Font("Segoe UI", 10F);
      this.gridAlquilables.Location = new System.Drawing.Point(25, 25);
      this.gridAlquilables.MainView = this.gviewAlquilables;
      this.gridAlquilables.Margin = new System.Windows.Forms.Padding(25);
      this.gridAlquilables.Name = "gridAlquilables";
      this.gridAlquilables.Size = new System.Drawing.Size(644, 333);
      this.gridAlquilables.TabIndex = 6;
      this.gridAlquilables.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gviewAlquilables});
      // 
      // gviewAlquilables
      // 
      this.gviewAlquilables.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 10F);
      this.gviewAlquilables.Appearance.Row.Options.UseFont = true;
      this.gviewAlquilables.GridControl = this.gridAlquilables;
      this.gviewAlquilables.Name = "gviewAlquilables";
      // 
      // StockAlquilablesView
      // 
      this.Appearance.BackColor = System.Drawing.Color.YellowGreen;
      this.Appearance.Options.UseBackColor = true;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.gridAlquilables);
      this.Controls.Add(this.labelControl1);
      this.Name = "StockAlquilablesView";
      this.Size = new System.Drawing.Size(865, 457);
      ((System.ComponentModel.ISupportInitialize)(this.gridAlquilables)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gviewAlquilables)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private DevExpress.XtraEditors.LabelControl labelControl1;
    private DevExpress.XtraGrid.GridControl gridAlquilables;
    private DevExpress.XtraGrid.Views.Grid.GridView gviewAlquilables;
  }
}
