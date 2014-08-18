namespace Maquetas.Views
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
      this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
      this.SuspendLayout();
      // 
      // labelControl1
      // 
      this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 24F);
      this.labelControl1.Location = new System.Drawing.Point(137, 15);
      this.labelControl1.Margin = new System.Windows.Forms.Padding(15);
      this.labelControl1.Name = "labelControl1";
      this.labelControl1.Padding = new System.Windows.Forms.Padding(10);
      this.labelControl1.Size = new System.Drawing.Size(308, 65);
      this.labelControl1.TabIndex = 0;
      this.labelControl1.Text = "Stock de Alquilables";
      // 
      // simpleButton1
      // 
      this.simpleButton1.Appearance.BackColor = System.Drawing.Color.Transparent;
      this.simpleButton1.Appearance.Options.UseBackColor = true;
      this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
      this.simpleButton1.Image = global::Maquetas.Properties.Resources.arrow_left_48;
      this.simpleButton1.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
      this.simpleButton1.Location = new System.Drawing.Point(3, 249);
      this.simpleButton1.Name = "simpleButton1";
      this.simpleButton1.Size = new System.Drawing.Size(58, 54);
      this.simpleButton1.TabIndex = 5;
      this.simpleButton1.Click += new System.EventHandler(this.NavTo_StartView);
      // 
      // StockAlquilablesView
      // 
      this.Appearance.BackColor = System.Drawing.Color.YellowGreen;
      this.Appearance.Options.UseBackColor = true;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.simpleButton1);
      this.Controls.Add(this.labelControl1);
      this.Name = "StockAlquilablesView";
      this.Size = new System.Drawing.Size(460, 306);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private DevExpress.XtraEditors.LabelControl labelControl1;
    private DevExpress.XtraEditors.SimpleButton simpleButton1;
  }
}
