namespace HidUI.Views
{
  partial class StockInsumosView
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
      this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
      this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
      this.gridControl1 = new DevExpress.XtraGrid.GridControl();
      this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
      this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
      this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
      this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
      this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
      this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
      this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
      this.layoutControl1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
      this.SuspendLayout();
      // 
      // layoutControl1
      // 
      this.layoutControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
      this.layoutControl1.Controls.Add(this.simpleButton1);
      this.layoutControl1.Controls.Add(this.gridControl1);
      this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.layoutControl1.Location = new System.Drawing.Point(0, 0);
      this.layoutControl1.Margin = new System.Windows.Forms.Padding(0);
      this.layoutControl1.Name = "layoutControl1";
      this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(781, 440, 250, 350);
      this.layoutControl1.Root = this.layoutControlGroup1;
      this.layoutControl1.Size = new System.Drawing.Size(675, 461);
      this.layoutControl1.TabIndex = 1;
      this.layoutControl1.Text = "layoutControl1";
      // 
      // simpleButton1
      // 
      this.simpleButton1.Appearance.BackColor = System.Drawing.Color.Transparent;
      this.simpleButton1.Appearance.Options.UseBackColor = true;
      this.simpleButton1.Image = global::HidUI.Properties.Resources.arrow_left_48;
      this.simpleButton1.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
      this.simpleButton1.Location = new System.Drawing.Point(12, 395);
      this.simpleButton1.Name = "simpleButton1";
      this.simpleButton1.Size = new System.Drawing.Size(58, 54);
      this.simpleButton1.StyleController = this.layoutControl1;
      this.simpleButton1.TabIndex = 6;
      this.simpleButton1.Click += new System.EventHandler(this.NavTo_StartView);
      // 
      // gridControl1
      // 
      this.gridControl1.Location = new System.Drawing.Point(20, 202);
      this.gridControl1.MainView = this.gridView1;
      this.gridControl1.Name = "gridControl1";
      this.gridControl1.Size = new System.Drawing.Size(505, 181);
      this.gridControl1.TabIndex = 0;
      this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
      // 
      // gridView1
      // 
      this.gridView1.GridControl = this.gridControl1;
      this.gridView1.Name = "gridView1";
      // 
      // layoutControlGroup1
      // 
      this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
      this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
      this.layoutControlGroup1.GroupBordersVisible = false;
      this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem2,
            this.layoutControlItem1,
            this.emptySpaceItem1,
            this.emptySpaceItem4,
            this.emptySpaceItem3,
            this.layoutControlItem2});
      this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
      this.layoutControlGroup1.Name = "layoutControlGroup1";
      this.layoutControlGroup1.Size = new System.Drawing.Size(675, 461);
      this.layoutControlGroup1.Text = "layoutControlGroup1";
      this.layoutControlGroup1.TextVisible = false;
      // 
      // emptySpaceItem2
      // 
      this.emptySpaceItem2.AllowHotTrack = false;
      this.emptySpaceItem2.CustomizationFormText = "emptySpaceItem2";
      this.emptySpaceItem2.Location = new System.Drawing.Point(0, 0);
      this.emptySpaceItem2.Name = "emptySpaceItem2";
      this.emptySpaceItem2.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
      this.emptySpaceItem2.Size = new System.Drawing.Size(588, 182);
      this.emptySpaceItem2.Text = "emptySpaceItem2";
      this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
      // 
      // layoutControlItem1
      // 
      this.layoutControlItem1.Control = this.gridControl1;
      this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
      this.layoutControlItem1.Location = new System.Drawing.Point(0, 182);
      this.layoutControlItem1.MinSize = new System.Drawing.Size(201, 24);
      this.layoutControlItem1.Name = "layoutControlItem1";
      this.layoutControlItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
      this.layoutControlItem1.Size = new System.Drawing.Size(525, 201);
      this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
      this.layoutControlItem1.Text = "layoutControlItem1";
      this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem1.TextToControlDistance = 0;
      this.layoutControlItem1.TextVisible = false;
      // 
      // emptySpaceItem1
      // 
      this.emptySpaceItem1.AllowHotTrack = false;
      this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
      this.emptySpaceItem1.Location = new System.Drawing.Point(588, 0);
      this.emptySpaceItem1.Name = "emptySpaceItem1";
      this.emptySpaceItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
      this.emptySpaceItem1.Size = new System.Drawing.Size(67, 383);
      this.emptySpaceItem1.Text = "emptySpaceItem1";
      this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
      // 
      // emptySpaceItem4
      // 
      this.emptySpaceItem4.AllowHotTrack = false;
      this.emptySpaceItem4.CustomizationFormText = "emptySpaceItem4";
      this.emptySpaceItem4.Location = new System.Drawing.Point(62, 383);
      this.emptySpaceItem4.Name = "emptySpaceItem4";
      this.emptySpaceItem4.Size = new System.Drawing.Size(593, 58);
      this.emptySpaceItem4.Text = "emptySpaceItem4";
      this.emptySpaceItem4.TextSize = new System.Drawing.Size(0, 0);
      // 
      // emptySpaceItem3
      // 
      this.emptySpaceItem3.AllowHotTrack = false;
      this.emptySpaceItem3.CustomizationFormText = "emptySpaceItem3";
      this.emptySpaceItem3.Location = new System.Drawing.Point(525, 182);
      this.emptySpaceItem3.Name = "emptySpaceItem3";
      this.emptySpaceItem3.Size = new System.Drawing.Size(63, 201);
      this.emptySpaceItem3.Text = "emptySpaceItem3";
      this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
      // 
      // layoutControlItem2
      // 
      this.layoutControlItem2.Control = this.simpleButton1;
      this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
      this.layoutControlItem2.Location = new System.Drawing.Point(0, 383);
      this.layoutControlItem2.Name = "layoutControlItem2";
      this.layoutControlItem2.Size = new System.Drawing.Size(62, 58);
      this.layoutControlItem2.Text = "layoutControlItem2";
      this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem2.TextToControlDistance = 0;
      this.layoutControlItem2.TextVisible = false;
      // 
      // StockInsumosView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.layoutControl1);
      this.Name = "StockInsumosView";
      this.Size = new System.Drawing.Size(675, 461);
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
      this.layoutControl1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraLayout.LayoutControl layoutControl1;
    private DevExpress.XtraGrid.GridControl gridControl1;
    private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
    private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
    private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
    private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
    private DevExpress.XtraEditors.SimpleButton simpleButton1;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;


  }
}
