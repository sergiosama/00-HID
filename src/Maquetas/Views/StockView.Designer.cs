namespace Maquetas.Views
{
  partial class StockView
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockView));
      this.ribStock = new DevExpress.XtraBars.Ribbon.RibbonControl();
      this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
      this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
      this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
      this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
      this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
      this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
      this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
      this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
      this.ribbonPage4 = new DevExpress.XtraBars.Ribbon.RibbonPage();
      this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
      ((System.ComponentModel.ISupportInitialize)(this.ribStock)).BeginInit();
      this.SuspendLayout();
      // 
      // ribStock
      // 
      this.ribStock.ExpandCollapseItem.Id = 0;
      this.ribStock.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribStock.ExpandCollapseItem,
            this.barButtonItem1,
            this.barButtonItem2});
      this.ribStock.Location = new System.Drawing.Point(0, 0);
      this.ribStock.MaxItemId = 3;
      this.ribStock.Name = "ribStock";
      this.ribStock.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2,
            this.ribbonPage3,
            this.ribbonPage4});
      this.ribStock.Size = new System.Drawing.Size(765, 142);
      // 
      // barButtonItem1
      // 
      this.barButtonItem1.Caption = "Nuevo";
      this.barButtonItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.Glyph")));
      this.barButtonItem1.Id = 1;
      this.barButtonItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.LargeGlyph")));
      this.barButtonItem1.Name = "barButtonItem1";
      // 
      // barButtonItem2
      // 
      this.barButtonItem2.Caption = "Nuevo";
      this.barButtonItem2.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.Glyph")));
      this.barButtonItem2.Id = 2;
      this.barButtonItem2.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.LargeGlyph")));
      this.barButtonItem2.Name = "barButtonItem2";
      // 
      // ribbonPage1
      // 
      this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
      this.ribbonPage1.Name = "ribbonPage1";
      this.ribbonPage1.Text = "INSUMOS";
      // 
      // ribbonPageGroup1
      // 
      this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem1);
      this.ribbonPageGroup1.Name = "ribbonPageGroup1";
      // 
      // ribbonPage2
      // 
      this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
      this.ribbonPage2.Name = "ribbonPage2";
      this.ribbonPage2.Text = "ALQUILABLES";
      // 
      // ribbonPageGroup2
      // 
      this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem2);
      this.ribbonPageGroup2.Name = "ribbonPageGroup2";
      this.ribbonPageGroup2.Text = "ribbonPageGroup2";
      // 
      // ribbonPage3
      // 
      this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
      this.ribbonPage3.Name = "ribbonPage3";
      this.ribbonPage3.Text = "ETIQUETAS";
      // 
      // ribbonPageGroup3
      // 
      this.ribbonPageGroup3.Name = "ribbonPageGroup3";
      this.ribbonPageGroup3.Text = "ribbonPageGroup3";
      // 
      // ribbonPage4
      // 
      this.ribbonPage4.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4});
      this.ribbonPage4.Name = "ribbonPage4";
      this.ribbonPage4.Text = "REPORTES";
      // 
      // ribbonPageGroup4
      // 
      this.ribbonPageGroup4.Name = "ribbonPageGroup4";
      this.ribbonPageGroup4.Text = "ribbonPageGroup4";
      // 
      // StockView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.ribStock);
      this.Name = "StockView";
      this.Size = new System.Drawing.Size(765, 593);
      ((System.ComponentModel.ISupportInitialize)(this.ribStock)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private DevExpress.XtraBars.Ribbon.RibbonControl ribStock;
    private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
    private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
    private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
    private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
    private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage4;
    private DevExpress.XtraBars.BarButtonItem barButtonItem1;
    private DevExpress.XtraBars.BarButtonItem barButtonItem2;
    private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
    private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
    private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
  }
}
